using System;
using System.Security.Cryptography.X509Certificates;
using OfficeOpenXml;

namespace englishApp
{
    class class_reading_date_from_excel
    {
        public static List<KeyValuePair<string, string>> words_list = new List<KeyValuePair<string, string>>(); // ПЕРЕМЕННАЯ ДЛЯ ХРАНЕНИЯ ПАРЫ СЛОВ ИЗ ЛИСТА

        public static string File_path = @"D:\\metadate\point_system.xlsx";
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
            }
            int chose_name_list = Convert.ToInt32(Console.ReadLine());

            return chose_name_list-1;
        }

        public static void add_words_in_words_list(int chose_name_list)
        {
            using (ExcelPackage package = new ExcelPackage(new FileInfo(File_path)))
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                ExcelWorksheet worksheet = package.Workbook.Worksheets[chose_name_list];

                int row = worksheet.Dimension.Rows;
                
                for(int i = 1; i <= row; i++)
                {
                    KeyValuePair<string, string> pair = new KeyValuePair<string, string>((string)worksheet.Cells[i,1].Value, (string)worksheet.Cells[i,2].Value);
                    words_list.Add(pair);
                }
            }
        }
    }
}
