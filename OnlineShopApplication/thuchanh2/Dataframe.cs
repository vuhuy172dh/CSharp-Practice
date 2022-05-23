using System.Data;
using ExcelApp = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System;
using System.Collections.Generic;

namespace thuchanh2
{
    class Dataframe
    {
        public static DataTable new_DataItem()
        {
            DataTable res = new DataTable();
            res.Columns.Add("Name", typeof(string));
            res.Columns.Add("Sold", typeof(int));
            res.Columns.Add("Price", typeof(int));
            res.Columns.Add("Thương hiệu", typeof(string));
            res.Columns.Add("Xuất xứ thương hiệu", typeof(string));
            res.Columns.Add("Xuất xứ", typeof (string));
            res.Columns.Add("View", typeof(int));
            res.Columns.Add("Date", typeof(string));
            res.Columns.Add("Type", typeof(string));
            res.Columns.Add("Liked", typeof(int));
            res.Columns.Add("Số lượng", typeof(int));
            res.Columns.Add("Số lượng mua", typeof(int));
            return res;
        }

        public static DataTable new_User()
        {
            DataTable res = new DataTable();
            res.Columns.Add("Name", typeof(string));
            res.Columns.Add("Phone", typeof(string ));
            res.Columns.Add("Address", typeof(string));
            res.Columns.Add("Nickname", typeof(string));
            res.Columns.Add("Ngày sinh", typeof(string));
            res.Columns.Add("Giới tính", typeof(string));
            res.Columns.Add("Quốc tịch", typeof(string));
            res.Columns.Add("Email", typeof(string));
            res.Columns.Add("Discount", typeof(int));
            res.Columns.Add("Limit", typeof(int));
            res.Columns.Add("discount", typeof(int));
            return res;
        }

        public static DataTable new_Discount()
        {
            DataTable res = new DataTable();
            res.Columns.Add("Name", typeof (string));
            res.Columns.Add("Discription", typeof(string));
            res.Columns.Add("Mã", typeof(string));
            res.Columns.Add("HSD", typeof(string));
            res.Columns.Add("Điều kiện", typeof(string));

            return res;
        }

        public static DataTable new_DonHang()
        {
            DataTable res = new DataTable();
            res.Columns.Add("Mã đơn hàng", typeof(string));
            res.Columns.Add("Name", typeof(string));
            res.Columns.Add("Tạm tính", typeof(string));
            res.Columns.Add("Giảm giá", typeof(string));
            res.Columns.Add("Tổng cộng", typeof (string));
            res.Columns.Add("Ngày đặt", typeof(string));
            res.Columns.Add("Số lượng", typeof(int));
            res.Columns.Add("Giá sau", typeof(string));
            return res;
        }

