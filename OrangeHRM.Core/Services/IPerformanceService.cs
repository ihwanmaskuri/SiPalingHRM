using OrangeHRM.Entities;
using System.Collections.Generic;

namespace OrangeHRM.Core.Services
{
    public interface IPerformanceService
    {
        IEnumerable<Kpi> GetKpisByJobTitle(int jobTitleId);
        void CreatePerformanceReview(PerformanceReview review);
    }
}
