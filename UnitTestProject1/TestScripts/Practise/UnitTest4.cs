using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1.TestScripts.Practise
{
    [TestClass]
    public class UnitTest4
    {
        //* * * * *
        //* * * *
        //* * *
        //* *
        //*

        [TestMethod]
        public void TestMethod1()
        {
            int n = 5;

            for(int i = 1; i <= n; i++)
            {
                for(int j = n; j >= i; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }


        }
    }
}
