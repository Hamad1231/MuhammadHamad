using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MuhammadHammad.Models
{
    public class EmpDb : DbContext
    {
        public EmpDb() : base("EmpDb")
        {

        }
        public DbSet<Employee> Emp { get; set; }
    }
}