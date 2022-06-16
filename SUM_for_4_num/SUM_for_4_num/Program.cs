using System;

namespace SUM_for_4_num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4 reqemli ededi daxil edin:");
            int a=Convert.ToInt32(Console.ReadLine());
            int sum=0;
                  

            for (int i = 1; i <= 4; i++)
            {
                sum +=a % 10;
                a = a /10;

                
            }
            Console.WriteLine(sum);
        }
    }
}
