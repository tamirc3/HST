using System;
using System.Collections.Generic;

namespace HST.Models
{
    public class DbManager
    {
 
        private readonly List<UserInfo> mockUserTable = new List<UserInfo>();
        private readonly List<Task> mockTasksTable = new List<Task>();

        public DbManager()
        {
            FillUsersTable();
            FillTasksTable();
        }

        private void FillTasksTable()
        {

            var t = new Task()
            {
                AssignedTo = "u",
                CreatedTime = DateTime.Now,
                Description = "todo bum",
                Id = 1,
                LastUpdatedTime = DateTime.Now,
                Status = Status.New

            };
            mockTasksTable.Add(t);
        }

        private void FillUsersTable()
        {
            var user = new UserInfo()
            {
                Id = 0,
                UserName = "a",
                UserType = UserType.Administrator,
                Password = "1234"
            };
            var a = new UserInfo()
            {
                Id = 0,
                UserName = "u",
                UserType = UserType.Agent,
                Password = "1234"
            };
            var m = new UserInfo()
            {
                Id = 0,
                UserName = "m",
                UserType = UserType.Manager,
                Password = "1234"
            };
            mockUserTable.Add(user);
            mockUserTable.Add(a);
            mockUserTable.Add(m);
        }

        private static readonly UserInfo NotExistingUserInfo = new UserInfo()
        {
            UserType = UserType.NotExist
        };
        public UserInfo Login(string userName, string password)
        {
            var userInfo = mockUserTable.Find(x => x.UserName == userName);
            if (userInfo == null || userInfo.Password != password)
            {
               return NotExistingUserInfo;
            }
            return userInfo;
        }

        public List<Task> GetAllTasksForUser(string userName)
        {
           return mockTasksTable.FindAll(x => x.AssignedTo == userName);
        }

        public void AddTask(string assignedTo,string description,Status status)
        {
            var nowTime = DateTime.Now;
            mockTasksTable.Add(new Task()
            {
                Id = mockTasksTable.Count + 1,
               LastUpdatedTime = nowTime,
               CreatedTime = nowTime
               ,AssignedTo = assignedTo,
               Description =  description,
               Status =  status
            });
        }



        public void AddUser(string userName, string password, UserType userType)
        {
            mockUserTable.Add(new UserInfo()
            {
                UserType = userType,
                Password = password,
                 UserName = userName,
                 Id = mockUserTable.Count +1
            });
        }
    }
}