using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ConsoleManagment
    {
        public bool GetIntegerInputParamets(out int value)
        {
            if (int.TryParse(Console.ReadLine(), out int result))
            {
                value = result;
                return true;
            }
            else
            {
                Console.WriteLine("Input parametr must be Integer");
                value = result;
                return false;
            }
        }
        public bool GetDoubleInputParamets(out double value)
        {
            if (double.TryParse(Console.ReadLine(), out double result))
            {
                value = result;
                return true;
            }
            else
            {
                Console.WriteLine("Input parametr must be Double");
                value = result;
                return false;
            }
        }
    }
}
