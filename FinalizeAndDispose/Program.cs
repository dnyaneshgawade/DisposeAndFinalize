using System;

namespace FinalizeAndDispose
{
    class Program
    {
        static void Main(string[] args)
        {
            C c = new C();
            Console.WriteLine("C Object Created....");
            c = null;
            Console.WriteLine("Assigned null ... object Distructing...");
            GC.Collect();
            Console.ReadLine();

            DispExample dsp = new DispExample();
            Console.WriteLine("DispExample Object created...");
            dsp.Greeting("Dnyanesh");
            dsp.Dispose();
            dsp = null;
            Console.WriteLine("Assigned Null... Object Distructing...");

            Console.ReadLine();
        }
    }
}
