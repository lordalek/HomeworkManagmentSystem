using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeworkManagmentSystem.Models
{
    public class Teacher : AbstractUser
    {
        public List<Course> Courses { get; set; }
    }
}