using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task8_Fibonacci.BL;
using Task8_Fibonacci.Intermidiate;
using Task8_Fibonacci.UI;

namespace Task8_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            IVisualizer visualizer = new ConsoleUI();
            Controler controler = new Controler(visualizer, args);
            controler.Start();

        }
    }
}
