using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TaskManagement.Models
{
    public class TaskContext : DbContext
    {
        public TaskContext() : base ("name=TaskManagementDB")
        {

        }

        public DbSet<Task> Tasks { get; set; }
    }
}