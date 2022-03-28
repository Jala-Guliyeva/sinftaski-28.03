using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_type_sinfde.Exceptions
{
    internal class ProductCountException
    {
        public ProductCountException(string message) : base(message)
        {
            Console.WriteLine("elave olunub");
        }
    }
}
