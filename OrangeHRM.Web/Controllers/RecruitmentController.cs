using OrangeHRM.Core.Services;
using OrangeHRM.Entities;
using System.Web.Mvc;

namespace OrangeHRM.Web.Controllers
{
    public class RecruitmentController : Controller
    {
        private readonly IAdminService _adminService;

        public RecruitmentController()
        {
            _adminService = new AdminService();
        }

        public ActionResult Index()
        {
            // Implementation for listing vacancies
            return View();
        }

        public ActionResult Create()
        {
            ViewBag.JobTitles = _adminService.GetActiveJobTitles();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(JobVacancy vacancy)
        {
            if (ModelState.IsValid)
            {
                // Logic to save vacancy
                return RedirectToAction("Index");
            }
            ViewBag.JobTitles = _adminService.GetActiveJobTitles();
            return View(vacancy);
        }
    }
}
