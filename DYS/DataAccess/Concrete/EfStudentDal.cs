using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DYS.DataAccess.Abstract;
using DYS.Entities.Concrete;

namespace DYS.DataAccess.Concrete
{
    public class EfStudentDal : DbOperations<Student>
    {

        public List<string> PaymentType()
        {

            List<string> paymentType = new List<string>();
            paymentType.Add("Nakit");
            paymentType.Add("Taksit");
           
            return paymentType;



        }

        public List<int> ClassType()
        {
            List<int> classType = new List<int>();
            classType.Add(8);
            classType.Add(9);
            classType.Add(10);
            classType.Add(11);
            classType.Add(12);
            return classType;
        }


        public List<int> TaksitMiktari()
        {
           List<int> taksitMiktari = new List<int>();
            taksitMiktari.Add(6);
            taksitMiktari.Add(12);
            return taksitMiktari;

        }
        public class EfPaymentDal : DbOperations<Payment>
        {

        }

    }

   

    

   
}
