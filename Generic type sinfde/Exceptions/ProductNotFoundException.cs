using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_type_sinfde.Exceptions
{
    internal class ProductNotFoundException
    {
        public ProductNotFoundException(string message) : base(message)
        {
            Console.WriteLine("messsage");
        }
    }
}
