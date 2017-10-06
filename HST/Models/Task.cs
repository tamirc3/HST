using System;

namespace HST.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string AssignedTo{ get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime LastUpdatedTime { get; set; }
        public Status Status { get; set; }
    }
}