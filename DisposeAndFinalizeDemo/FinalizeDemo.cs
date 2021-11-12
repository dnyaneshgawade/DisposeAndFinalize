using System;
using System.Collections.Generic;
using System.Text;

namespace DisposeAndFinalizeDemo
{
    class FinalizeDemo
    {
        public FinalizeDemo()
        {
            Console.WriteLine("Object Created");

        }

        ~FinalizeDemo()
        {
            Console.WriteLine("Destructor Called.");
        }
    }
}
