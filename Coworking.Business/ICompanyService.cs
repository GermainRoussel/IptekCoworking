using Coworking.Common.Models.SpacesManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Business
{
    public interface ICompanyService
    {
        public string CreateCompany(Company CompanyRessources);

        public string UpdateCompany(Company CompanyRessources);

        public bool DeleteCompany(int id);

        public List<Company> GetCompany();


    }
}
