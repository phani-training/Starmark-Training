using DataAccessLib;
using System.Collections.Generic;
using System.Linq;
namespace DataAccessLib.EmployeeLib
{
    public interface IEmployeeComponent
    {
        void AddNewEmployee(Employee emp);
        void UpdateEmployee(Employee emp);
        void DeleteEmployee(int id);
        List<Employee> GetAllEmployees();
        List<DeptTable> GetAllDepts();
    }

    public class EmployeeComponent : IEmployeeComponent
    {
        private readonly Entities _entities = new Entities();
        public void AddNewEmployee(Employee emp)
        {
            _entities.Employees.Add(emp);
            _entities.SaveChanges();
        }

        public void DeleteEmployee(int id)
        {
            var rec = _entities.Employees.FirstOrDefault((e) => e.Id == id);
            if (rec != null)
            {
                _entities.Employees.Remove(rec);
                _entities.SaveChanges();
            }
            else
                throw new System.Exception("Employee not found to delete");
        }

        public List<DeptTable> GetAllDepts()
        {
            return _entities.DeptTables.ToList();
        }

        public List<Employee> GetAllEmployees()
        {
            return _entities.Employees.ToList();
        }

        public void UpdateEmployee(Employee emp)
        {
            var rec = _entities.Employees.FirstOrDefault((e) => e.Id == emp.Id);
            if (rec != null)
            {
                rec.Address = emp.Address;
                rec.DeptId = emp.DeptId;
                rec.Name = emp.Name;
                rec.Salary = emp.Salary;
                _entities.SaveChanges();
            }
            else
            {
                throw new System.Exception("Employee not found to update");
            }
        }
    }
}