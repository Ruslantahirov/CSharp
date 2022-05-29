using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Vurma cedveli 1-den 9-a qeder
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    string numberString = $"{j} * {i} = {j * i} \t";
                    Console.Write(numberString);
                }
                Console.WriteLine();

            }
            // Vurma cedveli
            Console.WriteLine("Enter a number : ");
            byte number = Convert.ToByte(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {


                Console.WriteLine($"{number} * {i} = {number * i}");

            }

            
        }
    }
}  
       
