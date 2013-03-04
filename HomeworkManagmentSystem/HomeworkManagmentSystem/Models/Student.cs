using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeworkManagmentSystem.Models
{
    public class Student : AbstractUser
    {
        public List<Course> CoursesEnrolledIn { get; set; }
    }
}