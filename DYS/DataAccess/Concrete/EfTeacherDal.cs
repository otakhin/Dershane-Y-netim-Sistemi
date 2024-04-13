using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DYS.DataAccess.Abstract;
using DYS.Entities.Concrete;

namespace DYS.DataAccess.Concrete
{
    public class EfTeacherDal:DbOperations<Teacher>
    {
        public void ClearAll()
        {
          
        }
    }
}
