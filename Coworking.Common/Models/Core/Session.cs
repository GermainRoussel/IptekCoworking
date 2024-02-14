using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Common.Models.Core
{
    public class Session
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UsersId { get; set; }
        public int Type { get; set; } // 1 = Users, 2 = Employee

        
        public Session()
        {
        }
    }
}
