using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace englishApp
{
    class class_start_program
    {
        public static void Start()
        {
            int chose_name_list = class_reading_date_from_excel.read_names_lists();
            class_reading_date_from_excel.add_words_in_words_list(chose_name_list);
            class_main_part_program.out_words();
        }
    }
}
