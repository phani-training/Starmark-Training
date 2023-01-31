using System;

namespace HospitalSoftware.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public int Fees { get; set; }
        public string Specialization { get; set; }
    }
    
    public class Patient
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public long PatientMobile { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age => DateTime.Now.Year - DateOfBirth.Year;
        public int DoctorId { get; set; }
    }

    public class Billing
    {
        public int BillNo { get; set; }
        public DateTime BillDate { get; set; } = DateTime.Now;
        public int PatientId { get; set; }
        public int BillAmount { get; set; }
    }
}