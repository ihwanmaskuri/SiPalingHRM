using System.Collections.Generic;
using System.Linq;
using OrangeHRM.Data;
using OrangeHRM.Entities;

namespace OrangeHRM.Core.Services
{
    public class AdminService : IAdminService
    {
        private readonly OrangeHRMContext _context;

        public AdminService()
        {
            _context = new OrangeHRMContext();
        }

        public IEnumerable<JobTitle> GetActiveJobTitles()
        {
            return _context.JobTitles.Where(j => !j.IsDeleted).ToList();
        }

        public IEnumerable<Subunit> GetAllSubunits()
        {
            return _context.Subunits.ToList();
        }

        public IEnumerable<Location> GetAllLocations()
        {
            return _context.Locations.ToList();
        }
    }
}
