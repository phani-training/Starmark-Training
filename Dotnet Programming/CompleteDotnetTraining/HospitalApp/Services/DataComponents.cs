using HospitalSoftware.Interfaces;
using HospitalSoftware.Models;
using System;
using System.Linq;
using System.Collections.Generic;

namespace HospitalSoftware.Services
{
    public class DoctorRepo
    {
        public List<Doctor> AllDoctors => new List<Doctor>
        {
            new Doctor{ DoctorId = 1, DoctorName ="Devi Shetty", Fees = 4500, Specialization="Cardialogy"},
            new Doctor{ DoctorId = 2, DoctorName ="Sanjay Gururaj", Fees = 1500, Specialization="General Medicine"},
            new Doctor{ DoctorId = 3, DoctorName ="Nagesh", Fees = 1500, Specialization="Pediatrician"}
        };
    }

    public class PatientRepo : IPatientRepo
    {
        private List<Patient> patients = new List<Patient>();
        public PatientRepo(List<Patient>oldRecords)
        {
            patients = oldRecords;
        }

        public Patient FindPatient(int patientId) => patients.Find((p) => p.PatientId == patientId);

        public List<Patient> GetPatients(int docId) => patients.FindAll((p) => p.DoctorId == docId);

        public void RegisterNewPatient(Patient patient) => patients.Add(patient);

        public void UpdatePatient(Patient patient)
        {
            var selected = FindPatient(patient.PatientId);
            if (selected == null)
                throw new Exception("Patient Details not found");
            selected.PatientMobile = patient.PatientMobile;
            selected.PatientName = patient.PatientName;
            selected.DateOfBirth = patient.DateOfBirth;
            selected.DoctorId = patient.DoctorId;
        }
    }


    public class BillingRepo
    {
        private List<Billing> bills;
        public BillingRepo(List<Billing> oldRecords)
        {
            bills = oldRecords;
        }

        public void AddBill(Patient patientInfo)
        {
            int billNo = bills.LastOrDefault().BillNo;
            Billing billing = new Billing();
            billing.BillNo = ++billNo;
            billing.PatientId = patientInfo.PatientId;
            billing.BillAmount = getFees(patientInfo.DoctorId);
            bills.Add(billing);  
        }

        public List<Billing> AllBills => bills;
        
        private int getFees(int docId)
        {
            var docRepo = new DoctorRepo();
            var doc = docRepo.AllDoctors.Find((d) => d.DoctorId == docId);
            return doc.Fees;
        }
    }
}