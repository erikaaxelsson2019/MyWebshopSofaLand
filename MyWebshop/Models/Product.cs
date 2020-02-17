using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebshop.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public string Photo { get; set; }

        public double Price { get; set; }

        public string Description { get; set; }

        public string Material { get; set; }

        public string Color { get; set; }

        public string Width { get; set; }

        public string Height { get; set; }

        public string Depth { get; set; }
    }
}
