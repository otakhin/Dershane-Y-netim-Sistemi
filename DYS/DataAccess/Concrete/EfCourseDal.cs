using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DYS.DataAccess.Abstract;
using DYS.Entities.Abstract;
using DYS.Entities.Concrete;
using static DYS.DataAccess.Concrete.EfCourseDal;

namespace DYS.DataAccess.Concrete
{
    public class EfCourseDal:DbOperations<Course>
    {

       
        
           public List<Teacher> GetTeachers()
        {
            List<Teacher> teachers = new List<Teacher>();
            using (DYS_NewContext context = new DYS_NewContext())
            {
                teachers = context.Teacher.ToList();
            }
            return teachers;

        }
       




    }
}
