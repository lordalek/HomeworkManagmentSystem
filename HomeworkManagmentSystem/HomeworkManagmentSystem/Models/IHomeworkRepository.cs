using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkManagmentSystem.Models
{
    public interface IHomeworkRepository
    {
        void CreateNewHomeWorkNote(AbstractHomeworkNote homeworkNoteToCreate);
    }
}
