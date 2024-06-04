using System;
using System.Security.Cryptography.X509Certificates;
using OfficeOpenXml;
using OfficeOpenXml.ConditionalFormatting.Contracts;

namespace englishApp
{
    class class_reading_date_from_excel
    {

        public static int chose_list;
        public static List<KeyValuePair<string, string>> words = new List<KeyValuePair<string, string>>();
        public static int read_names_lists()
        {
            using (ExcelPackage package = new ExcelPackage(new FileInfo(class_writing_file_path._file_path)))
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                int count_sheets = 1;

                foreach (ExcelWorksheet worksheet in package.Workbook.Worksheets)
                {
                    Console.WriteLine($"{count_sheets}. {worksheet.Name}");
                    count_sheets++;
                }

                int chose_list = Convert.ToInt32(Console.ReadLine());

                return chose_list - 1;
            }
        }

        public static void read_date_from_list()
        {
            if (File.Exists(class_writing_file_path._file_path))
            {
                using (ExcelPackage package = new ExcelPackage(new FileInfo(class_writing_file_path._file_path)))
                {
                    chose_list = read_names_lists();

                    if(chose_list + 1 == package.Workbook.Worksheets.Count)
                    {
                        read_time();
                    }
                    else
                    {
                        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                        ExcelWorksheet worksheet = package.Workbook.Worksheets[chose_list];

                        int rows = worksheet.Dimension.Rows;

                        for (int i = 1; i <= rows; i++)
                        {
                            KeyValuePair<string, string> pair = new KeyValuePair<string, string>(Convert.ToString(worksheet.Cells[i, 1].Value), Convert.ToString(worksheet.Cells[i, 2].Value));
                            words.Add(pair);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Файл не найден");
                class_start_program.Start_program();
            }
        }
        public static void read_time()
        {
            using (ExcelPackage package = new ExcelPackage(new FileInfo(class_writing_file_path._file_path)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[chose_list];
                int rows = worksheet.Dimension.Rows;
                int columns = worksheet.Dimension.Columns;

                for (int i = 1; i <= rows; i++)
                {
                    for (int j = 1; j <= columns; j++)
                    {
                        Console.Write(worksheet.Cells[i,j].Value + " ");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
            class_repeat.reset();
        }
    }
}
