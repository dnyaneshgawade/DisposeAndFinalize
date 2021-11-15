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


            GCProgram myGCCol = new GCProgram();

            // Determine the maximum number of generations the system
            // garbage collector currently supports.
            Console.WriteLine("The highest generation is {0}", GC.MaxGeneration);

            myGCCol.MakeSomeGarbage();

            // Determine which generation myGCCol object is stored in.
            Console.WriteLine("Generation: {0}", GC.GetGeneration(myGCCol));

            // Determine the best available approximation of the number
            // of bytes currently allocated in managed memory.
            Console.WriteLine("Total Memory: {0}", GC.GetTotalMemory(false));

            // Perform a collection of generation 0 only.
            GC.Collect(0);

            // Determine which generation myGCCol object is stored in.
            Console.WriteLine("Generation: {0}", GC.GetGeneration(myGCCol));

            Console.WriteLine("Total Memory: {0}", GC.GetTotalMemory(false));

            // Perform a collection of all generations up to and including 2.
            GC.Collect(2);

            // Determine which generation myGCCol object is stored in.
            Console.WriteLine("Generation: {0}", GC.GetGeneration(myGCCol));
            Console.WriteLine("Total Memory: {0}", GC.GetTotalMemory(false));
            Console.Read();
        }
    }
}
