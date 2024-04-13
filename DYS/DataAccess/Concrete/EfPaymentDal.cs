using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DYS.DataAccess.Abstract;
using DYS.Entities.Concrete;

namespace DYS.DataAccess.Concrete
{
    public class EfPaymentDal : DbOperations<Payment>
    {

     public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            using (DYS_NewContext context = new DYS_NewContext())
            {
                students = context.Student.ToList();


            }
            return students;
        }

        

      
    }
}
