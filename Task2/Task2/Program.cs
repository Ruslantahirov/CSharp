using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 ile verilmis eded arasinda kvadratlari cemi tapilmasi
            Console.WriteLine("1 ile verilmis eded arasinda kvadratlari cemi tapilmasi");
            Console.WriteLine("-------------");
            Console.WriteLine("enter a number : ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int stock = 0;
            for (int i = 1; i <= number1; i++)
            {
                stock += i * i;  

            }
            Console.WriteLine(stock);
        }
    }
}