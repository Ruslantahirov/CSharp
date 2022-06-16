using System;


namespace Les6Task1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string output = null;
            //Console.Write("Sozu daxil edin : ");
            //string input = Console.ReadLine();
            //if (input != null)
            //{
            //    for (int i = input.Length - 1; i >= 0; i--)
            //    {
            //        output += input[i].ToString();
            //    }
            //    if (input == output)
            //    {
            //        Console.WriteLine($"Daxil edilen ={input}  palidrome-du {output}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Daxil edilen {input}  palidrome {output} deyil");
            //    }
            //}

            //task2
            int[] x = { 1, 2, 3, 4, 6, 8, 98 };
            int y = 4;
            int z = 7;

            // Paramsla(2, 5, 6, 8, 9);
            arrays(x, z);
        }
        public static void arrays(int[] array, int eded)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == eded)
                {
                    Console.WriteLine("Verilmis eded array daxildi");
                }

            }
        }
        ////Les6Task 3
        //public static void Paramsla(params int[] array)
        //{
        //    int sum = 0;
        //    int hasil = 1;
        //    foreach (var item in array)
        //    {
        //        sum += item;

        //        hasil *= item;

        //    }
        //    Console.WriteLine($"arrayin hasili ={hasil}, arrayin cemi = {sum}, hasili ile ceminin  ferqi {hasil - sum}");
        //}
    }
}
