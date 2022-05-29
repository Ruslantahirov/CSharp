using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 le verilmiş ədəd arasındaki ədədlərin hasili ilə cəminin fərqini hesablanmasi
            Console.WriteLine("1 ile verilmiş eded arasindaki ededlerin hasili ile ceminin ferqini hesablanmasi");
            Console.WriteLine("---------------");
            Console.WriteLine("Ededi daxil edin :");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int vurma = 1;
            int sum = 0;
            for (int i = 1; i <= number2; i++)
            {
                vurma *= i;
                sum += i;
                //Console.WriteLine($"{vurma}  {sum}");

            }
            Console.WriteLine($"Netice : {vurma - sum}");
        }
    }
}