        public static DataTable ReadExcel(string nameData)
        {
            string url = Application.StartupPath + nameData;

            ExcelApp.Application excelApp = new ExcelApp.Application();
            DataRow myNewRow;
            DataTable myTable;

            ExcelApp.Workbook excelBook = excelApp.Workbooks.Open(@url);
            ExcelApp._Worksheet excelSheet = excelBook.Sheets[1];
            ExcelApp.Range excelRange = excelSheet.UsedRange;

            int rows = excelRange.Rows.Count;

            myTable = new DataTable("MyDataTable");
            myTable.Columns.Add("Name", typeof(string));
            myTable.Columns.Add("Sold", typeof(int));
            myTable.Columns.Add("Price", typeof(int));
            myTable.Columns.Add("Thương hiệu", typeof(string));
            myTable.Columns.Add("Xuất xứ thương hiệu", typeof(string));
            myTable.Columns.Add("Xuất xứ", typeof(string));
            myTable.Columns.Add("View", typeof(int));
            myTable.Columns.Add("Date", typeof(string));
            myTable.Columns.Add("Type", typeof(string));   
            myTable.Columns.Add("Liked", typeof(int));
            myTable.Columns.Add("Số lượng", typeof(int));
            myTable.Columns.Add("Số lượng mua", typeof(int));

            for (int i = 2; i <= rows; i++)
            {
                if(Convert.ToString(excelRange.Cells[i, 1].Value2) != null)
                {
                    myNewRow = myTable.NewRow();
                    myNewRow["Name"] = Convert.ToString(excelRange.Cells[i, 1].Value2);
                    myNewRow["Sold"] = Convert.ToInt32(excelRange.Cells[i, 2].Value2);
                    myNewRow["Price"] = Convert.ToInt32(excelRange.Cells[i, 3].Value2);
                    myNewRow["Thương hiệu"] = Convert.ToString(excelRange.Cells[i, 4].Value2);
                    myNewRow["Xuất xứ thương hiệu"] = Convert.ToString(excelRange.Cells[i, 5].Value2);
                    myNewRow["Xuất xứ"] = Convert.ToString(excelRange.Cells[i, 6].Value2);
                    myNewRow["View"] = Convert.ToInt32(excelRange.Cells[i, 7].Value2);
                    myNewRow["Date"] = Convert.ToString(excelRange.Cells[i, 8].Value2); 
                    myNewRow["Type"] = Convert.ToString(excelRange.Cells[i, 9].Value2);
                    myNewRow["Liked"] = Convert.ToString(excelRange.Cells[i, 10].Value2);
                    myNewRow["Số lượng"] = Convert.ToInt32(excelRange.Cells[i, 11].Value2);
                    myNewRow["Số lượng mua"] = Convert.ToInt32(excelRange.Cells[i, 12].Value2); 
                    myTable.Rows.Add(myNewRow);
                }
            }

            excelApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

            return myTable;
        }

        public static DataTable ReadDonHangExcel(int sheet)
        {

            string url = Application.StartupPath + "\\DonHang.xlsx";

            ExcelApp.Application excelApp = new ExcelApp.Application();
            DataRow myNewRow;
            DataTable myTable;

            ExcelApp.Workbook excelBook = excelApp.Workbooks.Open(@url);
            ExcelApp._Worksheet excelSheet = excelBook.Worksheets[sheet.ToString()];
            ExcelApp.Range excelRange = excelSheet.UsedRange;

            int rows = excelRange.Rows.Count;
            myTable = new DataTable("MyUserTable");
            myTable.Columns.Add("Mã đơn hàng", typeof(string));
            myTable.Columns.Add("Name", typeof(string));
            myTable.Columns.Add("Tạm tính", typeof(string));
            myTable.Columns.Add("Giảm giá", typeof(string));
            myTable.Columns.Add("Tổng cộng", typeof(string));
            myTable.Columns.Add("Ngày đặt", typeof(string));
            myTable.Columns.Add("Số lượng", typeof(int));
            myTable.Columns.Add("Giá sau", typeof(string));
            for (int i = 2; i <= rows; i++)
            {
                if (Convert.ToString(excelRange.Cells[i, 1].Value2) != null)
                {
                    if(i == 2)
                    {
                        myNewRow = myTable.NewRow();
                        myNewRow["Mã đơn hàng"] = Convert.ToString(excelRange.Cells[i, 1].Value2);
                        myNewRow["Name"] = Convert.ToString(excelRange.Cells[i, 2].Value2);
                        myNewRow["Tạm tính"] = Convert.ToString(excelRange.Cells[i, 3].Value2);
                        myNewRow["Giảm giá"] = Convert.ToString(excelRange.Cells[i, 4].Value2);
                        myNewRow["Tổng cộng"] = Convert.ToString(excelRange.Cells[i, 5].Value2);
                        myNewRow["Ngày đặt"] = Convert.ToString(excelRange.Cells[i, 6].Value2);
                        myNewRow["Số lượng"] = Convert.ToInt32(excelRange.Cells[i, 7].Value2);
                        myNewRow["Giá sau"] = Convert.ToString(excelRange.Cells[i, 8].Value2);
                        myTable.Rows.Add(myNewRow);
                    }
                    else
                    {
                        myNewRow = myTable.NewRow();
                        myNewRow["Mã đơn hàng"] = Convert.ToString(excelRange.Cells[i, 1].Value2);
                        myNewRow["Name"] = Convert.ToString(excelRange.Cells[i, 2].Value2);
                        myNewRow["Số lượng"] = Convert.ToInt32(excelRange.Cells[i, 7].Value2);
                        myNewRow["Giá sau"] = Convert.ToString(excelRange.Cells[i, 8].Value2);
                        myTable.Rows.Add(myNewRow);
                    }
                    
                }
            }

            excelApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

            return myTable;
        }

