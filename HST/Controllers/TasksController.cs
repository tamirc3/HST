using System.Data;
using System.Web.Mvc;
using HST.Models;

namespace HST.Controllers
{
    public class TasksController : Controller
    {
        // GET: Tasks
        public JsonResult TasksForUser()
        {
            var cookie = Request.Cookies.Get(CookieConsts.UserInfo);
            if (cookie == null)
            {
              throw new DataException("cookie is null");
            }
            var userName = cookie.Value;
            return Json(AppManager.DbManager.GetAllTasksForUser(userName));
         //   return JsonConvert.SerializeObject(AppManager.DbManager.GetAllTasksForUser(userName));
        }

        public void AddTaskForUser(AddTaskRequest addTaskRequest)
        {
            AppManager.DbManager.AddTask(addTaskRequest.AssignedTo,addTaskRequest.Description,addTaskRequest.Status);
        }
    }

    public class AddTaskRequest
    {
        public string Description { get; set; }
        public string AssignedTo { get; set; }
        public Status Status{ get; set; }
    }
}