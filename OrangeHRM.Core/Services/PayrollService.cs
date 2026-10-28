using System.Collections.Generic;
using System.Linq;
using OrangeHRM.Data;
using OrangeHRM.Entities;

namespace OrangeHRM.Core.Services
{
    public class PayrollService : IPayrollService
    {
        private readonly OrangeHRMContext _context;

        public PayrollService()
        {
            _context = new OrangeHRMContext();
        }

        public IEnumerable<EmpBasicSalary> GetEmployeeSalaries(int empNumber)
        {
            return _context.EmpBasicSalaries
                .Where(s => s.EmployeeNumber == empNumber)
                .ToList();
        }

        public void SaveBasicSalary(EmpBasicSalary salary)
        {
            if (salary.Id == 0)
                _context.EmpBasicSalaries.Add(salary);
            else
            {
                var existing = _context.EmpBasicSalaries.Find(salary.Id);
                if (existing != null)
                    _context.Entry(existing).CurrentValues.SetValues(salary);
            }
            _context.SaveChanges();
        }

        public IEnumerable<PayPeriod> GetPayPeriods()
        {
            return _context.PayPeriods.ToList();
        }

        public IEnumerable<CurrencyType> GetCurrencies()
        {
            return _context.CurrencyTypes.ToList();
        }

        public EmpBasicSalary GetSalaryById(int id)
        {
            return _context.EmpBasicSalaries.Find(id);
        }

        public void DeleteSalary(int id)
        {
            var salary = _context.EmpBasicSalaries.Find(id);
            if (salary != null)
            {
                _context.EmpBasicSalaries.Remove(salary);
                _context.SaveChanges();
            }
        }
    }
}
