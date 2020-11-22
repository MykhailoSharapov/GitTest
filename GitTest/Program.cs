using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Library;

namespace GitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            Console.WriteLine("Please input parametr A:");
            int parametrA = 0;
            do
            {
                flag = new ConsoleManagment().GetIntegerInputParamets(out int result);
                parametrA = result;
            }
            while (!flag);
            Console.WriteLine("Please input parametr B:");
            int parametrB = 0;
            do
            {
                flag = new ConsoleManagment().GetIntegerInputParamets(out int result);
                parametrB = result;
            }
            while (!flag);
            Console.WriteLine("Please input parametr C:");
            int parametrC = 0;
            do
            {
                flag = new ConsoleManagment().GetIntegerInputParamets(out int result);
                parametrC = result;
            }
            while (!flag);
        }
    }
}
