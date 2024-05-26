using System;
using System.Security.Cryptography.X509Certificates;
using OfficeOpenXml;

namespace englishApp
{
    class class_reading_date_from_excel
    {

        public static string File_path = @"D:\\metadate\point_system.xlsx";
        public static void read_names_lists()
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
            }
        }
    }
}
