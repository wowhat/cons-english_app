using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace englishApp
{
    class class_output_words
    {
        public static Stopwatch stop_watch = new Stopwatch();
        public static Random random = new Random();
        public static void Traning()
        {
            int chose_lang = class_chose_language.chose_language();
            switch (chose_lang)
            {
                case 1: output_words(false); break;
                case 2: output_words(true); break;
            }
        }
        public static void output_words(bool isEnglish)
        {
            HashSet<int> unique_numb = new HashSet<int>();


            List<KeyValuePair<string, string>> words_list = class_reading_date_from_excel.words;
            //int chose_lang = class_chose_language.chose_language();
            
            Console.WriteLine($"кол-во слов: {words_list.Count} ");
            
            for (int i = 0; i < words_list.Count; i++)
            {
                stop_watch.Start();
                int rand_numb = random.Next(0, words_list.Count);

                if (!unique_numb.Contains(rand_numb))
                {
                    
                    while (true)
                    {
                        if (isEnglish)
                        {
                            Console.Write($"{i + 1}. {words_list[rand_numb].Key} \t");
                        }
                        else
                        {
                            Console.Write($"{i + 1}. {words_list[rand_numb].Value} \t");
                        }

                        string input_word = Console.ReadLine();

                        if (isEnglish && input_word.ToLower().Trim() == words_list[rand_numb].Value.ToLower().Trim() || !isEnglish && input_word.ToLower().Trim() == words_list[rand_numb].Key.ToLower().Trim())
                        {
                            unique_numb.Add(rand_numb);
                            break;
                        }
                    }
                }
                else
                {
                    i--;
                }
            }
            stop_watch.Stop();
            class_time.time_adding();
            class_repeat.date_reset();
        }
    }
}
