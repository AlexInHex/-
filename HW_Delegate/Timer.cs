using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HW_Delegate
{

    class Timer
    {
        private Action action;
        private int seconds;

        public Timer(Action action, int seconds)
        {
            this.action = action;
            this.seconds = seconds * 1000;

        }

        private bool button = true;

        public void Start()
        {
            Thread start = new Thread(() =>
            {
                while (button)
                {
                    action();
                }
            });

            start.Start();          
        }

        public void Stop()
        {
            if (button)
            {
                button = false;
            }
        }

        public void Restart()
        {

        }




    }
}
