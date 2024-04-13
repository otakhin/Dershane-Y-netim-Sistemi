using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DYS.Entities.Abstract;

namespace DYS.Entities.Concrete
{
    public  class Payment

    {
        public int PaymentId { get; set; }
        public int StudentId { get; set; }
        public string PaymentAmount { get; set; }
        public string PaymentInstallment { get; set; }
        public string PaymentType { get; set; }

        public string PaymentDate { get; set; }

    }
}
