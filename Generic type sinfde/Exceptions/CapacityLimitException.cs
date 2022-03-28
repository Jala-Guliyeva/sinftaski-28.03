using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_type_sinfde.Exceptions
{
    internal class CapacityLimitException
    {
        public CapacityLimitException(string message) : base(message)
        {
            Console.WriteLine("oldu");
        }
           
    }
}
