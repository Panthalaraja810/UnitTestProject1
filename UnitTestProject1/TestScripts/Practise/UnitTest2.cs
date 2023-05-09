using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1.TestScripts.Practise
{
    [TestClass]
    public class UnitTest2
    {
        //    1
        //   2 2
        //  3 3 3
        // 4 4 4 4
        //5 5 5 5 5

        [TestMethod]
        public void TestMethod1()
        {
            int n = 5;

            for(int i = 1; i <= n; i++)  //rows
            {

                for(int j = i; j <= n; j++) //space
                {
                    Console.Write(" ");
                }
                for(int j = 1; j <= i; j++)  //printing statement
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();

            }
        }
    }
}
