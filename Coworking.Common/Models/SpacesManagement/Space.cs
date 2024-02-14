using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coworking.Common.Models.Core;
using Microsoft.VisualBasic;

namespace Coworking.Common.Models.SpacesManagement
{
    public class Space : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public int NbSeatsAvailable { get; set; } // Nb de places disponibles

        public int NbSeatsTotal { get; set; } // Nb de places totales

        public string Type { get; set; }
        public int StreetNumber { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }

        public string DetailAdress { get; set; } // ex appartement 2, étage 3, etc
        public int CompanyId { get; set; }

        public DateTime DisponibilityOn { get; set; }  // Date a laquelle le space est disponible
        public DateTime DisponibilityOff { get; set; } // Date a laquelle le space n'est plus disponible

        public int Climatisation { get; set; } // 0 = pas de climatisation, 1 = climatisation
        public int Wifi { get; set; } // 0 = pas de wifi, 1 = wifi
        public int CoffeeMachine { get; set; } // 0 = pas de machine a café, 1 = machine a café
        public int VisioConference { get; set; } // 0 = pas de visio conference, 1 = visio conference

        public int IsERP { get; set; } // 0 = pas d'ERP, 1 = ERP
        public int PeriodicVerification { get; set; } // 0 = pas de vérification périodique, 1 = vérification périodique  --> ok sécurité ? oui non





        public Space()
        {
        }

    }
}


