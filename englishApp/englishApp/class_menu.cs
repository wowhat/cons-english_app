﻿using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace englishApp
{
    class class_menu
    {
        public static void menu()
        {
            Console.WriteLine($"1.Start \n2.Time \n0.Exit");
            int menu_choice = Convert.ToInt32(Console.ReadLine());

            switch (menu_choice)
            {
                case 1: Start();  break;
                case 2: Time(); break;
                case 0: Exit();  break;
            }
        }

        public static void Start()
        {
            class_reading_date_from_excel.read_names_lists();
        }
        public static void Time()
        {
            Console.WriteLine("Time");
        }
        public static void Exit()
        {
            Environment.Exit(0);
        }



    }
}