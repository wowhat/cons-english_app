﻿using System;
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
            List<KeyValuePair<string, string>> words_list = class_reading_date_from_excel.words;
            //int chose_lang = class_chose_language.chose_language();
            int i = 1;
            Console.WriteLine($"кол-во слов: {words_list.Count} ");

            while (words_list.Count > 0)
            {
                int rand_numb = random.Next(0, words_list.Count);

                while (true)
                {
                    if (isEnglish)
                    {
                        Console.Write($"{i}. {words_list[rand_numb].Key} \t");
                    }
                    else
                    {
                        Console.Write($"{i}. {words_list[rand_numb].Value} \t");
                    }

                    string input_word = Console.ReadLine();

                    if (isEnglish && input_word.ToLower().Trim() == words_list[rand_numb].Value.ToLower().Trim() || !isEnglish && input_word.ToLower().Trim() == words_list[rand_numb].Key.ToLower().Trim())
                    {
                        i++;
                        words_list.RemoveAt(rand_numb);
                        break;
                    }
                }
            }
            class_repeat.reset();
        }
    }
}
