using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Timing
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfTheArray;
            Console.WriteLine("Plesae insert array size: ");

            sizeOfTheArray = Convert.ToInt32(Console.ReadLine());

            int[] nums = new int[sizeOfTheArray];
            BuildArray(nums);
            TimeSpan startTime;
            TimeSpan duration;

            startTime = Process.GetCurrentProcess().Threads[0].UserProcessorTime;

            DisplayNums(nums);

            duration = Process.GetCurrentProcess().Threads[0].UserProcessorTime.Subtract(startTime);

            Console.WriteLine("Time: " + duration.TotalSeconds);

            Console.ReadLine();
        }

        public static void BuildArray(int[] array)
        {
            for(int i = 0; i <= array.GetUpperBound(0); i++)
            {
                array[i] = i;
            }
        }

        public static void DisplayNums(int[] array)
        {
            for(int i = 0; i <= array.GetUpperBound(0); i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
