using System.ComponentModel.DataAnnotations;
namespace EmployeeApp.ViewModels
{
    
    public class EmployeeVM
    {
        public int EmpId { get; set; }

        [Required(ErrorMessage = "Name is mandatory", AllowEmptyStrings =false)]
        public string EmpName { get; set; }
        [Required(ErrorMessage = "Address is a must", AllowEmptyStrings = false)]
        [MinLength(4, ErrorMessage = "City name should be min of 4 charecters")]
        public string EmpAddress { get; set; }
        [Range(20000, 100000, ErrorMessage = "Salary should be less than 100000 or more than 20000")]
        public decimal EmpSalary { get; set; }

        public int DeptId { get; set; }
    }
}