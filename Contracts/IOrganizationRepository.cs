using System;
using System.Collections.Generic;
using Entities.Models;
namespace Contracts
{
    public interface IOrganizationRepository
    {
        IEnumerable<Organization> GetAllOrganizations(bool trackChanges);
        Organization GetOrganization(Guid companyId, bool trackChanges);
    }
}