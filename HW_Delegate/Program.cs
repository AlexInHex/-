using System;

namespace HW_Delegate
{
    class Program
    {
        delegate int Aripfmetic(int num1, int num2);
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

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

            

            Console.WriteLine(aripfmeticSum(num1, num2));
            Console.WriteLine(aripfmetiсSub(num1, num2));
            Console.WriteLine(aripfmeticMult(num1, num2));
            Console.WriteLine(aripfmeticDev(num1, num2));

        }
    }

    
}
