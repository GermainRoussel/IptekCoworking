using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coworking.Common.Models.Core;

namespace Coworking.Common.Models.Users
{
    public class Users : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public List<UsersRoles> UsersRoles { get; set; }
        public Users()
        {
            UsersRoles = new List<UsersRoles>();
        }

    }
}
