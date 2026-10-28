using System.Web.Mvc;
using OrangeHRM.Core.Services;

namespace OrangeHRM.Web.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminService _adminService;

        public AdminController()
        {
            _adminService = new AdminService();
        }

        public ActionResult Index()
        {
            ViewBag.JobTitles = _adminService.GetActiveJobTitles();
            ViewBag.Subunits = _adminService.GetAllSubunits();
            ViewBag.Locations = _adminService.GetAllLocations();
            return View();
        }
    }
}
