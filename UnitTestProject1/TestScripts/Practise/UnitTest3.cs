using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1.TestScripts.Practise
{
    [TestClass]
    public class UnitTest3
    {
        //1
        //2 2
        //1 1 1
        //2 2 2 2 
        //1 1 1 1 1

        [TestMethod]
        public void TestMethod1()
        {

            int n = 5;

            for(int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    if(i%2 ==0)
                    {
                        Console.Write(2+" ");
                    }
                    else
                    {
                        Console.Write(1+" ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
