using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_Fibonacci.BL
{
    class Logic : ISequenceLogic
    {
        int a = 0;
        int b = 1;
        int _start;
        int _end;

        public Logic(int start, int end)
        {
            _start = start;
            _end = end;
            ObjectPreparation();
        }

        private void ObjectPreparation()
        {
            int i;
            while ((a + b) < _start)
            {
                i = a + b;
                a = b;
                b = i;
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            while ((a + b) < _end)
            {
                int i = (a + b);
                yield return i;
                a = b;
                b = i;
            }
        }
    }
}
