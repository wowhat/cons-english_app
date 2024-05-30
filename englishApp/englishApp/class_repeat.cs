using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace englishApp
{
    class class_repeat
    {
        public static void date_reset()
        {
            class_reading_date_from_excel.words.Clear();
            Console.Clear();
            class_menu.menu();
        }
    }
}
