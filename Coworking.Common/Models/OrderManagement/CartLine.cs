using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coworking.Common.Models.Core;
using Coworking.Common.Models.OrderManagement;

namespace Coworking.Common.Models.CartManagement
{
    public class CartLine : Entity
    {
        public int Quantity { get; set; }
        public float Price { get; set; }
        public int SpaceId { get; set; }
        public int CartsId { get; set; }







        public CartLine()
        {
        }
    }
}
