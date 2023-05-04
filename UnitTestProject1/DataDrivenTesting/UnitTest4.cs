using Bytescout.Spreadsheet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1.DataDrivenTesting
{
    [TestClass]
    public class ExcelDataDriven
    {
        Spreadsheet sheet; //declaring spreadsheet as global
        [TestMethod]
        [TestCategory("Excel Data fetch")]
        public void TestMethod1() //test method
        {

            string data = sheet.Workbook.Worksheets.ByName("Sheet1").Cell(0, 0).ToString(); //fetching the data from excelsheet (0,0)
            Console.WriteLine(data); //printing the data fetched

        }
        [TestMethod]
        [TestCategory("multiple data")]
        public void TestMethod2() //method for fetching multiple datas
        {
            ;
            Worksheet sh = sheet.Workbook.Worksheets.ByName("Sheet1"); //particular sheet
            int rowNum = sh.UsedRangeRowMax; //this method will fetch the all the rows
            int colNum = sh.UsedRangeColumnMax; //this method will fetch the all the columns
            for (int i = 0; i <= rowNum; i++) //for loop for iteration
            {
                for (int j = 0; j <= colNum; j++)
                {
                    string data = sh.Cell(i, j).ToString();
                    Console.Write(data + "   ");
                }
                Console.WriteLine();
            }
        }
        [TestInitialize]
        public void TestInit()
        {
            sheet = new Spreadsheet();
            sheet.LoadFromFile("C:\\Users\\panth\\OneDrive\\Documents\\Excel.xlsx"); //path of the excel
        }

        [TestCleanup]
        public void TestCleanup()
        {
            sheet.Dispose();
        }
    }
}
