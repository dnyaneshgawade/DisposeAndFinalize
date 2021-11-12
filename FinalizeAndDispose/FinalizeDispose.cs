using System;
using System.Collections.Generic;
using System.Linq;  
using System.Text;

namespace FinalizeAndDispose
{
    class A
    {
        public A()
        {
            Console.WriteLine("Creating A");
        }
        ~A()
        {
            Console.WriteLine("Distructor --A");
        }
    }

    class B :A
    {
        public B()
        {
            Console.WriteLine("Creating B");
        }
        ~B()
        {
            Console.WriteLine("Distructor --B");
        }
    }

    class C:B
    {
        public C()
        {
            Console.WriteLine("Creating C");
        }
        ~C()
        {
            Console.WriteLine("Distructor --C");
        }
    }
}
