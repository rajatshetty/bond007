using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace bond007_App.Models
{
    public class Product
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string CategoryID { get; set; }
        public string Desciption { get; set; }
        public Nullable<int> Units { get; set; }
        public string Metric { get; set; }
        public Nullable<double> Price { get; set; }
        public string ImageUrl { get; set; }
        public virtual ICollection<Category> categories { get; set; }
        [ForeignKey("CategoryID")]
        public Category Category { get; set; }
    }
}