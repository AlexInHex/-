using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HW_Delegate
{
    class Program
    {
        
        private static void Handler1()
        {
            Console.WriteLine("Таймер запущен");
        }

        private static void Handler2()
        {
            Console.WriteLine();                
        }

        
        

        static void Main(string[] args)
        {
            TimerEvent instance = new TimerEvent();

            instance.tick += new timerDelegat (Handler1);
            instance.tick += Handler2;

            

            instance.InvokeEvent();

            
        }
    }
}
