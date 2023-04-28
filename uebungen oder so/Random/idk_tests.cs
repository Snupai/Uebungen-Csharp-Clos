using static System.Console;

namespace uebungen_oder_so
{
    internal class idk_tests
    {
        internal static void Menu()
        {
            Title = "Random tests Menu";
            bool zurück = false;
            while (true)
            {
                Clear();
                WriteLine("Press the key to run the according program.");
                WriteLine("-------------------------------------------");
                WriteLine("'1'\t6 aus 49.");
                WriteLine("'2'\tZahlen raten.");
                WriteLine("'3'\tZahlen erraten lassen.");
                WriteLine("'4'\tRechteck scheiß.");
                WriteLine("'5'\t1mal1 is 3.");
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
                        Programm6.Menu();
                        break;
                }
                if (zurück == true) { break; }
            }
        }

        class Programm1
        {
            public static void Main1()
            {
                foreach (var zahl in ZahlenZiehen(ListeErstellen()))
                {
                    WriteLine($"{zahl}", ForegroundColor = ConsoleColor.Green);
                }
                ForegroundColor = ConsoleColor.White;
                ReadKey();
            }
            static List<int> ListeErstellen()
            {
                List<int> zahlen = new();
                for (int i = 1; i < 50; i++)
                {
                    zahlen.Add(i);
                }
                return zahlen;
            }

