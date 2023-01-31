using HospitalSoftware.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSoftware.Interfaces
{
    public interface IPatientRepo
    {
        void RegisterNewPatient(Patient patient);
        void UpdatePatient(Patient patient);
        List<Patient> GetPatients(int docId);
        Patient FindPatient(int patientId);
    }
}
