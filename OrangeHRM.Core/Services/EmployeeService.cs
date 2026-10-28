using System.Collections.Generic;
using System.Linq;
using OrangeHRM.Core.Services;
using OrangeHRM.Data;
using OrangeHRM.Entities;

namespace OrangeHRM.Core.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly OrangeHRMContext _context;

        public EmployeeService()
        {
            _context = new OrangeHRMContext();
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }

        public Employee GetEmployeeById(int id)
        {
            return _context.Employees.Find(id);
        }

        public void CreateEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public void UpdateEmployee(Employee employee)
        {
            var existing = _context.Employees.Find(employee.EmployeeNumber);
            if (existing != null)
            {
                _context.Entry(existing).CurrentValues.SetValues(employee);
                _context.SaveChanges();
            }
        }

        public void DeleteEmployee(int id)
        {
            var employee = _context.Employees.Find(id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                _context.SaveChanges();
            }
        }
    }
}
