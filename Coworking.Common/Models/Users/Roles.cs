using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coworking.Common.Models.Core;

namespace Coworking.Common.Models.Users
{
    public class Roles : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        
        public Roles()
        {
        }
    }
}
