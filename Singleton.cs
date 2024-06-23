using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  
namespace TestConsoleApp
{ 
    public sealed class Singleton
    { 
        
        
        private static int Counter = 0;
        private static Singleton instance = null;
        public static Singleton GetInstance {
            get {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }
        private Singleton()
        {
            Counter++;
            Console.WriteLine("Counter Value is" + Counter);
        }
        
    } 
}
