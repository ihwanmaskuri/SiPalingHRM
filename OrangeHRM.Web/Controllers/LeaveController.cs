using OrangeHRM.Core.Services;
using OrangeHRM.Entities;
using System.Web.Mvc;

namespace OrangeHRM.Web.Controllers
{
    public class LeaveController : Controller
    {
        private readonly ILeaveService _leaveService;

        public LeaveController()
        {
            _leaveService = new LeaveService();
        }

        public ActionResult Index(int empNumber = 1)
        {
            var requests = _leaveService.GetEmployeeLeaveRequests(empNumber);
            return View(requests);
        }

        public ActionResult Apply()
        {
            ViewBag.LeaveTypes = _leaveService.GetActiveLeaveTypes();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Apply(LeaveRequest request)
        {
            if (ModelState.IsValid)
            {
                _leaveService.SubmitLeaveRequest(request);
                return RedirectToAction("Index");
            }
            ViewBag.LeaveTypes = _leaveService.GetActiveLeaveTypes();
            return View(request);
        }

        public ActionResult Cancel(int id)
        {
            _leaveService.CancelLeaveRequest(id);
            return RedirectToAction("Index");
        }
    }
}
