using Generic_type_sinfde.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_type_sinfde.Models
{
    internal class Basket
    {
        public int ProductLimit { get; set; }
        List<Product>   Products=new List<Product>();
        public int StockCount { get; set; }

        public int Count { get; set; }



        public void AddProduct(Product product)
        {
            return;
            //Array.Resize(ref products, products.Length + 1);
            //products[products.Length - 1] = product; 
            
        }
        public void RemoveProduct(int? id)
        {
            if (id==null)
            {
                throw new NullReferenceException("Nulldur");
            }
            else
            {
                throw new ProductNotFoundException("nuldeyil");
            }
            
        }

        public void RemoveAllProducts<Product>(int? id)
        {
            Products.Clear();
        }
       
        public void IncreaseProductCount(Product product)
        {
            product.Count++;    
            product.StockCount --;
        }
        public void DecreaseProductCount(Product product)
        {
            product.Count--;
            product.StockCount++;       

        }
        public void GetAllProducts()
        {

        }
    }
}
