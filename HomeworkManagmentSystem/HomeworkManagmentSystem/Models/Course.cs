using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeworkManagmentSystem.Models
{
    public class Course
    {
        /// <summary>
        /// Local course number
        /// </summary>
        public string CourseCode { get; set; }

        /// <summary>
        /// Local course title
        /// </summary>
        public string CourseTitle { get; set; }

        public List<Student> EnrolledStudents { get; set; }

    }
}