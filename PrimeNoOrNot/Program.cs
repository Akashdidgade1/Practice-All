using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Or_Not
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Please enter a Number");
             int input= int.Parse(Console.ReadLine());*/
            int[] num = { 1, 2, 3, 5, 7, 6, 9 };

            var fact = 0;
            for (int i = 1; i < num.Length; i++)
            {
                if (num[i] % i == 0)
                {
                    fact++;
                }
                if (fact == 2)
                {
                    Console.WriteLine($"{num[i]} Prime No.");
                }
                else
                {
                    Console.WriteLine($"{num[i]} Not Prime No.");
                }
            }


            Console.ReadLine();
        }
    }
}
