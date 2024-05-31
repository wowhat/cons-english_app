using System;
using System.Security.Cryptography.X509Certificates;
using OfficeOpenXml;
using OfficeOpenXml.ConditionalFormatting.Contracts;

namespace englishApp
{
    class class_reading_date_from_excel
    {

        public static string File_path = @"D:\\metadate\point_system.xlsx";
        //public static string File_path_laptop = @"C:\\metadate\point_system_test.xlsx";
        public static List<KeyValuePair<string, string>> words = new List<KeyValuePair<string, string>>();
        public static int read_names_lists()
        {
            using (ExcelPackage package = new ExcelPackage(new FileInfo(File_path)))
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;  
                
                int count_sheets = 1;

                foreach(ExcelWorksheet worksheet in package.Workbook.Worksheets)
                {
                    Console.WriteLine($"{count_sheets}. {worksheet.Name}");
                    count_sheets++;
                }

                int chose_list = Convert.ToInt32(Console.ReadLine());

                return chose_list - 1;
            }
        }

        public static void read_date_from_list(int chose_list)
        {
            using (ExcelPackage package = new ExcelPackage(new FileInfo(File_path)))
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                ExcelWorksheet worksheet = package.Workbook.Worksheets[chose_list];

                int rows = worksheet.Dimension.Rows;

                for (int i = 1; i <= rows; i++)
                {
                    KeyValuePair<string, string> pair = new KeyValuePair<string, string>(Convert.ToString(worksheet.Cells[i,1].Value), Convert.ToString(worksheet.Cells[i,2].Value));
                    words.Add(pair);
                } 
            }
        }
    }
}
