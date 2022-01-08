using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai06_Entityframework
{
   public class CustomerDAL:DBConnection
    {
        public List<CustomerBEL> ReadCustomer()
        {
            return Customers.ToList();
        }
        public void DeleteCustomer(CustomerBEL cus)
        {
            var DeleteCustomer = this.Customers.Where(c =>c.Id == cus.Id).FirstOrDefault();
            this.Customers.Remove(cus);
            this.SaveChanges();
        }
        public void NewCustomer(CustomerBEL cus)
        {
            this.Customers.Add(cus);
            this.SaveChanges();
        }
        public void EditCustomer(CustomerBEL cus)
        {
            var EditCustomer = this.Customers.Where(c => c.Id == cus.Id).FirstOrDefault();
            if (EditCustomer != null)
            {
                EditCustomer.Id = cus.Id;
                EditCustomer.Name = cus.Name;
                this.SaveChanges();
            }
           
           
        }
    }
}
