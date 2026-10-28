using System.Collections.Generic;
using OrangeHRM.Entities;

namespace OrangeHRM.Core.Services
{
    public interface IPerformanceService
    {
        IEnumerable<Kpi> GetKpisByJobTitle(int jobTitleId);
        void CreatePerformanceReview(PerformanceReview review);
    }
}
