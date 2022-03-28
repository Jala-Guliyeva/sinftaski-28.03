using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_type_sinfde.Models
{
    internal class Product
    {
        public int Id { get; }
        private static int _id;
        public string Name { get; set; }
        public int Price { get; set; }
        public int StockCount { get; set; }
        public int Count { get; set; }


        public Product()
        {
            _id++;
            Id = _id;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Name:{Name} - Price {Price} - StockCount{StockCount} - Count{Count}");
        }
    }
}
