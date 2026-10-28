using OrangeHRM.Data;
using OrangeHRM.Entities;
using System.Collections.Generic;
using System.Linq;

namespace OrangeHRM.Core.Services
{
    public class PerformanceService : IPerformanceService
    {
        private readonly OrangeHRMContext _context;

        public PerformanceService()
        {
            _context = new OrangeHRMContext();
        }

        public IEnumerable<Kpi> GetKpisByJobTitle(int jobTitleId)
        {
            return _context.Kpis.Where(k => k.JobTitleId == jobTitleId && !k.IsDeleted).ToList();
        }

        public void CreatePerformanceReview(PerformanceReview review)
        {
            _context.PerformanceReviews.Add(review);
            _context.SaveChanges();
        }
    }
}
