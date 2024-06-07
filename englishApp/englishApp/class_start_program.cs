using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace englishApp
{
    class class_start_program
    {
        public static void Start_program()
        {
            if (!File.Exists(class_writing_file_path.file_path))
            {
                class_writing_file_path.writing();
            }
            class_reading_date_from_excel.read_date_from_list();
            class_output_words.Traning(); 
        }
    }
}
