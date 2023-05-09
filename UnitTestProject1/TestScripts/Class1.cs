using AventStack.ExtentReports.Gherkin.Model;
using Microsoft.Extensions.Logging.Console.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.TestScripts
{
    [TestClass]
    public class Class1
    {
        [TestMethod]
        public void Method()
        {
            string input = "aabbssdddaabb";
            string output = "";

            int count = 1;
            char currentChar = input[0];

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == currentChar)
                {
                    count++;
                }
                else
                {
                    output += currentChar + count.ToString();
                    currentChar = input[i];
                    count = 1;
                }
            }
            output += currentChar + count.ToString();
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }



  






}
