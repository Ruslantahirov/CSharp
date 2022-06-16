using System;
using System.Linq;

namespace Less5Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 6, 7, 8, 23, 78, 34, 12 };
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }


            Console.WriteLine("-----------");


            int min = nums.Min();
            Console.WriteLine(min);//KIcik eded

            Console.WriteLine("-----------");

            Console.WriteLine(nums.Max());//Boyuk eded

            Console.WriteLine("-----------");

            Array.Sort(nums);
            foreach (int i in nums)
            {
                Console.WriteLine(i);  //Sortlasdirmaq
            }

            Console.WriteLine("-----------");

            Console.WriteLine(nums.Sum()); //Cemi

            Console.WriteLine("-----------");




        }
    }
}
