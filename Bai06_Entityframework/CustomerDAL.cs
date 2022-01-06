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
            this.Entry(cus).State = EntityState.Modified;
            this.SaveChanges();
        }
    }
}
