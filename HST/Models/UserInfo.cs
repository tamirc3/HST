using System.Collections.Generic;

namespace HST.Models
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public UserType UserType { get; set; }
        public string Password { get; set; }
        public List<Task> ListOfTasks { get; set; }
    }
}