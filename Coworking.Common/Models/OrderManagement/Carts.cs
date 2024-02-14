using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coworking.Common.Models.Core;
using Coworking.Common.Models.OrderManagement;

namespace Coworking.Common.Models.CartManagement
{
    public class Carts : CartOrderManagement
    {
        public List<CartLine> CartLines = new List<CartLine>();


       
  
        public Carts()
        {
        }
    }
}
