using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using OfficeOpenXml;
using OfficeOpenXml.ConditionalFormatting.Contracts;

namespace englishApp
{
    class class_time
    {
        public static void time_adding()
        {
            string File_Path = class_reading_date_from_excel.File_path; // путь к excel файлу
            int chose_list = class_start_program.chose_list; // переменная с выбором листа

            using (ExcelPackage package = new ExcelPackage(new FileInfo(File_Path)))
            {

                ExcelWorksheet worksheet = package.Workbook.Worksheets[chose_list];

                TimeSpan ts = class_output_words.stop_watch.Elapsed;  // получение объекта типа timeSpan
                string times = string.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds); // форматировани объекта в удобный вид

                Console.WriteLine($"Затраченное время на прохождение данного словаря : {times} . . . ");
                Console.ReadLine();

                if (worksheet.Cells[1,4].Value == null) {worksheet.Cells[1, 4].Value = 2;}
                // проверка на нулевое значение ячейки "если да : запись номера строки для определения в какую ячейку записывать время "
                if (worksheet.Cells[1, 3].Value == null) { worksheet.Cells[1, 3].Value = "my time"; } // проверка на нулевое значение ячейки "если да : запись для представления что будет в столбце" 
                int val_D = Convert.ToInt32(worksheet.Cells[1, 4].Value); // переменная для хранения номера строки куда будет записано время
                worksheet.Cells[val_D, 3].Value = times; // запись времени в ячейку
                val_D++; // инкремент специальной переменной которая хранит номер строки
                worksheet.Cells[1,4].Value = val_D; // сохранение переменной в ячейку
                package.Save(); // сохрание обновленных данных для excel файла
            }
        }
    }
}
