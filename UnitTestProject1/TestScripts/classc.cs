using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.TestScripts
{
    class Program
    {
        public  static void Main(string[] args)
        {
            for (int i = 7; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
