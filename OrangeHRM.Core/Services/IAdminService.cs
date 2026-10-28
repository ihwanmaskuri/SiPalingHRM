using System.Collections.Generic;
using OrangeHRM.Entities;

namespace OrangeHRM.Core.Services
{
    public interface IAdminService
    {
        IEnumerable<JobTitle> GetActiveJobTitles();
        IEnumerable<Subunit> GetAllSubunits();
        IEnumerable<Location> GetAllLocations();
    }
}