        public static DataTable ReadUserExcel(string nameData)
        {
            string url = Application.StartupPath + nameData;

            ExcelApp.Application excelApp = new ExcelApp.Application();
            DataRow myNewRow;
            DataTable myTable;

            ExcelApp.Workbook excelBook = excelApp.Workbooks.Open(@url);
            ExcelApp._Worksheet excelSheet = excelBook.Sheets[1];
            ExcelApp.Range excelRange = excelSheet.UsedRange;

            int rows = excelRange.Rows.Count;
            myTable = new DataTable("MyUserTable");
            myTable.Columns.Add("Name", typeof(string));
            myTable.Columns.Add("Phone", typeof(string));  
            myTable.Columns.Add("Address", typeof(string));
            myTable.Columns.Add("Nickname", typeof (string));
            myTable.Columns.Add("Ngày sinh", typeof(string));
            myTable.Columns.Add("Giới tính", typeof(string));
            myTable.Columns.Add("Quốc tịch", typeof(string));
            myTable.Columns.Add("Email", typeof(string));
            myTable.Columns.Add("Discount", typeof(int));

            for (int i = 2; i <= rows; i++)
            {
                if (Convert.ToString(excelRange.Cells[i, 1].Value2) != null)
                {
                    myNewRow = myTable.NewRow();
                    myNewRow["Name"] = Convert.ToString(excelRange.Cells[i, 1].Value2);
                    myNewRow["Phone"] = Convert.ToString(excelRange.Cells[i, 2].Value2);
                    myNewRow["Address"] = Convert.ToString(excelRange.Cells[i, 3].Value2);
                    myNewRow["Nickname"] = Convert.ToString(excelRange.Cells[i, 4].Value2);
                    myNewRow["Ngày sinh"] = Convert.ToString(excelRange.Cells[i, 5].Value2);
                    myNewRow["Giới tính"] = Convert.ToString(excelRange.Cells[i, 6].Value2);
                    myNewRow["Quốc tịch"] = Convert.ToString(excelRange.Cells[i, 7].Value2);
                    myNewRow["Email"] = Convert.ToString(excelRange.Cells[i, 8].Value2);
                    myNewRow["Discount"] = Convert.ToInt32(excelRange.Cells[i, 9].Value2);  

                    myTable.Rows.Add(myNewRow);


                }
            }

            excelApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

            return myTable;

        }

