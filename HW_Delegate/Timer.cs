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

        private TimerDelegat<int> timerEventHandlers;

        public event TimerDelegat<int> TimerEventHandler
        {
            add { timerEventHandlers += value;}
            remove { timerEventHandlers -= value;}
        }

        private int counter = 0;

        public void TimerStart()
        {
            
            while (true)
            {  
                Thread.Sleep(1000);
                timerEventHandlers?.Invoke(this, counter);
                counter++;

            }
        }
    }
}
