using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coworking.Common.Models.Core;

namespace Coworking.Common.Models.OrderManagement
{
    public class OrderLine : Entity
    {
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int SpaceId { get; set; }
        public int OrdersId { get; set; }





        public OrderLine()
        {
        }
    }
}
