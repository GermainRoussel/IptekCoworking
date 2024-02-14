using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coworking.Common.Models.Core;

namespace Coworking.Common.Models.SpacesManagement
{
    public class Medias : Entity
    {
        public string LocalUrl { get; set; }

        public string Description { get; set; } 
        public int Order { get; set; }
        public int SpaceId { get; set; }

        public Medias()
        {
        }
    }
}
