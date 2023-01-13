using DataLayer;
using Entities;
using System;
using System.Collections;

namespace Entities
{
    enum Severity { High, Medium, Low };
    class Symptom
    {
        public int Id { get; set; }
        public string SymptomName { get; set; }
        public string Description { get; set; }
    }
    class Disease
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Severity Severity { get; set; }
        public string Cause { get; set; } = "External Factors";
        public string Description { get; set; }
        public ArrayList AllSymptoms { get; private set; } = new ArrayList();

        public void AddSymptom(Symptom symptom) => AllSymptoms.Add(symptom);
    }
}

namespace DataLayer
{
    interface IDiseaseRepo
    {
        Disease[] GetAllDiseases();
        Symptom[] GetAllSymptoms();
        void AddDisease(Disease disease);
        void AddNewSymptom(Disease disease, Symptom symptom);
        Disease[] FindDiseases(params string[] symptoms);
    }

    class DiseaseRepo : IDiseaseRepo
    {
        private ArrayList _diseases = new ArrayList();
        public void AddDisease(Disease disease) => _diseases.Add(disease);


        public void AddNewSymptom(Disease disease, Symptom symptom) => disease.AddSymptom(symptom);

        public Disease[] FindDiseases(params string[] symptoms)
        {
            ArrayList foundDiseases = new ArrayList();
            foreach (var symptom in symptoms)
            {
                foreach(Disease disease in _diseases)
                {
                    foreach(Symptom sym in disease.AllSymptoms)
                    {
                        if(sym.SymptomName == symptom)
                        {
                            if(!foundDiseases.Contains(disease))
                                foundDiseases.Add(disease);
                        }
                    }
                }
            }
            return Utilities.Convert(foundDiseases);

        }

        public Disease[] GetAllDiseases()
        {
            return Utilities.Convert(_diseases);
        }

        public Symptom[] GetAllSymptoms()
        {
            ArrayList symptoms = new ArrayList();
            foreach(Disease disease in _diseases)
            {
                foreach(Symptom symptom in disease.AllSymptoms)
                {
                    if (!symptoms.Contains(symptom))
                        symptoms.Add(symptom);
                }
            }
            return Utilities.ConvertSymptoms(symptoms);
        }
    }

    class Utilities
    {
        internal static Severity GetSeverity()
        {
            Array possibleValues = Enum.GetValues(typeof(Severity));
            foreach(var value in possibleValues)
                Console.WriteLine(value);
            var selected = Utilities.Prompt("Please the severity from the above list");
            return (Severity)Enum.Parse(typeof(Severity), selected);
        }
        internal static string Prompt(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        internal static int GetNumber(string question)
        {
            bool processing = false;
            int result;
            do
            {
                Console.WriteLine(question);
                processing = int.TryParse(Console.ReadLine(), out result);
            } while (!processing);
            return result;
        }

        
        public static Disease[] Convert(ArrayList diseases)
        {
            Disease[] data = new Disease[diseases.Count];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = diseases[i] as Disease;
            } 
            return data;
        }

        public static Symptom[] ConvertSymptoms(ArrayList symptoms)
        {
            Symptom[] data = new Symptom[symptoms.Count];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = symptoms[i] as Symptom;
            }
            return data;
        }
    }
}

namespace UILayer
{
    enum InputChoice
    {
        AddDisease = 1, AddSymptom, CheckPatient 
    }
    static class UIComponent
    {
        static IDiseaseRepo repo = new DiseaseRepo();
        const string menu = "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~MEDICAL RESEARCH SYSTEM~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nPRESS 1 --------------->Add Disease Details\nPRESS 2 -------------->Add Symptom to Disease\nPRESS 3--------------->Check Patient\n";
        static void Main(string[] args)
        {
            bool processing = true;
            do
            {
                InputChoice choice = (InputChoice)Enum.Parse(typeof(InputChoice), Utilities.Prompt(menu)) ;
                processing = processMenu(choice);
            } while (processing);
        }

        private static bool processMenu(InputChoice choice)
        {
            switch (choice)
            {
                case InputChoice.AddDisease:
                    addingDiseaseHelper();
                    break;
                case InputChoice.AddSymptom:
                    addingSymptomHelper();
                    break;
                case InputChoice.CheckPatient:
                    checkPatientHelper();
                    break;
                default:
                    return false;
            }
            return true;
        }

        private static void checkPatientHelper()
        {
            var symptoms = repo.GetAllSymptoms();
            foreach (var symp in symptoms) Console.WriteLine(symp.SymptomName);
            string input = Utilities.Prompt("Enter the Symptoms seperated by Comma, Please enter any of the Above symptoms");
            string[] inputs = input.Split(',');
            var foundDiseases = repo.FindDiseases(inputs);
            foreach(var found in foundDiseases)
                Console.WriteLine(found.Name);
        }

        private static void addingSymptomHelper()
        {
            Symptom symptom = new Symptom();
            //Get all the Diseases:
            var data = repo.GetAllDiseases();
            foreach (var disease in data) Console.WriteLine(disease.Name);
            var found = Utilities.Prompt("Enter the disease from the List above");
            Disease selected = findDisease(found);
            symptom.SymptomName = Utilities.Prompt("Enter the Symptom Name");
            symptom.Description = Utilities.Prompt("Enter the Description");
            repo.AddNewSymptom(selected, symptom);
            Console.WriteLine("Symptom {1} to the Disease {0} added successfully", selected.Name, symptom.SymptomName);
        }

        private static Disease findDisease(string found)
        {
            var all = repo.GetAllDiseases();
            foreach(var disease in all)
            {
                if (disease.Name == found)
                    return disease;
            }
            throw new Exception("Disease not found");
        }

        private static void addingDiseaseHelper()
        {
            Disease disease = new Disease
            {
                Id = Utilities.GetNumber("Enter the Id for the disease"),
                Name = Utilities.Prompt("Enter the DiseaseName"),
                Cause = Utilities.Prompt("Enter the cause for the disease"),
                Severity = Utilities.GetSeverity(),
                Description = Utilities.Prompt("Enter a brief Description of the disease within min of 30 Charecters")
            };
            if (disease.Description.Length < 30)
                throw new Exception("Description of the Disease should be more than 30 charecters");
            repo.AddDisease(disease);
        }
    }

}