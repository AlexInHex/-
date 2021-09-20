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
        

        private static void Handler1<TEventArgs>(object obj, TEventArgs e)
        {
            Console.WriteLine("Таймер запущен");
        }

        private static void Handler2(object obj, int e)
        {
            Console.WriteLine(e);                
        }                

        static void Main(string[] args)
        {
            Timer timer = new Timer();

            timer.TimerEventHandler += new TimerDelegat<int>(Handler1);
            timer.TimerEventHandler += Handler2;

            timer.TimerStart();



        }
    }
}
