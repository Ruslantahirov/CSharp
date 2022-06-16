using System;

namespace Less4Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ededi daxil edin:");
            int age = Convert.ToInt32(Console.ReadLine());
            if (0<age && age<30)
            {
               
                Console.WriteLine(age*age);
            }
            else if (30<age && age<40)
            {
                int x = age % 10;
                Console.WriteLine(x);
            }

            else if (age<0 || age>100)
            {
                Console.WriteLine("Düzgün məlumat daxil etməmisiniz");
            }

        }
    }
}
