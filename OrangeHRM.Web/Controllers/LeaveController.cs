using System.Web.Mvc;
using OrangeHRM.Core.Services;
using OrangeHRM.Entities;

namespace OrangeHRM.Web.Controllers
{
    public class LeaveController : Controller
    {
        private readonly ILeaveService _leaveService;

        public LeaveController()
        {
            _leaveService = new LeaveService();
        }

        public ActionResult Apply()
        {
            ViewBag.LeaveTypes = _leaveService.GetActiveLeaveTypes();
            return View();
        }

        [HttpPost]
        public ActionResult Apply(LeaveRequest request)
        {
            if (ModelState.IsValid)
            {
                _leaveService.SubmitLeaveRequest(request);
                return RedirectToAction("Index", "Employee");
            }
            ViewBag.LeaveTypes = _leaveService.GetActiveLeaveTypes();
            return View(request);
        }
    }
}
