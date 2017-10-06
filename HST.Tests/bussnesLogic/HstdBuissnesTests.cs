using System.Security.Cryptography;
using HST.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HST.Tests.bussnesLogic
{
    [TestClass]
    public class HstdBuissnesTests
    {

        [TestMethod]
        public void LoginTest_validLogin()
        {
            DbManager dbManager = new DbManager();

            string userName = "agentFoo";
            string password = "1234";
            var userInfo = dbManager.Login(userName, password);
            Assert.IsTrue(userInfo.UserType.Equals(UserType.Agent));
        }
        [TestMethod]
        public void LoginTest_InValidLogin()
        {

            DbManager dbManager = new DbManager();
            string userName = "agentFoo";
            string password = "not valid";
            var userInfo = dbManager.Login(userName, password);
            Assert.IsTrue(userInfo.UserType.Equals(UserType.NotExist));
        }
        [TestMethod]
        public void AddAndGetAllTasksForUser()
        {
            DbManager dbManager = new DbManager();
            string userName = "bob";
            var descprtion = "todo";
            dbManager.AddTask(userName, descprtion, Status.New);
            var listOfTasks = dbManager.GetAllTasksForUser(userName);
            Assert.IsTrue(listOfTasks.Count == 1);
            Assert.IsTrue(listOfTasks[0].AssignedTo == userName);
            Assert.IsTrue(listOfTasks[0].Description == descprtion);
        }

        [TestMethod]
        public void AddUserAndLogin()
        {
            DbManager dbManager = new DbManager();
            var userName = "username";
            var Password = "12345";
            var userInfro = new UserInfo()
            {
                UserName = userName,
                UserType = UserType.Agent,
                Id = 0,
                Password = Password
            };

            dbManager.AddUser(userName,Password, UserType.Agent);
            var userInfo = dbManager.Login(userName, Password);
            Assert.IsTrue(userInfo.UserType == UserType.Agent);
        }


    }
}