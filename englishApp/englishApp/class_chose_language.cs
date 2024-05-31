using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace englishApp
{
    class class_chose_language
    {
        public static int chose_language()
        {
            List<string> list_lang = new List<string>() { "ru", "eng" };
            foreach (string lang in list_lang) { Console.WriteLine(lang); }
            
            int chose_lang = Convert.ToInt32(Console.ReadLine());
            return chose_lang;
        }
    }
}
