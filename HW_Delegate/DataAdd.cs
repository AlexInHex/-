using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Delegate
{
    delegate double Aripfmetic(double num1, double num2);
    class DataAdd
    {
        public double Math(string command, double num1, double num2)
        {
            UserCommands userCommands = new UserCommands();

            Aripfmetic aripfmeticSum = (num1, num2) => num1 + num2;
            Aripfmetic aripfmetiсSub = (num1, num2) => num1 - num2;
            Aripfmetic aripfmeticMult = (num1, num2) => num1 * num2;
            Aripfmetic aripfmeticDev = (num1, num2) =>
            {
                if (num2 == 0)
                {
                    Console.WriteLine("на ноль делить нельзя");
                    return 0;
                }
                else
                {
                    return num1 / num2;
                }               
            };


            if (userCommands.UserCommand(command) == "sum")
            {               
                Console.WriteLine(aripfmeticSum(num1, num2));                
            }
            else if (userCommands.UserCommand(command) == "sub")
            {               
                Console.WriteLine(aripfmetiсSub(num1, num2));                
            }
            else if(userCommands.UserCommand(command) == "mult")
            {                
                Console.WriteLine(aripfmeticMult(num1, num2));                
            }
            else if (userCommands.UserCommand(command) == "dev")
            {
                Console.WriteLine(aripfmeticDev(num1, num2));           
            }
            else if (userCommands.UserCommand(command) == "rand") // Вторая часть ДЗ. Сумма членов массива делегатов. 
            {
                Console.WriteLine(ShowResult.Result());
            }
                      
            return 0;


        }
    }
}
