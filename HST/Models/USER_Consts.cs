using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HST.Models
{
    public static class UserConsts
    {
        public static readonly string USER_NAME = "userName";
        public static readonly string PASSWORD = "passWord";
        public static readonly string ROBOT_CB = "notRobotCb";
        public static readonly string User_Role = "notRobotCb";
    }
    public class TaskConsts
    {
        public static readonly string AssignedTo = "userName";
        public static readonly string Description = "passWord";
        public static readonly string Staus = "notRobotCb";
    }

    public class CookieConsts
    {
        public static readonly string UserInfo = "userInfo";
    }
}