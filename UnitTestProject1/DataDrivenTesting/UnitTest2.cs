using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;

namespace UnitTestProject1.DataDrivenTesting
{
    [TestClass]
    public class UnitTest2
    {
        public static IEnumerable<object[]> Tests 
        {
            get
            {
                return new[]
                {
                    new object[] {1,1,2},
                    new object[] {1,2,3},
                    new object[] {2,2,4},
                };
            }

        }

        [TestMethod]
        [TestCategory("DynamicData"),TestCategory("DataDriven")]
        [DynamicData(nameof(Tests))]
        public void TestMethod(int a, int b, int c)
        {

        }
    }
}
