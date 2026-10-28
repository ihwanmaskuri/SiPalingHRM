using OrangeHRM.Core.Services;
using OrangeHRM.Entities;
using System.Linq;
using System.Web.Mvc;

namespace OrangeHRM.Web.Controllers
{
    public class PerformanceController : Controller
    {
        private readonly IPerformanceService _performanceService;
        private readonly IEmployeeService _employeeService;

        public PerformanceController()
        {
            _performanceService = new PerformanceService();
            _employeeService = new EmployeeService();
        }

        public ActionResult Index()
        {
            // Implementation for listing reviews
            return View();
        }

        public ActionResult Create()
        {
            ViewBag.EmployeeNumber = new SelectList(_employeeService.GetAllEmployees(), "EmployeeNumber", "FirstName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PerformanceReview review)
        {
            if (ModelState.IsValid)
            {
                _performanceService.CreatePerformanceReview(review);
                return RedirectToAction("Index");
            }
            ViewBag.EmployeeNumber = new SelectList(_employeeService.GetAllEmployees(), "EmployeeNumber", "FirstName", review.EmployeeNumber);
            return View(review);
        }
    }
}
