using Coworking.Common.Models.Users;

namespace Coworking.Business
{
    public interface IUsersService
    {
        public string Create(Users UsersRessources);

        public string Update(Users UsersRessources);

        public bool Delete(int id);

        public Users GetById(int id);

        public List<Users> GetUsers();


    }
}
