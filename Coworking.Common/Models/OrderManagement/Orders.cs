using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coworking.Common.Models.Core;

namespace Coworking.Common.Models.OrderManagement
{
    public class Orders : CartOrderManagement
    {
        public List<OrderLine> OrderLines = new List<OrderLine>();


        public Orders()
        {

        }

    }
}
