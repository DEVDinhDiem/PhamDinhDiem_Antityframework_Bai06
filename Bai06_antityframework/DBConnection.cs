﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai06_antityframework
{
   public class DBConnection:DbContext
    {
        public DBConnection():base("name=SaleDB")
        {

        }
        public System.Data.Entity.DbSet<CustomerBEL> Customers { get; set; }
    }
}
