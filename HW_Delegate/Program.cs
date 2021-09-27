using System;
using System.Threading;

namespace HW_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {

            Timer timer = new Timer(() => Console.WriteLine("0_0"), 3);


            timer.Start();



            


        }
    }
}
