using System.Web.Mvc;
using HST.Models;

namespace HST.Controllers
{
    public class UserAdminController : Controller
    {
        // GET: UserAdmin
        public void AddUser(AddUserRequest addUserRequest)
        {
          AppManager.DbManager.AddUser(addUserRequest.UserName,addUserRequest.Password,addUserRequest.UserType);
        }

        public class AddUserRequest
        {
            public string UserName { get; set; }
            public string Password { get; set; }
            public UserType UserType { get; set; }
        }
    }
}