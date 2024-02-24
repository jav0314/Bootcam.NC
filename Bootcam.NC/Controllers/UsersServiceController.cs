using Bootcam.NC.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bootcam.NC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersServiceController : ControllerBase
    {
        // GET: api/<UsersServiceController>
        [HttpGet]
        public List<UsersServiceModel> Get()
        {
            List<UsersServiceModel> ListUser = new List<UsersServiceModel>();

            ListUser.Add(new UsersServiceModel
            {
                Name = "Javier",
                LastName = "Merida",
                Age = 15, 
            });
            ListUser.Add(new UsersServiceModel
            {
                Name = "Javier2",
                LastName = "Merida2",
                Age = 20,
            });
            return ListUser;
        }

        // GET api/<UsersServiceController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
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
