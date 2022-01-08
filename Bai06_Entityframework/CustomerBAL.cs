using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai06_Entityframework
{
   public class CustomerBAL
    {
        CustomerDAL dal = new CustomerDAL();

        public List<CustomerBEL> ReadCustomer()
        {
            List<CustomerBEL> lstCus = dal.ReadCustomer();
            return lstCus;
        }
        public void NewCustomer(CustomerBEL cus)
        {
            dal.NewCustomer(cus);
        }
        public void DeleteCustomer(int id, string name)
        {
            var cus = new CustomerBEL() { Id = id, Name = name };
            dal.DeleteCustomer(cus);
        }
        public void EditCustomer(CustomerBEL cus)
        {
            dal.EditCustomer(cus);
        }
    }
}
