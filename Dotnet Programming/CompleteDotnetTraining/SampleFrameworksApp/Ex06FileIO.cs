using System;
using System.Collections.Generic;
using System.IO; //=>namespace for all classes related to File Handling
namespace SampleFrameworksApp
{
    class Ex06FileIO
    {
        static void Main(string[] args)
        {
            string deskTopFile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/" + "SampleFile.txt";

            string filename = "../../Ex06FileIO.cs";
            //readFileExample(filename);

            writeFileExample(deskTopFile);

        }

        private static void writeFileExample(string deskTopFile)
        {
            File.WriteAllText(deskTopFile, "Sample Content to be placed in the file for testing file writing");//Opens an existing file, if notfound, creates a new file and writes the text to it.
            
        }

        private static void readFileExample(string filename)
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine("File Path is wrong");
            }
            else
            {
                var contents = File.ReadAllText(filename);
                Console.WriteLine(contents);
            }
        }
    }
}
