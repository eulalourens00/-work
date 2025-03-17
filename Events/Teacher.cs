using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Events.Student;

namespace Events
{
    internal class Teacher
    {
        //public event ExamDelegate examEvent;
        //EventHandler<T>
        //public ExamDelegate examEvent;

        public EventHandler<ExamEventArgs> examEvent;

        public void Exam(ExamEventArgs task)
        {
            if (examEvent != null)
            {
                examEvent(this, task);
            }
        }

        //public void Exam(string task)
        //{
        //    if (examEvent != null)
        //    {
        //        examEvent(task);
        //    }
        //}

        SortedList<int, ExamDelegate> _sortedList = new SortedList<int, ExamDelegate>();



        
    }
}
