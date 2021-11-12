using System;
using System.Collections.Generic;
using System.Text;

namespace DisposeAndFinalizeDemo
{
    class DisposeDemo : IDisposable
    {
        private bool Disposed = false;
        public DisposeDemo()
        {
            Console.WriteLine("Object Created");

        }

        ~DisposeDemo()
        {
            Console.WriteLine("Destructor Called.");
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);

        }
        public void Dispose(bool disposing)
        {
            if (!Disposed)
            {
                if (disposing)
                {
                    Console.WriteLine("Called From Dispose");
                    //Clear all the managed resources here  
                }
                else
                {
                    //Clear all the unmanaged resources here  
                }
                Disposed = true;


            }
        }
    }
}
