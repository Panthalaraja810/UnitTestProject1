using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1.TestScripts.Practise
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //5
            //5 4 
            //5 4 3 
            //5 4 3 2
            //5 4 3 2 1

            int n = 5; 

            for(int i = 1; i <= n; i++)
            {
                int k = 5;

                for(int j = 1; j <= i; j++)
                {
                    Console.Write(k +" ");
                    k--;

                }
                
                Console.WriteLine();
            }




        }
    }
}
