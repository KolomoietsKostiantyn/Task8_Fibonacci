using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task8_Fibonacci.Intermidiate;

namespace Task8_Fibonacci.BL
{
    class Controler
    {
        private IVisualizer _visualizer;
        private string[] _arr;
        private ISequenceLogic _sequenceLogic;

        public Controler(IVisualizer visualizer, string[] arr)
        {
            _visualizer = visualizer;
            _arr = arr;
        }

        public void Start()
        {
            int start;
            int end;
            if (InputProcessing(_arr, out start, out end))
            {
                _sequenceLogic = new Logic(start, end);
                _visualizer.ResiveAnswer(_sequenceLogic.GetEnumerator());
            }
            else
            {
                _visualizer.ShowInstruction();
            }
        }

        private bool InputProcessing(string[] arr, out int start, out int end)
        {
            start = 0;
            end = 0;
            if (arr == null || arr.Length != 2)
            {
                return false;
            }
            bool result = true;
            if (!int.TryParse(arr[0],out start))
            {
                result = false;
            }

            if (result && !int.TryParse(arr[1], out end))
            {
                result = false;
            }

            return result;
        }



    }
}
