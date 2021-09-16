using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HW_Delegate
{
    public delegate void timerDelegat();
    class TimerEvent
    {
        public event timerDelegat tick = null;

        public void InvokeEvent()
        {
            tick.Invoke();
        }
    }
}
