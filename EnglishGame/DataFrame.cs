using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelApp = Microsoft.Office.Interop.Excel;

namespace thuchanh3
{
    internal class DataFrame
    {
        public static DataTable new_DataItem()
        {
            DataTable res = new DataTable();
            res.Columns.Add("Name", typeof(string));   

            return res;
        }

        public static DataTable ReadItem(string name)
        {
            string url = Application.StartupPath + "//" + name;

            ExcelApp.Application excelApp = new ExcelApp.Application();
            DataRow myNewRow;
            DataTable myTable;

            ExcelApp.Workbook excelBook = excelApp.Workbooks.Open(@url);
            ExcelApp._Worksheet excelSheet = excelBook.Sheets[1];
            ExcelApp.Range excelRange = excelSheet.UsedRange;

            int rows = excelRange.Rows.Count;

            myTable = new DataTable("MyDataTable");
            myTable.Columns.Add("Name", typeof(string));
            for(int i = 2; i <= rows; i++)
            {
                if(Convert.ToString(excelRange.Cells[i, 1].Value2) != null)
                {
                    myNewRow = myTable.NewRow();
                    myNewRow["Name"] = Convert.ToString(excelRange.Cells[i, 1].Value2);
                    myTable.Rows.Add(myNewRow);
                }    
            }

            excelApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

            return myTable;
        }

        public static void writeExcel(int row)
        {
            string filePath = Application.StartupPath + "//SaveGame.xlsx";
            ExcelApp.Application excelApp = new ExcelApp.Application();
            ExcelApp.Workbook wb;
            ExcelApp.Worksheet ws;

            wb = excelApp.Workbooks.Open(filePath);
            ws = wb.Sheets[1];
            ExcelApp.Range excelRange = ws.UsedRange;
            excelRange[1, 1].Value = "row";
            excelRange[2, 1].Value = row;

            wb.Save();
            wb.Close();
        }

        public static DataTable readSaveGame()
        {
            string url = Application.StartupPath + "//SaveGame.xlsx";

            ExcelApp.Application excelApp = new ExcelApp.Application();
            DataRow myNewRow;
            DataTable myTable;

            ExcelApp.Workbook excelBook = excelApp.Workbooks.Open(@url);
            ExcelApp._Worksheet excelSheet = excelBook.Sheets[1];
            ExcelApp.Range excelRange = excelSheet.UsedRange;

            int rows = excelRange.Rows.Count;

            myTable = new DataTable("MyDataTable");
            myTable.Columns.Add("row", typeof(string));

            for (int i = 2; i <= rows; i++)
            {
                if (Convert.ToString(excelRange.Cells[i, 1].Value2) != null)
                {
                    myNewRow = myTable.NewRow();
                    myNewRow["row"] = Convert.ToString(excelRange.Cells[i, 1].Value2);
                    myTable.Rows.Add(myNewRow);
                }
            }

            excelApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

            return myTable;
        }
    }
}
