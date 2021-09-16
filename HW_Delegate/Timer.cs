using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HW_Delegate
{
    class Timer
    {
        public static int TimerStart()
        {
            int timer = 0;



            while (true)
            {
                Console.WriteLine(timer);
                Thread.Sleep(1000);
                timer++;
            }
        }



    }
}
