using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task8_Fibonacci.Intermidiate;

namespace Task8_Fibonacci.UI
{
    class ConsoleUI: IVisualizer
    {
        public void ShowInstruction()
        {
            Console.WriteLine("Set the range with two arguments when" +
                " calling the main class and get the Fibonacci series entering this range.");
            Console.ReadKey();
        }

        public void ResiveAnswer(IEnumerator<int> nums)
        {
            bool flag = true;
            while (nums.MoveNext())
            {
                if (flag)
                {
                    Console.Write(nums.Current);
                }
                else
                {
                    Console.Write(", {0}", nums.Current);
                }
                flag = false;
            }
            Console.ReadKey();
        }
    }
}
