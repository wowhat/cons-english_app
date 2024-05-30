using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace englishApp
{
    class class_output_words
    {
        public static Random random = new Random();   
        public static void output_words()
        {
            HashSet<int> unique_numb = new HashSet<int>();

            List<KeyValuePair<string, string>> words_list = class_reading_date_from_excel.words;

            Console.WriteLine($"кол-во слов: {words_list.Count} ");
            
            for (int i = 0; i < words_list.Count; i++)
            {
                int rand_numb = random.Next(0, words_list.Count);

                if (!unique_numb.Contains(rand_numb))
                {
                    while (true)
                    {
                        Console.Write($"{i + 1}. {words_list[rand_numb].Key} \t");

                        string input_word = Console.ReadLine();

                        if (input_word.ToLower().Trim() != words_list[rand_numb].Value.ToLower().Trim())
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
        }
    }
}
