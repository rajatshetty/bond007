using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace bond007_App.Models
{
    public class BondDataContext : DbContext
    {
        public BondDataContext() : base("Data Source=vcfnopvp95.database.windows.net,1433;Initial Catalog=bond007;user id=bond007;password=Rajat@123")
        {

        }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
    }
}