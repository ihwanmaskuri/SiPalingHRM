using OrangeHRM.Core.Services;
using OrangeHRM.Entities;
using System.Web.Http;

namespace OrangeHRM.Api.Controllers
{
    [RoutePrefix("api/leave")]
    public class LeaveController : ApiController
    {
        private readonly ILeaveService _leaveService;

        public LeaveController()
        {
            _leaveService = new LeaveService();
        }

        [HttpGet]
        [Route("types")]
        public IHttpActionResult GetLeaveTypes()
        {
            return Ok(_leaveService.GetActiveLeaveTypes());
        }

        [HttpPost]
        [Route("request")]
        public IHttpActionResult SubmitLeaveRequest(LeaveRequest request)
        {
            _leaveService.SubmitLeaveRequest(request);
            return Ok(request);
        }
    }
}
