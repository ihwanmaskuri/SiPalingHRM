using System.Web.Mvc;
using OrangeHRM.Core.Services;

namespace OrangeHRM.Web.Controllers
{
    public class AttendanceController : Controller
    {
        private readonly IAttendanceService _attendanceService;

        public AttendanceController()
        {
            _attendanceService = new AttendanceService();
        }

        public ActionResult PunchIn()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PunchIn(int empNumber, string note)
        {
            _attendanceService.PunchIn(empNumber, note);
            return RedirectToAction("Index", "Home");
        }

        public ActionResult PunchOut()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PunchOut(int empNumber, string note)
        {
            _attendanceService.PunchOut(empNumber, note);
            return RedirectToAction("Index", "Home");
        }
    }
}
