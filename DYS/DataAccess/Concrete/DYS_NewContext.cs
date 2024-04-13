using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DYS.Entities.Concrete;

namespace DYS.DataAccess.Concrete
{
    public  class DYS_NewContext : DbContext
    {

           public  DbSet<Student> Student { get; set; }
            public DbSet<Teacher> Teacher { get; set; }
             DbSet<Course> Course { get; set; }
            public DbSet<Payment> Payment { get; set; }


    }
}
