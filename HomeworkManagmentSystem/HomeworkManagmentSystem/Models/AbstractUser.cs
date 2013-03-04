using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeworkManagmentSystem.Models
{
    public abstract class AbstractUser
    {
        /// <summary>
        /// An user's ID
        /// </summary>
        public long UserID { get; set; }

        /// <summary>
        /// An user's first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// An user's last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// An user's gender.
        /// </summary>
        public string Gender { get; set; }
    }
}