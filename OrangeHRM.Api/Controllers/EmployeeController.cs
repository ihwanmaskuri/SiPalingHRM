using System.Collections.Generic;
using System.Web.Http;
using OrangeHRM.Core.Services;
using OrangeHRM.Entities;

namespace OrangeHRM.Api.Controllers
{
    [RoutePrefix("api/employees")]
    public class EmployeeController : ApiController
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController()
        {
            // Note: In a real project, use Dependency Injection
            _employeeService = new EmployeeService();
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<Employee> Get()
        {
            return _employeeService.GetAllEmployees();
        }

        [HttpGet]
        [Route("{id:int}")]
        public IHttpActionResult Get(int id)
        {
            var employee = _employeeService.GetEmployeeById(id);
            if (employee == null) return NotFound();
            return Ok(employee);
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult Post([FromBody] Employee employee)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            _employeeService.CreateEmployee(employee);
            return Ok(employee);
        }
    }
}
