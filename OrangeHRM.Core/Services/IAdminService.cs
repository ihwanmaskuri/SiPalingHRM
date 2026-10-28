using OrangeHRM.Entities;
using System.Collections.Generic;

namespace OrangeHRM.Core.Services
{
    public interface IAdminService
    {
        IEnumerable<JobTitle> GetActiveJobTitles();
        IEnumerable<Subunit> GetAllSubunits();
        IEnumerable<Location> GetAllLocations();
    }
}
