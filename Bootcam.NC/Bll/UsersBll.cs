using System.Xml.Linq;
using Bootcam.NC.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bootcam.NC.Bll
{
    public class UsersBll
    {
        List<UsersServiceModel> ListUser = new List<UsersServiceModel>
        {
                new UsersServiceModel
            {
                Id = 1,
                Name = "Javier",
                LastName = "Merida",
                Age = 15,
            },
                new UsersServiceModel
            {
                Id = 2,
                Name = "Javier2",
                LastName = "Merida2",
                Age = 20,
            },
                new UsersServiceModel
            {
                Id = 3,
                Name = "Jose",
                LastName = "Julio",
                Age = 40,
            }
        };
        
        public List<UsersServiceModel> GetUsers()
        {
            return ListUser;
        }
        public UsersServiceModel GetUser(int Id)
        {
           return ListUser.Where(x => x.Id == Id).First();
        }

    }

    
}
