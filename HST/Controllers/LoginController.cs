using System;
using System.Data;
using System.Web;
using System.Web.Mvc;
using HST.Models;

namespace HST.Controllers
{
    public class LoginController : Controller
    {


        public JsonResult Login(LoginRequest loginRequest)
        {
            //return RedirectToAction("yourAnotherActionName","yourAnotherControllerName");

            try
            {
                if (loginRequest.Robot)
                {
                    return Json(new { result = "Redirect", url = Url.Action("Robot", "Home") });
                }

                var userInfo = AppManager.DbManager.Login(loginRequest.UserName, loginRequest.Password);

                if (userInfo.UserType.Equals(UserType.NotExist))
                {
                    return Json(new { result = "Redirect", url = Url.Action("Index", "Home") });
                }


                HttpCookie userInfoCookie = new HttpCookie(CookieConsts.UserInfo)
                {
                    Value = userInfo.UserName,
                    Path = "/"
                };
                Response.Cookies.Add(userInfoCookie);


                if (userInfo.UserType.Equals(UserType.User))
                {
                    return Json(new { result = "Redirect", url = Url.Action("UserPage", "Home") });
                }
                if (userInfo.UserType.Equals(UserType.Manager))
                {
                    return Json(new { result = "Redirect", url = Url.Action("Manager", "Home") });
                }

                if (userInfo.UserType.Equals(UserType.Administrator))
                {
                    return Json(new { result = "Redirect", url = Url.Action("Administrator", "Home") });
                }

                throw new DataException($"user type {userInfo.UserType} is not valid");

            }
            catch (Exception)
            {
                return Json(new { result = "Redirect", url = Url.Action("Error", "Home") });
                //return RedirectToAction("Error", "Home");
            }
        }
    }
}