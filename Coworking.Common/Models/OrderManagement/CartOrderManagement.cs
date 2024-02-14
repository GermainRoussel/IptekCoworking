using Coworking.Common.Models.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Common.Models.OrderManagement
{
    public class CartOrderManagement : Entity
    {
        public float TotalPrice { get; set; } // total price without tva

        public float TvaFee { get; set; }

        public float TotalPriceWithTva { get; set; } // total price with tva
        public float Discount { get; set; }

        public float TotalPriceWithTvaAndDiscount { get; set; } // total price with tva and reduction

        public int UsersId { get; set; }

    }
}
