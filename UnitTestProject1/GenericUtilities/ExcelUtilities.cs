using Bytescout.Spreadsheet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.GenericUtilities
{
    public class ExcelUtilities
    {
        public string excelData(int rowNo, int columnNo)
            {
        Spreadsheet sheet = new Spreadsheet();
            sheet.LoadFromFile("D:\\C#\\Excel\\Workbook1.xlsx");
           

             Worksheet sh = sheet.Workbook.Worksheets.ByName("Sheet1"); //particular sheet

            string data = sh.Cell(rowNo, columnNo).ToString();

            return data;
        }



    }
}
