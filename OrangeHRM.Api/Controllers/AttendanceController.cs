using OrangeHRM.Core.Services;
using System.Web.Http;

namespace OrangeHRM.Api.Controllers
{
    [RoutePrefix("api/attendance")]
    public class AttendanceController : ApiController
    {
        private readonly IAttendanceService _attendanceService;

        public AttendanceController()
        {
            _attendanceService = new AttendanceService();
        }

        [HttpPost]
        [Route("punchin")]
        public IHttpActionResult PunchIn(int empNumber, string note)
        {
            _attendanceService.PunchIn(empNumber, note);
            return Ok();
        }

        [HttpPost]
        [Route("punchout")]
        public IHttpActionResult PunchOut(int empNumber, string note)
        {
            _attendanceService.PunchOut(empNumber, note);
            return Ok();
        }
    }
}
