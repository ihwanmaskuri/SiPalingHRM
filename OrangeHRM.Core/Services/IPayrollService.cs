using OrangeHRM.Entities;
using System.Collections.Generic;

namespace OrangeHRM.Core.Services
{
    public interface IPayrollService
    {
        IEnumerable<EmpBasicSalary> GetEmployeeSalaries(int empNumber);
        void SaveBasicSalary(EmpBasicSalary salary);
        IEnumerable<PayPeriod> GetPayPeriods();
        IEnumerable<CurrencyType> GetCurrencies();
        EmpBasicSalary GetSalaryById(int id);
        void DeleteSalary(int id);
    }
}
