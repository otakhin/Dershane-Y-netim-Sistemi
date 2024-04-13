using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DYS.Entities.Abstract;

namespace DYS.Entities.Concrete
{
    public class Course
    {
       public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseTeacher { get; set; }
    }
}