        public static DataTable ReadDiscountExcel(string Name)
        {
            string url = Application.StartupPath + Name;

            ExcelApp.Application excelApp = new ExcelApp.Application();
            DataRow myNewRow;
            DataTable myTable;

            ExcelApp.Workbook excelBook = excelApp.Workbooks.Open(@url);
            ExcelApp._Worksheet excelSheet = excelBook.Sheets[1];
            ExcelApp.Range excelRange = excelSheet.UsedRange;

            int rows = excelRange.Rows.Count;
            myTable = new DataTable("MyDiscountTable");
            myTable.Columns.Add("Name", typeof(string));
            myTable.Columns.Add("Discription", typeof(string));
            myTable.Columns.Add("Mã", typeof(string));
            myTable.Columns.Add("HSD", typeof(string));
            myTable.Columns.Add("Điều kiện", typeof(string));
            myTable.Columns.Add("Limit", typeof(int));
            myTable.Columns.Add("discount", typeof(int));

            for (int i = 2; i <= rows; i++)
            {
                if (Convert.ToString(excelRange.Cells[i, 1].Value2) != null)
                {
                    myNewRow = myTable.NewRow();
                    myNewRow["Name"] = Convert.ToString(excelRange.Cells[i, 1].Value2);
                    myNewRow["Discription"] = Convert.ToString(excelRange.Cells[i, 2].Value2);
                    myNewRow["Mã"] = Convert.ToString(excelRange.Cells[i, 3].Value2);
                    myNewRow["HSD"] = Convert.ToString(excelRange.Cells[i, 4].Value2);
                    myNewRow["Điều kiện"] = Convert.ToString(excelRange.Cells[i, 5].Value2);
                    myNewRow["Limit"] = Convert.ToString(excelRange.Cells[i, 6].Value2);
                    myNewRow["discount"] = Convert.ToString(excelRange.Cells[i, 7].Value2);
                    myTable.Rows.Add(myNewRow);
                }
            }

            excelApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

            return myTable;
        }

        public static void deleteSheet(int sheet)
        {
            string url = Application.StartupPath + "\\DonHang.xlsx";
            ExcelApp.Application excelApp = new ExcelApp.Application();

            ExcelApp.Workbook excelBook = excelApp.Workbooks.Open(@url);
            excelBook.Worksheets[sheet.ToString()].Delete();
        }

        public static void writeExcel(string maDH, List<string> Name, List<int> SoLuong, List<string> giasau,string tamtinh, string giamgia, string tongcong, string ngaydat)
        {
            string filePath = Application.StartupPath + "//DonHang.xlsx";
            ExcelApp.Application excelApp = new ExcelApp.Application();
            ExcelApp.Workbook wb;
            ExcelApp.Worksheet ws;

            wb = excelApp.Workbooks.Open(filePath);
            ws = wb.Worksheets.Add(After:wb.Worksheets[1]);

            ws.Name = maDH;

            ExcelApp.Range excelRange = ws.UsedRange;
            excelRange[1, 1].Value = "Mã đơn hàng";
            excelRange[1, 2].Value = "Name";
            excelRange[1, 3].Value = "Tạm tính";
            excelRange[1, 4].Value = "Giảm giá";
            excelRange[1, 5].Value = "Tổng cộng";
            excelRange[1, 6].Value = "Ngày đặt";
            excelRange[1, 7].Value = "Số lượng";
            excelRange[1, 8].Value = "Giá sau";
            int i = 2;
            excelRange[i, 1].Value = maDH;
            int nameLength = Name.Count;
            for (int j = 2; j <= (nameLength + 1); j++)
            {
                excelRange[j, 1].Value = maDH;
                excelRange[j, 2].Value = Name[j-2];
                excelRange[j, 7].Value = SoLuong[j - 2];
                excelRange[j, 8].Value = giasau[j - 2];
            }
            excelRange[i, 3].Value = tamtinh;
            excelRange[i, 4].Value = giamgia;
            excelRange[i, 5].Value = tongcong;
            excelRange[i, 6].Value = " " + ngaydat;

            wb.Save();
            wb.Close();
        }

        public static DataTable DataSet = ReadExcel("//Data.xlsx");
        public static DataTable UserData = ReadUserExcel("//user.xlsx");
        public static DataTable DiscountData = ReadDiscountExcel("//discount.xlsx");
        //public static DataTable DonHang = ReadDonHangExcel("Sheet1");

        public static List<string> History = new List<string>();
        public static List<string> Liked = new List<string>();
        public static List<string> ChoseItem = new List<string>();
        public static List<int> RandomMa = new List<int>();
        public static string imageLocation = "C://Users//htktd//Desktop//146278798_222524436242376_3546600348139669730_n.jpg";
        public static bool muahang = false;

    }
}
