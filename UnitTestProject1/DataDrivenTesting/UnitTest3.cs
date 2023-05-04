using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace UnitTestProject1.DataDrivenTesting
{
    [TestClass]
    public class UnitTest3
    {
       
        [TestMethod]
        [TestCategory("DynamicData"), TestCategory("DataDriven")]
        [DynamicData(nameof(Tests),DynamicDataSourceType.Property)]
        public void TestMethod(int a, int b, int c)
        {
            int multiply = a * b;
            bool result = false;

            if (multiply == c)
            {
                result = true;
            }
            Assert.IsTrue(result, "result not matching");
        }




        [TestMethod]
        [TestCategory("DynamicData"), TestCategory("DataDriven")]
        [DynamicData(nameof(numberData),DynamicDataSourceType.Method)]
        public void UsingMethodDynamicTestDataMethod(int a, int b, int c)
        {
            int multiply = a + b;
            bool result = false;

            if (multiply == c)
            {
                result = true;
            }
            Assert.IsTrue(result, "result not matching");

        }


        public static IEnumerable<object[]> numberData()
        {

            yield return new object[] { 1, 1, 2 };
            yield return new object[] { 1, 2, 3 };
            yield return new object[] { 2, 2, 4 };
        }

        public static IEnumerable<object[]> Tests()
        {

            yield return new object[] { 1, 1, 2 };
            yield return new object[] { 1, 2, 3 };
            yield return new object[] { 2, 2, 4 };
        }



    }
}
