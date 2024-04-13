using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DYS.DataAccess.Abstract;
using DYS.Entities.Abstract;

namespace DYS.Entities.Concrete
{
    public class Student:Entity
    {
        public string PaymentAmount { get; set; } 

        public string PaymentInstallment { get; set; }
        
        public string PaymentType { get; set; }

        public string ClassType { get; set; }



    }
}
