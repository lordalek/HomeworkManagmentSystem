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
    }
}