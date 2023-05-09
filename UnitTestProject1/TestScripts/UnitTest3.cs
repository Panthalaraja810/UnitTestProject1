using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1.TestScripts
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7 };

            int len = a.Length;
            var al =a.Length;

            for(int i=0; i<len; i++)
            {
                for(int j=0; i<al; j++)
                {
                    Console.WriteLine(a[i]);
                }
                al--;

            }
         //   al--;
         //   Console.WriteLine();






        }
    }
}
