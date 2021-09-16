using System;
using HW_Delegate;

namespace HW_Delegate
{   
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите операцию и 2 числа над которыми будут проводится операции↓↓↓");

            

            DataAdd dataAdd = new DataAdd();

             while (true)
             {
                 string command = Console.ReadLine();
                 var inputArr = command.Split(' ');
                 string[] param = new string[3];
                 int index = 0;


                 foreach (var item in inputArr)
                 {
                     if (!string.IsNullOrEmpty(item) && index < param.Length)
                     {
                         param[index] = item;
                         index++;
                     }
                 }

                 double number1 = double.Parse(param[1]);
                 double number2 = double.Parse(param[2]);

                 dataAdd.Math(param[0], number1, number2);
             }
                      
            



        }
    } 
}
