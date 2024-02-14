using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coworking.Common.Models.SpacesManagement;
using Coworking.Common.Ressources.Core;
using Coworking.Common.Ressources.SpacesManagement;
using Coworking.Common.Ressources.Users;



namespace Coworking.Business
{
    public interface ISpaceService
    {
        public string AddSpace(Space SpaceRessources);
            public string UpdateSpace(Space SpaceRessources);
            public bool DeleteSpace(int id);
            public Space GetSpaceId(int id);
    
            public List<Space> GetSpaces();
    }
}
