﻿/*
* PROJECT:          Aura Operating System Development
* CONTENT:          Menus
* PROGRAMMERS:      Valentin Charbonnier <valentinbreiz@gmail.com>   
*/

using System;

namespace Aura_OS.System.Drawable
{
    public class Menu
    {

        /// <summary>
        /// Display a progress bar
        /// </summary>
        public static void DispInstallationDialog(int percent)
        {
            int x = Console.CursorLeft;
            int y = Console.CursorTop;

            if (percent == 0)
            {
                Console.Clear();

                Console.BackgroundColor = ConsoleColor.Blue;

                switch (Kernel.langSelected)
                {
                    case "en_US":
                        Console.SetCursorPosition(8, 8);
                        Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
                        Console.SetCursorPosition(x, y);
                        Console.SetCursorPosition(8, 9);
                        Console.WriteLine("║ Installation in Progress...                                  ║");
                        Console.SetCursorPosition(x, y);

                        break;
                    case "fr_FR":
                        Console.SetCursorPosition(8, 8);
                        Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
                        Console.SetCursorPosition(x, y);
                        Console.SetCursorPosition(8, 9);
                        Console.WriteLine("║ Installation en cours...                                     ║");
                        Console.SetCursorPosition(x, y);
                        break;
                }


                Console.SetCursorPosition(8, 10);
                Console.WriteLine("╠══════════════════════════════════════════════════════════════╣");

                Console.SetCursorPosition(8, 11);
                Console.WriteLine("║                                                              ║");
                Console.SetCursorPosition(x, y);

                Console.SetCursorPosition(8, 12);
                Console.WriteLine("║                                                              ║");
                Console.SetCursorPosition(x, y);

                Console.SetCursorPosition(8, 13);
                Console.WriteLine("║                                                              ║");
                Console.SetCursorPosition(x, y);

                Console.SetCursorPosition(8, 14);
                Console.WriteLine("║                                                              ║");
                Console.SetCursorPosition(x, y);

                Console.SetCursorPosition(8, 15);
                Console.WriteLine("║                                                              ║");
                Console.SetCursorPosition(x, y);

                Console.SetCursorPosition(8, 16);
                Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
                Console.SetCursorPosition(x, y);
            }
            else if (percent == 5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(10, 13);
                Console.WriteLine("###");
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(68, 9);
                Console.WriteLine("5%");
                Console.SetCursorPosition(x, y);
            }
            else if (percent == 10)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(10, 13);
                Console.WriteLine("######");
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(67, 9);
                Console.WriteLine("10%");
                Console.SetCursorPosition(x, y);
            }
            else if (percent == 15)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(10, 13);
                Console.WriteLine("#########");
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(67, 9);
                Console.WriteLine("15%");
                Console.SetCursorPosition(x, y);
            }
            else if (percent == 20)
            {
                Console.SetCursorPosition(10, 13);
                Console.WriteLine("############");
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(67, 9);
                Console.WriteLine("20%");
                Console.SetCursorPosition(x, y);
            }
            else if (percent == 25)
            {
                Console.SetCursorPosition(10, 13);
                Console.WriteLine("###############");
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(67, 9);
                Console.WriteLine("25%");
                Console.SetCursorPosition(x, y);
            }
            else if (percent == 30)
            {
                Console.SetCursorPosition(10, 13);
                Console.WriteLine("##################");
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(67, 9);
                Console.WriteLine("30%");
                Console.SetCursorPosition(x, y);
            }
            else if (percent == 35)
            {
                Console.SetCursorPosition(10, 13);
                Console.WriteLine("#####################");
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(67, 9);
                Console.WriteLine("35%");
                Console.SetCursorPosition(x, y);
            }
            else if (percent == 40)
            {
                Console.SetCursorPosition(10, 13);
                Console.WriteLine("########################");
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(67, 9);
                Console.WriteLine("40%");
                Console.SetCursorPosition(x, y);
            }
            else if (percent == 45)
            {
                Console.SetCursorPosition(10, 13);
                Console.WriteLine("###########################");
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(67, 9);
                Console.WriteLine("45%");
                Console.SetCursorPosition(x, y);
            }
            else if (percent == 50)
            {
                Console.SetCursorPosition(10, 13);
                Console.WriteLine("##############################");
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(67, 9);
                Console.WriteLine("50%");
                Console.SetCursorPosition(x, y);
            }
            else if (percent == 55)
            {
                Console.SetCursorPosition(10, 13);
                Console.WriteLine("#################################");
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(67, 9);
                Console.WriteLine("55%");
                Console.SetCursorPosition(x, y);
            }
            else if (percent == 60)
            {
                Console.SetCursorPosition(10, 13);
                Console.WriteLine("####################################");
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(67, 9);
                Console.WriteLine("60%");
                Console.SetCursorPosition(x, y);
            }
            else if (percent == 65)
            {
                Console.SetCursorPosition(10, 13);
                Console.WriteLine("#######################################");
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(67, 9);
                Console.WriteLine("65%");
                Console.SetCursorPosition(x, y);
            }
            else if (percent == 70)
            {
                Console.SetCursorPosition(10, 13);
                Console.WriteLine("##########################################");
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(67, 9);
                Console.WriteLine("70%");
                Console.SetCursorPosition(x, y);
            }
            else if (percent == 75)
            {
                Console.SetCursorPosition(10, 13);
                Console.WriteLine("#############################################");
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(67, 9);
                Console.WriteLine("75%");
                Console.SetCursorPosition(x, y);
            }
            else if (percent == 80)
            {
                Console.SetCursorPosition(10, 13);
                Console.WriteLine("################################################");
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(67, 9);
                Console.WriteLine("80%");
                Console.SetCursorPosition(x, y);
            }
            else if (percent == 85)
            {
                Console.SetCursorPosition(10, 13);
                Console.WriteLine("###################################################");
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(67, 9);
                Console.WriteLine("85%");
                Console.SetCursorPosition(x, y);
            }
            else if (percent == 90)
            {
                Console.SetCursorPosition(10, 13);
                Console.WriteLine("######################################################");
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(67, 9);
                Console.WriteLine("90%");
                Console.SetCursorPosition(x, y);
            }
            else if (percent == 95)
            {
                Console.SetCursorPosition(10, 13);
                Console.WriteLine("#########################################################");
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(67, 9);
                Console.WriteLine("95%");
                Console.SetCursorPosition(x, y);
            }
            else if (percent == 100)
            {
                Console.SetCursorPosition(10, 13);
                Console.WriteLine("############################################################");
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(66, 9);
                Console.WriteLine("100%");
                Console.SetCursorPosition(x, y);
            }
            else
            {
                Console.SetCursorPosition(10, 12);
                Console.WriteLine("                                                            ");
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        /// <summary>
        /// Display the login form
        /// </summary>
        public static string DispLoginForm(string title)
        {
            Console.Clear();
            int x = Console.CursorLeft;
            int y = Console.CursorTop;

            Console.BackgroundColor = ConsoleColor.Blue;

            Console.SetCursorPosition(8, 8);
            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(x, y);
            Console.SetCursorPosition(8, 9);
            Console.WriteLine("║                                                              ║");
            Console.SetCursorPosition(x, y);
            Console.SetCursorPosition(8, 9);
            Console.WriteLine("║ " + title);
            Console.SetCursorPosition(x, y);
            Console.SetCursorPosition(8, 10);
            Console.WriteLine("╠══════════════════════════════════════════════════════════════╣");
            Console.SetCursorPosition(x, y);
            Console.SetCursorPosition(8, 11);
            Console.WriteLine("║                                                              ║");
            Console.SetCursorPosition(x, y);
            Console.SetCursorPosition(8, 12);
            Console.WriteLine("║ Login:                                                       ║");
            Console.SetCursorPosition(x, y);
            Console.SetCursorPosition(8, 13);
            Console.WriteLine("║                                                              ║");
            Console.SetCursorPosition(x, y);
            Console.SetCursorPosition(8, 14);
            Console.WriteLine("║ Password:                                                    ║");
            Console.SetCursorPosition(x, y);
            Console.SetCursorPosition(8, 15);
            Console.WriteLine("║                                                              ║");
            Console.SetCursorPosition(x, y);
            Console.SetCursorPosition(8, 16);
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
            Console.SetCursorPosition(x, y);

            Console.SetCursorPosition(8, 12);
            Console.Write("║ Login: ");
            string name = Console.ReadLine();
            Console.SetCursorPosition(x, y);
            Console.SetCursorPosition(8, 13);
            Console.WriteLine("║                                                              ║");
            Console.SetCursorPosition(x, y);
            Console.SetCursorPosition(8, 14);
            Console.Write("║ Password: ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Black;
            string password = Console.ReadLine();
            Console.SetCursorPosition(x, y);

            string text = name + "//////" + password;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            return text;
        }

        /// <summary>
        /// Display the error dialog
        /// </summary>
        public static void DispErrorDialog(string error)
        {
            Console.Clear();

            int x = Console.CursorLeft;
            int y = Console.CursorTop;

            Console.BackgroundColor = ConsoleColor.DarkRed;

            Console.SetCursorPosition(8, 11);
            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(x, y);

            Console.SetCursorPosition(8, 12);
            Console.WriteLine("║                                                              ║");
            Console.SetCursorPosition(x, y);

            Console.SetCursorPosition(8, 12);
            Console.WriteLine("║ " + error);
            Console.SetCursorPosition(x, y);

            Console.SetCursorPosition(8, 13);
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
            Console.SetCursorPosition(x, y);

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ReadKey();

            Console.Clear();
        }

        /// <summary>
        /// Display language dialog
        /// </summary>
        public static string DispLanguageDialog()
        {
            Console.Clear();

            int x = Console.CursorLeft;
            int y = Console.CursorTop;

            Console.BackgroundColor = ConsoleColor.Blue;

            Console.SetCursorPosition(8, 8);
            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(x, y);
            Console.SetCursorPosition(8, 9);
            Console.WriteLine("║ Please choose a language: (available: en-US fr-FR)           ║");
            Console.SetCursorPosition(x, y);
            Console.SetCursorPosition(8, 10);
            Console.WriteLine("╠══════════════════════════════════════════════════════════════╣");

            Console.SetCursorPosition(8, 11);
            Console.WriteLine("║                                                              ║");
            Console.SetCursorPosition(x, y);

            Console.SetCursorPosition(8, 12);
            Console.WriteLine("║                                                              ║");
            Console.SetCursorPosition(x, y);

            Console.SetCursorPosition(8, 13);
            Console.WriteLine("║                                                              ║");
            Console.SetCursorPosition(x, y);

            Console.SetCursorPosition(8, 14);
            Console.WriteLine("║                                                              ║");
            Console.SetCursorPosition(x, y);

            Console.SetCursorPosition(8, 15);
            Console.WriteLine("║                                                              ║");
            Console.SetCursorPosition(x, y);

            Console.SetCursorPosition(8, 16);
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
            Console.SetCursorPosition(x, y);

            Console.SetCursorPosition(8, 13);
            Console.Write("║ Language: ");
            string language = Console.ReadLine();
            Console.SetCursorPosition(x, y);

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            return language;
        }

        /// <summary>
        /// Display the computer name dialog
        /// </summary>
        public static string DispCompuernameDialog(string title, string input)
        {
            Console.Clear();

            int x = Console.CursorLeft;
            int y = Console.CursorTop;

            Console.BackgroundColor = ConsoleColor.Blue;

            Console.SetCursorPosition(8, 8);
            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(x, y);
            Console.SetCursorPosition(8, 9);
            Console.WriteLine("║                                                              ║");
            Console.SetCursorPosition(x, y);
            Console.SetCursorPosition(8, 9);
            Console.WriteLine(title);
            Console.SetCursorPosition(x, y);
            Console.SetCursorPosition(8, 10);
            Console.WriteLine("╠══════════════════════════════════════════════════════════════╣");

            Console.SetCursorPosition(8, 11);
            Console.WriteLine("║                                                              ║");
            Console.SetCursorPosition(x, y);

            Console.SetCursorPosition(8, 12);
            Console.WriteLine("║                                                              ║");
            Console.SetCursorPosition(x, y);

            Console.SetCursorPosition(8, 13);
            Console.WriteLine("║                                                              ║");
            Console.SetCursorPosition(x, y);

            Console.SetCursorPosition(8, 14);
            Console.WriteLine("║                                                              ║");
            Console.SetCursorPosition(x, y);

            Console.SetCursorPosition(8, 15);
            Console.WriteLine("║                                                              ║");
            Console.SetCursorPosition(x, y);

            Console.SetCursorPosition(8, 16);
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
            Console.SetCursorPosition(x, y);

            Console.SetCursorPosition(8, 13);
            Console.Write(input);
            string name = Console.ReadLine();
            Console.SetCursorPosition(x, y);

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            return name;
        }

    }
}
