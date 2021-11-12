using System;

namespace DisposeAndFinalizeDemo
{
    class Program
    {
        public static int choice;
        public void Operations()
        {
            while (choice != 3)
            {
                Console.WriteLine("\n Enter 1 for Finalize Method" +
                    "\n Enter 2 for Dispose Method" +
                    "\n Enter 15 for Exit");
                Console.WriteLine("\n Enter Your Choice ");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        FinalizeDemo finalizeDemo = new FinalizeDemo();
                        finalizeDemo = null;
                        GC.Collect();
                        Console.ReadLine();
                        break;
                    case 2:
                        DisposeDemo disposeDemo = new DisposeDemo();
                        disposeDemo.Dispose();
                        disposeDemo = null;
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Operations();
        }
    }
}
