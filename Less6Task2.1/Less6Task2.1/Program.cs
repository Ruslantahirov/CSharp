using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less6Task2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 1, 2, 3, 4, 6, 8, 98 };
            int y = 4;
            int z = 3;

            // Paramsla(2, 5, 6, 8, 9);
            arrays(x, z);
            
        }
        public static void arrays(int[] array, int eded)
        {
            bool v = false;
            for (int i = 0; i < array.Length; i++)
            { 
               
                if (array[i] == eded)
                {
                    v = true;
                }
            
            }
            if (v)
            {
                Console.WriteLine("Verilmis eded array daxildi");

            }
            else
            {
                Console.WriteLine("Verilmis eded array daxil deyil");
            }
        }
       
    }
    
}
