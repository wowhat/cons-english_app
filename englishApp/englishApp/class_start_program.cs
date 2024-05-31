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
        public static int chose_list = class_reading_date_from_excel.read_names_lists();
        public static void Start_program()
        {
            class_reading_date_from_excel.read_date_from_list(chose_list);
            class_output_words.Traning();
            class_time.time_adding();

        }
    }
}
