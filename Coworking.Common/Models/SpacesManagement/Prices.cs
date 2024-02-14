using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coworking.Common.Models.Core;

namespace Coworking.Common.Models.SpacesManagement
{
    public class Prices : Entity
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public int SpaceId { get; set; } // A vérifier
        public string Currency { get; set; }

        public Prices()
        {
        }
    }
}
