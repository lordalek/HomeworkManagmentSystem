using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeworkManagmentSystem.Models
{
    public abstract class AbstractHomeworkNote
    {
        /// <summary>
        /// Content of the note
        /// </summary>
        public string HomeworkNote { get; set; }

        /// <summary>
        /// When the homework is due
        /// </summary>
        public DateTime DueDate { get; set; }

        /// <summary>
        /// When the homework was publised
        /// </summary>
        public DateTime PublisedDate { get; set; }

        /// <summary>
        /// If email reminder is activated
        /// </summary>
        public bool isReminderActive { get; set; }
    }
}
