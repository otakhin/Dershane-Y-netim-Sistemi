using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DYS.DataAccess.Abstract;
using DYS.DataAccess.Concrete;
using DYS.Entities.Concrete;

namespace DYS.Entities.Abstract
{
    public abstract class Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        
        public long Phone { get; set; }
        public string Address { get; set; }




    }
}
