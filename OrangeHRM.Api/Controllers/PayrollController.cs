using OrangeHRM.Core.Services;
using OrangeHRM.Entities;
using System.Web.Http;

namespace OrangeHRM.Api.Controllers
{
    [RoutePrefix("api/payroll")]
    public class PayrollController : ApiController
    {
        private readonly IPayrollService _payrollService;

        public PayrollController()
        {
            _payrollService = new PayrollService();
        }

        [HttpGet]
        [Route("employee/{empNumber:int}")]
        public IHttpActionResult GetEmployeeSalaries(int empNumber)
        {
            return Ok(_payrollService.GetEmployeeSalaries(empNumber));
        }

        [HttpPost]
        [Route("salary")]
        public IHttpActionResult SaveSalary([FromBody] EmpBasicSalary salary)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            _payrollService.SaveBasicSalary(salary);
            return Ok(salary);
        }

        [HttpDelete]
        [Route("salary/{id:int}")]
        public IHttpActionResult DeleteSalary(int id)
        {
            _payrollService.DeleteSalary(id);
            return Ok();
        }
    }
}
