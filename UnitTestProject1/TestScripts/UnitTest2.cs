using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1.TestScripts
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] a = { 1, 2,3, 4, 5, 6 ,7 };  
            
            int len = a.Length;

            for (int i = 0; i < len; i++)
            {
                for(int j= 0; j < len;j++)
                {
                    if (i == j)
                    {
                        Console.WriteLine(a[i]);
                    }
                    else
                    {
                       
                    }
                }

            }

            



        }
    }
}
