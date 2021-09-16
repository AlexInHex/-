using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Delegate
{
    delegate int RandDelegat();    
    class ShowResult
    {
       static RandDelegat[] MassDelegats = new RandDelegat[]
           {
               RandomNum,
               RandomNum,
               RandomNum,
               RandomNum,
               RandomNum,
               RandomNum
           };
       
        private static int RandomNum()
        {
            Random rand = new Random();
            int x = rand.Next(1, 10);
            return x;
        }

        public static double Result()
        {            
            int resNum = 0;
            for (int i = 0; i < MassDelegats.Length; i++)
            {
                resNum += MassDelegats[i]();
            }

            return resNum;
        }       
    }                        
}
