using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingArray
{
    class Program
    {
        //Passing Array as an Argument
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            UpdateArray(nums);

            foreach (var item in nums)
                Console.WriteLine(item);
            //Console.WriteLine("Hello World!");
        }

        public static void UpdateArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i] = arr[i] + 10;
        }
    }
}
