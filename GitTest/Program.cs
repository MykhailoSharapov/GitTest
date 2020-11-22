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
            bool isEndOfProg = false;
            do
            {
                bool flag = false;
                
                Console.WriteLine("Please input parametr A:");
                int parametrA = 0;
                do
                {
                    flag = new ConsoleManagment().GetIntegerInputParamets(out int result);
                    parametrA = result;
                    if (parametrA == 0)
                    {
                        Console.WriteLine("ParamtrA is equal 0, korney ne budet , try again");
                        flag = false;
                    }
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
                float parametrD = (parametrB * parametrB) - (4 * parametrA * parametrC);
                if (parametrD < 0)
                {
                    Console.WriteLine("korney net");
                }
                else if (parametrD == 0)
                {
                    Console.WriteLine("Your koren is {0}", new MathLib().GetKorenOdin(parametrB, parametrA, parametrD));
                }
                else
                {
                    Console.WriteLine("Your koren is {0}, and {1}", new MathLib().GetKorenOdin(parametrB, parametrA, parametrD), new MathLib().GetKorenDva(parametrB, parametrA, parametrD));
                }
                Console.WriteLine("Do you want to continue? y/n");
                char isContinueChar = Console.ReadKey().KeyChar;
                if(!isContinueChar.Equals('y'))
                {
                    isEndOfProg = true;
                }
                Console.Clear();
            }
            while (!isEndOfProg);
        }
    }
}
