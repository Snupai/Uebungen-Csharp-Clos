using static System.Console;
using static Yann.wc;

namespace uebungen_oder_so
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu() 
        {
            BackgroundColor = ConsoleColor.Black;
            ForegroundColor = ConsoleColor.White;
            while (true)
            {
                Title = "Main Menu";
                Clear();
                WriteLine("Press the key to run the according program.");
                WriteLine("-------------------------------------------");
                WriteLine("'1'\tidk tests.");
                WriteLine("'2'\tFSTAuP09_PD6_KA3");
                WriteLine("'3'\tFSTInf21_L08_KA2");
                WriteLine("'0'\tProgramm beenden.");
                WriteLine("-------------------------------------------");
                char select = ReadKey().KeyChar;
                switch (select)
                {
                    case '0':
                        Write("\b");
                        Environment.Exit(42);
                        break;
                    case '1':
                        Clear();
                        idk_tests.Menu();
                        break;
                    case '2':
                        Clear();
                        FSTAuP09_PD6_KA3.Menu();
                        break;
                    case '3':
                        Clear();
                        FSTInf21_L08_KA2.Menu();
                        break;
                    case 'f':
                        Clear();
                        WriteLine("Fun Fact\n\nDie Zahl 86 steht für 32-Bit, weil der Intel 8086-Prozessor der erste 16-Bit-Prozessor war und die Nachfolger des Intel 8086-Prozessors 32-Bit-Prozessoren waren.");
                        ReadKey();
                        break;
                    case 't':
                        Clear();
                        Test();
                        break;
                }
            }
        }
        static void Test()
        {
            Title = "Test Test Test Test Test Test Test Test Test Test Test Test Test Test Test";
            //
            // This program demonstrates all colors and backgrounds.
            //
            Type type = typeof(ConsoleColor);
            ForegroundColor = ConsoleColor.White;
            foreach (var name in Enum.GetNames(type))
            {
                BackgroundColor = (ConsoleColor)Enum.Parse(type, name);
                WriteLine(name);
            }
            BackgroundColor = ConsoleColor.Black;
            foreach (var name in Enum.GetNames(type))
            {
                ForegroundColor = (ConsoleColor)Enum.Parse(type, name);
                WriteLine(name);
            }

            //
            // This is an example to show you how to you WriteColor or WriteLineColor
            //
            WriteLineColor("\nYou can see all possible colors above!\nThis is an example string for <*!red*>background color<*/!*> and <*red*>foreground color<*/*>.");
            ReadKey();
        }
    }
}