using System;
namespace englishApp
{
    class class_writing_file_path
    {
        public static string _file_path { get; set; }
        public static void writing()
        {
            Console.Write("file_path: ");
            _file_path = Console.ReadLine();
        }
    }
}
