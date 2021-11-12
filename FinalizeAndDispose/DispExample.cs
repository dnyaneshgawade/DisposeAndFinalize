using System;
using System.Collections.Generic;
using System.Text;

namespace FinalizeAndDispose
{
    class DispExample : IDisposable
    {
        private bool disposed = false;
        public void Greeting(string name)
        {
            Console.WriteLine(string.Format("Hello {0} ",name));
        }
        ~DispExample()
        {
            Console.WriteLine("Inside Finalize");
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    Console.WriteLine("Cleanup Managed Object");
                }
                Console.WriteLine("Cleanup unmanaged Object");
                disposed = true; 
            }
        }
    }
}
