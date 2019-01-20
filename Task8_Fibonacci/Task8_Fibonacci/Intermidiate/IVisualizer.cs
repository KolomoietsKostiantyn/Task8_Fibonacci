using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_Fibonacci.Intermidiate
{
    interface IVisualizer
    {
        void ResiveAnswer(IEnumerator<int> nums);
        void ShowInstruction();
    }
}
