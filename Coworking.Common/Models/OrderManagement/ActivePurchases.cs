using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coworking.Common.Models.Core;

namespace Coworking.Common.Models.OrderManagement
{
    public class ActivePurchases : Entity
    {
        public DateTime ExpirationDate { get; set; }
        public DateTime StartDate { get; set; }
        public int UsersId { get; set; }
        public int SpaceId { get; set; }
        public int OrdersId { get; set; }



    }
}
