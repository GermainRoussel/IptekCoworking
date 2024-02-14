using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coworking.Common.Models.Core;

namespace Coworking.Common.Models.Users
{
    public class UsersRoles : Entity
    {
        public int UsersId { get; set; }
        public int RolesId { get; set; }

        public UsersRoles()
        {
        }

    }
}
