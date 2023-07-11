using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class UserController : ApiController
    {
        List<User> userList = new List<User>();
        public UserController()
        {
            userList.Add(new User { UserId = 1, Name = "Edrian", Address = "Cebu" });
        }

        public IHttpActionResult GetUser(int Id, List<User> userList1)
        {
            User user = userList.Find(u => u.UserId == Id);
            return Ok(user);
        }

    }

    


}

