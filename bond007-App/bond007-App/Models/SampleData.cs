using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace bond007_App.Models
{
    public class SampleData : DropCreateDatabaseAlways<BondDataContext>
    {
        BondDataContext context = new BondDataContext();
        protected override void Seed(BondDataContext context)
        {
            context.SaveChanges();
        }

        public SampleData()
        {
            if (context.Products.Count() <= 0)
            {
                Product p = new Product { CategoryID = "01", Desciption = "b", ImageUrl = "c", Metric = "d", Price = 9.0, ProductID = "1", ProductName = "007", Units = 1 };
                context.Products.Add(p);
            }

            if (context.Categories.Count() <= 0)
            {
                Category c = new Category { CategoryID = "01", CategoryName = "SampleName" };
                context.Categories.Add(c);
            }
            context.SaveChanges();
        }
    }
}