using System;
namespace englishApp
{
    class class_writing_file_path
    {
        public static string file_path { get; set; }
        public static void writing()
        {
            Console.Write("file_path: ");
            file_path = Console.ReadLine();
        }
    }
}
