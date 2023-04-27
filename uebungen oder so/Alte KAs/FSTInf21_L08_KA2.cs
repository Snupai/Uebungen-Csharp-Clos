using static System.Console;

namespace uebungen_oder_so
{
    internal class FSTInf21_L08_KA2
    {
        internal static void Menu()
        {
            Title = "FSTInf21_L08_KA2 Menu";
            bool zurück = false;
            while (true)
            {
                Clear();
                WriteLine("Press the key to run the according program.");
                WriteLine("-------------------------------------------");
                WriteLine("'1'\tAufgabe 1: Theorie");
                WriteLine("'2'\tAufgabe 2: Theorie");
                WriteLine("'3'\tAufgabe 3: Würfeln");
                WriteLine("'4'\tAufgabe 4: Zahlenraten");
                WriteLine("'5'\tAufgabe 5: Schaltjahr");
                WriteLine("'6'\tAufgabe 6: Funktionstabelle");
                WriteLine("'7'\tAufgabe 7: Verschachtelte Schleifen");
                WriteLine("'0'\tZurück.");
                WriteLine("-------------------------------------------");
                char select = ReadKey().KeyChar;
                switch (select)
                {
                    case '0':
                        zurück = true;
                        break;
                    case '1':
                        Clear();
                        Programm1.Main1();
                        break;
                    case '2':
                        Clear();
                        Programm2.Main1();
                        break;
                    case '3':
                        Clear();
                        Programm3.Main1();
                        break;
                    case '4':
                        Clear();
                        Programm4.Main1();
                        break;
                    case '5':
                        Clear();
                        Programm5.Main1();
                        break;
                    case '6':
                        Clear();
                        Programm6.Main1();
                        break;
                    case '7':
                        Clear();
                        Programm7.Main1();
                        break;
                }
                if (zurück == true) { break; }
            }
        }

