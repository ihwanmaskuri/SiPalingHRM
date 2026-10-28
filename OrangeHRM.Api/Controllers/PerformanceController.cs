using System.Web.Http;
using OrangeHRM.Core.Services;
using OrangeHRM.Entities;

namespace OrangeHRM.Api.Controllers
{
    [RoutePrefix("api/performance")]
    public class PerformanceController : ApiController
    {
        private readonly IPerformanceService _performanceService;

        public PerformanceController()
        {
            _performanceService = new PerformanceService();
        }

        [HttpGet]
        [Route("kpis/{jobTitleId}")]
        public IHttpActionResult GetKpis(int jobTitleId)
        {
            return Ok(_performanceService.GetKpisByJobTitle(jobTitleId));
        }

        [HttpPost]
        [Route("reviews")]
        public IHttpActionResult CreateReview(PerformanceReview review)
        {
            _performanceService.CreatePerformanceReview(review);
            return Ok(review);
        }
    }
}
