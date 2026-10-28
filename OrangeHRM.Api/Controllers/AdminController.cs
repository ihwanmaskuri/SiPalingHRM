using OrangeHRM.Core.Services;
using System.Web.Http;

namespace OrangeHRM.Api.Controllers
{
    [RoutePrefix("api/admin")]
    public class AdminController : ApiController
    {
        private readonly IAdminService _adminService;

        public AdminController()
        {
            _adminService = new AdminService();
        }

        [HttpGet]
        [Route("jobtitles")]
        public IHttpActionResult GetJobTitles()
        {
            return Ok(_adminService.GetActiveJobTitles());
        }

        [HttpGet]
        [Route("subunits")]
        public IHttpActionResult GetSubunits()
        {
            return Ok(_adminService.GetAllSubunits());
        }
    }
}
