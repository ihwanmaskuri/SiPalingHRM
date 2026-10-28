using OrangeHRM.Core.Services;
using OrangeHRM.Entities;
using System.Web.Mvc;

namespace OrangeHRM.Web.Controllers
{
    public class PayrollController : Controller
    {
        private readonly IPayrollService _payrollService;
        private readonly IEmployeeService _employeeService;

        public PayrollController()
        {
            _payrollService = new PayrollService();
            _employeeService = new EmployeeService();
        }

        // GET: Payroll
        public ActionResult Index()
        {
            var employees = _employeeService.GetAllEmployees();
            return View(employees);
        }

        // GET: Payroll/EmployeeSalary/1
        public ActionResult EmployeeSalary(int id)
        {
            var employee = _employeeService.GetEmployeeById(id);
            if (employee == null) return HttpNotFound();

            ViewBag.Employee = employee;
            ViewBag.PayPeriods = _payrollService.GetPayPeriods();
            ViewBag.Currencies = _payrollService.GetCurrencies();

            var salaries = _payrollService.GetEmployeeSalaries(id);
            return View(salaries);
        }

        // POST: Payroll/AddSalary
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddSalary(EmpBasicSalary salary)
        {
            if (ModelState.IsValid)
            {
                _payrollService.SaveBasicSalary(salary);
                return RedirectToAction("EmployeeSalary", new { id = salary.EmployeeNumber });
            }

            return RedirectToAction("EmployeeSalary", new { id = salary.EmployeeNumber });
        }
    }
}