            static int[] ZahlenZiehen(List<int> zahlen)
            {
                List<int> lotto = new();
                for (int i = 0; i < 6; i++)
                {
                    Random rnd = new();
                    var zahl = zahlen[rnd.Next(zahlen.Count)];
                    lotto.Add(zahl);
                    zahlen.Remove(zahl);
                }
                zahlen.Clear();
                return lotto.ToArray();
            }
        }
        class Programm2
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
                        WriteLine("\nGebe eine Zahl zwischen 0 und 100 ein:");
                        var guess = ReadLine();
                        try { zahlGuess = Convert.ToInt32(guess); if (zahlGuess >= 0 && zahlGuess <= 100) { break; } } catch (Exception e) { WriteLine($"{e.Message}", ForegroundColor = ConsoleColor.Red); ForegroundColor = ConsoleColor.White; }
                    }
                    if (zahlGuess == rndZahl)
                    {
                        WriteLine($"Du hast die Zahl {rndZahl} richtig erraten.\nDu hast {i} Versuche gebraucht.");
                        break;
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
                ReadKey();
            }
            static int RandomNumber()
            {
                var rnd = new Random();
                return rnd.Next(0, 100 + 1);
            }
        }
        class Programm3
        {
            public static void Main1()
            {
                WriteLine("Zahlen Raten lassen:");
                int rndZahl;
                while (true)
                {
                    WriteLine("\nGebe eine Zahl zwischen 0 und 100 ein:");
                    var rndInput = ReadLine();
                    try { rndZahl = Convert.ToInt32(rndInput); if (rndZahl >= 0 && rndZahl <= 100) { break; } } catch (Exception e) { WriteLine($"{e.Message}", ForegroundColor = ConsoleColor.Red); ForegroundColor = ConsoleColor.White; }
                }
                ZahlErraten(rndZahl);
                ReadKey();
            }
            static void ZahlErraten(int rndZahl)
            {
                List<int> guessed = new();
                var i = 0;
                var zahlGuess = 100;
                zahlGuess /= 2;
                var leZahl = zahlGuess;
                guessed.Add(zahlGuess);
                while (true)
                {
                    WriteLine($"\nGuessed: {zahlGuess}");
                    i++;
                    if (zahlGuess == rndZahl)
                    {
                        WriteLine($"Deine Zahl ist {rndZahl}.\nIch habe {i} Versuche gebraucht sie zu erraten.");
                        break;
                    }
                    else if (zahlGuess > rndZahl)
                    {
                        WriteLine("Die gesuchte Zahl ist niedriger.");
                        leZahl = leZahl / 2;
                        zahlGuess = zahlGuess - leZahl;
                        if (guessed.Contains(zahlGuess)) zahlGuess -= 1;
                        guessed.Add(zahlGuess);
                    }
                    else
                    {
                        WriteLine("Die gesuchte Zahl ist größer.");
                        leZahl = leZahl / 2;
                        zahlGuess = zahlGuess + leZahl;
                        if (guessed.Contains(zahlGuess)) zahlGuess += 1;
                        guessed.Add(zahlGuess);
                    }
                }
            }
        }
        class Programm4
        {
            public static void Main1()
            {
                WriteLine("Gebe Koordinaten an.\tExample: '6,1'");
                string pointIn = ReadLine();
                if (pointIn == "") { pointIn = "1,1"; }
                string[] point = pointIn.Split(",");
                int z = Convert.ToInt16(point[0]);
                int u = Convert.ToInt16(point[1]);

                if (IsPointInRectangle1(z, u) && IsPointInRectangle2(z, u)) { WriteLine("JA GEIL BEIDE!!!"); }
                else if (IsPointInRectangle1(z, u)) { WriteLine("JA GEIL 0"); }
                else if (IsPointInRectangle2(z, u)) { WriteLine("JA GEIL 1"); }
                else { WriteLine("JA NEIN"); }
                ReadKey();
            }
            static bool IsPointInRectangle1(int x, int y)
            {
                if (x >= -2 && x <= 6)
                    return y >= 1 && y <= 7;
                return false;
            }
            static bool IsPointInRectangle2(int x, int y)
            {
                if (x >= -6 && x <= 2)
                    return y >= -2 && y <= 3;
                return false;
            }
        }
        class Programm5
        {
            public static void Main1()
            {
                Console.Title = "NÄHER!";
                //Console.SetWindowSize(85, 22);
                //Console.SetBufferSize(WindowWidth, WindowHeight);

                var o = 0;
                var k = 1;
                for (int i = 0; i < 11; i++)
                {
                    for (int j = 0; j < 11; j++)
                    {
                        var res = i * j;
                        if (i == 0)
                        {
                            var geg = o++ * 1;
                            if (geg >= 1)
                            {
                                Write($"{geg.ToString().PadLeft(3)}", ForegroundColor = ConsoleColor.Red);
                                Write(" |\t", ForegroundColor = ConsoleColor.White);
                            }
                            else
                            {
                                Write("\t");
                            }
                        }
                        else if (j == 0 && i >= 1)
                        {
                            var geg = k++ * 1;
                            Write($"{geg.ToString().PadLeft(3)}", ForegroundColor = ConsoleColor.Red);
                            Write(" |\t", ForegroundColor = ConsoleColor.White);
                        }

                        else if (i >= 1 || j >= 1)
                        {
                            Write($"{res.ToString().PadLeft(3)}", ForegroundColor = ConsoleColor.Green);
                            Write(" |\t", ForegroundColor = ConsoleColor.White);
                        }
                    }
                    WriteLine();
                    Write(new string('-', 85));
                    WriteLine();
                }
                ReadKey();
            }
        }
        class Programm6
        {
            static List<String> topics = new();
            internal static void Menu()
            {
                Title = "Random tests Menu";
                bool zurück = false;
                while (true)
                {
                    Clear();
                    WriteLine("Press the key to run the according program.");
                    WriteLine("-------------------------------------------");
                    WriteLine("'1'\tEingabe von Topics.");
                    WriteLine("'2'\tAnsicht der Topics.");
                    WriteLine("'3'\tTopics löschen.");
                    WriteLine("'4'\tBearbeiten abändern.");
                    WriteLine("'5'\tSortieren.");
                    WriteLine("'6'\tRangfolge");
                    WriteLine("'7'\tTesting");
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
                            Eingabe();
                            break;
                        case '2':
                            Clear();
                            Ansicht();
                            break;
                        case '3':
                            Clear();
                            Löschen();
                            break;
                        case '4':
                            Clear();
                            Bearbeiten();
                            break;
                        case '5':
                            Clear();
                            Sortieren();
                            break;
                        case '6':
                            Clear();
                            Rangfolge();
                            break;
                        case '7':
                            Clear();
                            Test();
                            break;
                    }
                    if (zurück == true) { break; }
                }
            }
            static void Eingabe()
            {
                while (true)
                {
                    WriteLine("\bGebe ein Topic ein um es der Liste hinzuzufügen:");
                    topics.Add(ReadLine());
                    WriteLine("Topic wurde hinzugefügt. Möchten Sie ein weiteres Topic eingeben? 'j'/'n'");
                    if (ReadKey().KeyChar != 'j') { break; }
                }
            }
            static void Ansicht()
            {
                foreach (var item in topics)
                {
                    WriteLine(item);
                }
                ReadKey();
            }
            static void Löschen()
            {
                ReadKey();
            }
            static void Bearbeiten()
            {
                ReadKey();
            }
            static void Sortieren()
            {
                ReadKey();
            }
            static void Rangfolge()
            {
                ReadKey();
            }
            static void Test()
            {
                ReadKey();
            }
        }
    }
}
