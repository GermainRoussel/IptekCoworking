using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coworking.Business;
using Coworking.Common.Models.Users;
using Microsoft.AspNetCore.Mvc;

namespace Coworking.ApiBackOffice.Controllers
{

    [ApiController]
    [Route("api/Controllers/UsersController")]

    public class UsersController : Controller
    {
        private readonly IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }



        [HttpPost("{UsersRessources}")]
        public IActionResult CreateUser([FromBody] Users UsersRessources)
        {
            var result = _usersService.Create(UsersRessources) + "A été créé. ";

            return Ok(result);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, [FromBody] Users UsersRessources)
        {
            var result = _usersService.Update(UsersRessources) + "A été mis à jour.";
            var result2 = result + "A été modifié. ";

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUsers(int id)
        {
            var result = _usersService.Delete(id);

            if (result)
            {
                return Ok("A été supprimé. ");
            }
            return NotFound("N'a pas été supprimé. ");
            
            
        }

        [HttpGet("{GetUsers}")]
        public IActionResult GetUsers()
        {
            var users = _usersService.GetUsers();

            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var user = _usersService.GetById(id);
            if (user == null)
            {
                return NotFound("N'a pas été trouvé. ");
            }
            return Ok(user);
        }


    }
}
