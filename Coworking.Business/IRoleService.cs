using Coworking.Common.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Business
{
    public interface IRoleService
    {

        public string AddRole(UsersRoles UsersRolesRessources);
        public string UpdateRole(UsersRoles UsersRolesRessources);
        public bool DeleteRole(int id);

        public List<UsersRoles> GetRole();


    }
}
