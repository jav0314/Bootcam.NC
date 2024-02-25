using Bootcam.NC.Bll;
using Bootcam.NC.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bootcam.NC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersServiceController : ControllerBase
    {
        UsersBll UsersBll = new UsersBll();
        // GET: api/<UsersServiceController>
        [HttpGet]
        public List<UsersServiceModel> Get()
        {
            List<UsersServiceModel> ListUser = UsersBll.GetUsers();
            return ListUser;
        }

        // GET api/<UsersServiceController>/5
        [HttpGet("{id}")]
        public UsersServiceModel Get(int id)
        {
            return UsersBll.GetUser(id);
        }

        // POST api/<UsersServiceController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UsersServiceController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsersServiceController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