        public class Programm1
        {
            public static void Main1()
            {
                WriteLine("Was ist die Ausgabe der folgenden Codeabschnitte?");
                WriteLine("int a = 1;" +
                    "\nint b = 7;" +
                    "\nb = a++;" +
                    "\nWriteLine(++b);" +
                    "\n" +
                    "\nint x = 9;" +
                    "\nint y = 6;" +
                    "\nx %= y;" +
                    "\nWriteLine(x);" +
                    "\n" +
                    "\nint d = 8;" +
                    "\nint e = --d;" +
                    "\nif (d > 8)" +
                    "\n{" +
                    "\n\te = 9;" +
                    "\n}" +
                    "\nelse" +
                    "\n{" +
                    "\n\te -= 3;" +
                    "\n}" +
                    "\nWriteLine(e);" +
                    "\n" +
                    "\nint u = 2;" +
                    "\ndo {" +
                    "\n\tu += 3;" +
                    "\n} while (u< 4);" +
                    "\nWriteLine(u);");
                ReadKey();
                WriteLine("\nDie Ausgaben sind:\n2\n3\n4\n5\n");
                ReadKey();
                WriteLine("\nÜberprüfung:");
                Überprüfung();
                ReadKey();
            }
            static void Überprüfung()
            {
                int a = 1;
                int b = 7;
                b = a++;
                WriteLine(++b);

                int x = 9;
                int y = 6;
                x %= y;
                WriteLine(x);

                int d = 8;
                int e = --d;
                if (d > 8)
                {
                    e = 9;
                }
                else
                {
                    e -= 3;
                }
                WriteLine(e);

                int u = 2;
                do
                {
                    u += 3;
                } while (u < 4);
                WriteLine(u);
            }
        }
        public class Programm2
        {
            public static void Main1()
            {
                WriteLine("Bitte die Lücken füllen, damit der Wert von x fünfmal ausgegeben wird!\n");
                WriteLine("int x = 42;\n" +
                    "int num = 0;\n" +
                    "while (num < _______)\n" +
                    "{\n" +
                    "\tWriteLine(______);\n" +
                    "\t______++;\n" +
                    "}");
                ReadKey();
                WriteLine("\nLösungsansatz:");
                WriteLine("int x = 42;\n" +
                    "int num = 0;\n" +
                    "while (num < 5)\n" +
                    "{\n" +
                    "\tWriteLine(x);\n" +
                    "\tnum++;\n" +
                    "}");
                ReadKey();
                WriteLine("\nAusgabe Lösungsansatz:");
                int x = 42;
                int num = 0;
                while (num < 5)
                {
                    WriteLine(x);
                    num++;
                }
                ReadKey();
            }
        }
        public class Programm3
        {
            static Random rnd = new();
            public static void Main1()
            {
                bool zurück = false;
                while (true)
                {
                    Clear();
                    WriteLine("Press the key to run the according program.");
                    WriteLine("-------------------------------------------");
                    WriteLine("'1'\ta): 5mal Würfeln und Summe aus Augen.");
                    WriteLine("'2'\tb): Wie oft Augenzahl bei 1.000.000 würfen.");
                    WriteLine("'0'\tZurück.");
                    WriteLine("-------------------------------------------");
                    char select = ReadKey().KeyChar;
                    switch (select)
                    {
                        case '0':
                            zurück = true;
                            break;
                        case '1':
                            Clear();
                            AufgabeA();
                            break;
                        case '2':
                            Clear();
                            AufgabeB();
                            break;
                    }
                    if (zurück == true) { break; }
                }
            }
            static void AufgabeA()
            {
                WriteLine($"Die Summe der Augen bei den 5 Würfen beträgt {Würfel5mal()}.");
                ReadKey();
            }
            static int Würfel5mal()
            {
                int[] würfe = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    würfe[i] = rnd.Next(1, 6 + 1);
                }
                return würfe.Sum(x => x);

            }
            static void AufgabeB()
            {
                var würfe = VielWürfeln();
                for (int i = 1; i <= 6; i++)
                {
                    WriteLine($"Die Zahl {i} kommt {WieOft(würfe, i):N0}mal vor.");
                }
                ReadKey();
            }
            static int WieOft(List<int> list, int augen)
            {
                return list.Count(x => x == augen); ;
            }
            static List<int> VielWürfeln()
            {
                List<int> list = new();
                for (int i = 0; i < 1_000_000; i++)
                {
                    list.Add(rnd.Next(1, 6 + 1));
                }
                list.Sort();
                return list;
            }
        }
        public class Programm4
        {
            public static void Main1()
            {
                WriteLine("Zahlen Raten:");
                int zahlGuess;
                var i = 0;
                var rndZahl = RandomNumber();
                while (true)
                {
                    i++;
                    while (true)
                    {
                        WriteLine("\nGebe eine Zahl ein (1-30):");
                        var guess = ReadLine();
                        try { zahlGuess = Convert.ToInt32(guess); if (zahlGuess >= 1 && zahlGuess <= 30) { break; } } catch (Exception e) { WriteLine($"{e.Message}", ForegroundColor = ConsoleColor.Red); ForegroundColor = ConsoleColor.White; }
                    }
                    if (zahlGuess == rndZahl)
                    {
                        WriteLine($"Du hast die Zahl {rndZahl} richtig erraten.\nDu hast {i} Versuche gebraucht.");
                        Write("Neues Spiel? 'j'/'n' ");
                        if (ReadKey().KeyChar != 'j')
                        {
                            break;
                        }
                        else
                        {
                            WriteLine();
                            Main1();
                            break;
                        }
                    }
                    else if (zahlGuess > rndZahl)
                    {
                        WriteLine("Die gesuchte Zahl ist niedriger.");
                    }
                    else
                    {
                        WriteLine("Die gesuchte Zahl ist größer.");
                    }
                    WriteLine("\n----------------------------------------------");
                }
            }
            static int RandomNumber()
            {
                var rnd = new Random();
                return rnd.Next(1, 30 + 1);
            }
        }
        public class Programm5
        {
            public static void Main1()
            {
                List<int> schlatJahre = new();
                for (int i = 1600; i <= 2000; i++)
                {
                    if (IstSchaltjahr(i)) { WriteLine($"{i} ist ein Schaltjahr."); schlatJahre.Add(i); }
                }
                WriteLine($"\nVon 1600-2000 gab es {schlatJahre.Count} Schaltjahre.");
                ReadKey();
            }
            static bool IstSchaltjahr(int jahr)
            {
                if (jahr % 400 == 0) { return true; }
                if (jahr % 100 == 0) { return false; }
                if (jahr % 4 == 0) { return true; }
                return false;
            }
        }
        public class Programm6
        {
            public static void Main1()
            {
                ForegroundColor = ConsoleColor.Cyan;
                BackgroundColor = ConsoleColor.DarkBlue;
                Clear();
                WriteLine();
                int basis;
                int von;
                int bis;
                var test = WindowWidth;
                SetCursorPosition(WindowWidth / 2 - 9, CursorTop);
                WriteLine("Potenzen berechnen\n", ForegroundColor = ConsoleColor.Green, BackgroundColor = ConsoleColor.DarkRed);
                BackgroundColor = ConsoleColor.DarkBlue;
                Write("Im folgenden können die Potenzen zu einer ", ForegroundColor = ConsoleColor.Cyan);
                Write("Basis B", ForegroundColor = ConsoleColor.Red);
                Write(" berechnet werden. Es wird dann eine Tabelle von ", ForegroundColor = ConsoleColor.Cyan);
                Write("von", ForegroundColor = ConsoleColor.Red);
                Write(" bis ", ForegroundColor = ConsoleColor.Cyan);
                Write("bis", ForegroundColor = ConsoleColor.Red);
                WriteLine(" ausgegeben.\n", ForegroundColor = ConsoleColor.Cyan);
                WriteLine("Bitte geben Sie ein (Enter übernimmt Standardwerte!)", ForegroundColor = ConsoleColor.Cyan);
                Write("Basis B: ", ForegroundColor = ConsoleColor.Cyan);
                ForegroundColor = ConsoleColor.Red;
                try { basis = Convert.ToInt32(ReadLine()); } catch { basis = 4; }
                Write("von: ", ForegroundColor = ConsoleColor.Cyan);
                ForegroundColor = ConsoleColor.Red;
                try { von = Convert.ToInt32(ReadLine()); } catch { von = 0; }
                Write("bis: ", ForegroundColor = ConsoleColor.Cyan);
                ForegroundColor = ConsoleColor.Red;
                try { bis = Convert.ToInt32(ReadLine()); } catch { bis = 6; }
                WriteLine($"\nExponent  |  {basis}^Exponent", ForegroundColor = ConsoleColor.Cyan);
                WriteLine(new string('-', 30));
                int count = Convert.ToInt32(Math.Pow(basis, bis));
                for (int i = von; i <= bis; i++)
                {
                    var erg = Math.Pow(basis, i);
                    WriteLine($"{i.ToString().PadLeft(8)}  |  {erg.ToString("N0").PadLeft(count.ToString("N0").Length)}");
                }
                ReadKey();
                BackgroundColor = ConsoleColor.Black;
                ForegroundColor = ConsoleColor.White;
            }
        }
        public class Programm7
        {
            public static void Main1()
            {
                WriteLine("Hell nah!");
                ReadKey();
            }
        }
    }
}
