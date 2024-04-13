using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DYS.DataAccess.Concrete;
using DYS.Entities.Concrete;

namespace DYS.DataAccess.Abstract
{
    public abstract class DbOperations<T> where T : class
    {
      
        public  void Add(T entity)

        {
           
            using (var context = new DYS_NewContext())
            {
                context.Set<T>().Add(entity);
                context.SaveChanges();
            }
           
        }
        public  void Update(T entity)
        {

            using (var context = new DYS_NewContext())
            {
                context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            
        }
        public   void Delete(T entity)
        {
            using (var context = new DYS_NewContext())
            {
                var deletedEntity= context.Entry(entity);
                deletedEntity.State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();

            }
            
        }
        public   List<T> GetAll()
        {
            using (var context = new DYS_NewContext())
            {
                return context.Set<T>().ToList();

            }
            
        }
       

        
        
       


        
    }


    
}
