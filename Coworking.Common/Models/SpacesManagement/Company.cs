using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coworking.Common.Models.Core;

namespace Coworking.Common.Models.SpacesManagement
{
    public class Company : Entity
    {
        public string Siret { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int TvaNumber { get; set; }

        public int StreetNumber { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }

        public string DetailAdress { get; set; } // ex appartement 2, étage 3, etc
        public int StreetNumberFacturation { get; set; }
        public string StreetFacturation { get; set; }
        public string CityFacturation { get; set; }
        public int PostalCodeFacturation { get; set; }
        public string CountryFacturation { get; set; }

        public string DetailAdressFacturation { get; set; } // ex appartement 2, étage 3, etc







        public Company()
        {
                

        }
    }
}
