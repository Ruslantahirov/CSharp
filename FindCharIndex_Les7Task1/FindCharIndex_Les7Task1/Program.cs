using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindCharIndex_Les7Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x = "alama";
            Console.WriteLine(x);
            //char y = 'm';
            char y = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(Find_Char_Index(x, y));
            Find_Char_Index(x,y);
        }
        public static int Find_Char_Index(string x, char y)
        {
            for (int i = 0; i < x.Length; i++)
            {
                if(x[i] == y)
                {
                    return i;    
                }  

            }
            return -1;
             
        }
           
        
    }
}
