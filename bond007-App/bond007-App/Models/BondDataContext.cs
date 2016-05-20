using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace bond007_App.Models
{
    public class BondDataContext : DbContext
    {
        public BondDataContext() : base("Data Source=l043qhb09x.database.windows.net;Initial Catalog=bondcodedb;user id=bond007;password=bond@123;MultipleActiveResultSets=True")
        {

        }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
    }
}