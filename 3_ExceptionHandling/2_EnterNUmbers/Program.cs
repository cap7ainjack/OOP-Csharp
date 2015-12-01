using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_EnterNUmbers
{
    class Program
    {
        private const int startNum = 1;
        private const int endNum = 100;
        private static List<int> nums;
        private const int count = 10;

        static void Main(string[] args)
        {
               nums = new List<int>();

            while (nums.Count < count)
            {
                try
                {
                    nums.Add(!nums.Any() ? ReadNumber(startNum, endNum) : ReadNumber(nums[nums.Count - 1], endNum));
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                catch (ArgumentOutOfRangeException)
                {
                    Console.Error.WriteLine($"Entered number is out of range {startNum} - {endNum}");
                }

                catch (Exception)
                {
                    Console.Error.WriteLine("Please read carefully. Input is not correct.");
                }
            }

            Console.WriteLine("Success! Your numbers are: {0}", string.Join(",",nums));
        }



        private static int ReadNumber(int start, int end)
        {
            Console.WriteLine($"Enter number between {start+1} and {end  - 1}");
            int inputNum = int.Parse(Console.ReadLine());

            if (inputNum >= end || inputNum <= start)
            {
                throw new ArgumentOutOfRangeException("Entered number not in correct range");
            }

            if (end - inputNum < count - nums.Count)
            {
                throw new ArithmeticException("Numbers game is over now.");
            }

            return inputNum;
        }
    }
}
