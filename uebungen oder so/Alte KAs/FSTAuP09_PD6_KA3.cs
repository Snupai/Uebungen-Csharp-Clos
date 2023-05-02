using static System.Console;

namespace uebungen_oder_so
{
    internal class FSTAuP09_PD6_KA3
    {
        internal static void Menu()
        {
            Title = "FSTAuP09_PD6_KA3 Menu";
            bool zurück = false;
            while (true)
            {
                Clear();
                WriteLine("Press the key to run the according program.");
                WriteLine("-------------------------------------------");
                WriteLine("'1'\tAufgabe 1: Wertetabelle und Summe der Zahlen");
                WriteLine("'2'\tAufgabe 2: Würfeln");
                WriteLine("'3'\tAufgabe 3: Body-Mass-Index");
                WriteLine("'4'\tAufgabe 4: Verschachtelte Schleifen");
                WriteLine("'5'\tAufgabe 5: Zahlenraten");
                WriteLine("'6'\tAufgabe 6: Kreuze suchen");
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
                }
                if (zurück == true) { break; }
            }
        }
        public class Programm1
        {
            public static void Main1()
            {
                double erg;
                for (int i = 0; i < 9; i++)
                {
                    erg = Math.Pow(2, i);
                    WriteLine($"2^{i} = {erg.ToString().PadLeft(3)}");
                }
                ReadKey();
            }
        }
        public class Programm2
        {
            public static void Main1()
            {
                int[] counts = CheckList(RandomList());
                WriteLine($"Die Zahlen -7 bis -3 gibt es {counts[0]}mal. Das sind {RelativeMenge(counts[0]):N2}% der Zahlen.");
                WriteLine($"Die Zahlen -2 bis +2 gibt es {counts[1]}mal. Das sind {RelativeMenge(counts[1]):N2}% der Zahlen.");
                WriteLine($"Die Zahlen +3 bis +7 gibt es {counts[2]}mal. Das sind {RelativeMenge(counts[2]):N2}% der Zahlen.");
                ReadKey();
            }
            static List<int> RandomList()
            {
                List<int> list = new();
                Random rnd = new();
                for (int i = 0; i <= 5 * Math.Pow(10, 6); i++)
                {
                    list.Add(rnd.Next(-7, 7 + 1));
                }
                list.Sort();
                return list;
            }
            static int[] CheckList(List<int> list)
            {
                int[] actualCount = new int[3];
                List<int> countAmKleinsten = new();
                List<int> countMitte = new();
                List<int> countAmGrößten = new();
                foreach (int n in list)
                {
                    if (n <= -3)
                    {
                        countAmKleinsten.Add(n);
                    }
                    else if (n >= 3)
                    {
                        countAmGrößten.Add(n);
                    }
                    else
                    {
                        countMitte.Add(n);
                    }
                }
                actualCount[0] = countAmKleinsten.Count;
                actualCount[1] = countMitte.Count;
                actualCount[2] = countAmGrößten.Count;
                countAmKleinsten.Clear();
                countMitte.Clear();
                countAmGrößten.Clear();
                return actualCount;
            }
            static double RelativeMenge(int count)
            {
                return (100.0 / 5_000_000) * count;
            }
        }
        public class Programm3
        {
            public static void Main1()
            {
                while (true)
                {
                    double gewicht = 0;
                    double größe = 0;
                    Write("Geben Sie ihr Gewicht in kg an: ");
                    try { gewicht = Convert.ToDouble(ReadLine()); } catch (Exception e) { Clear(); WriteLine("Falsche Eingabe bitte gebe nur Ganzzahlen oder Kommazahlen an."); }
                    Write("\nGeben Sie ihre Größe in m an: ");
                    try { größe = Convert.ToDouble(ReadLine()); } catch (Exception e) { Clear(); WriteLine("Falsche Eingabe bitte gebe nur Ganzzahlen oder Kommazahlen an."); }
                    Clear();
                    WriteLine($"Ihr BMI ist {BMIBerechnen(gewicht, größe):N2}\n\nMöchten Sie eine weitere berechnung durchführen? 'ja' oder 'nein'");
                    var eingabe = ReadLine();
                    if (eingabe != "ja")
                    {
                        break;
                    }
                    else
                    {
                        Clear();
                    }
                }
            }
            static double BMIBerechnen(double gewicht, double größe)
            {
                return gewicht / Math.Pow(größe, 2);
            }
        }
        public class Programm4
        {
            public static void Main1()
            {
                WriteLine("Hell nah!");
                ReadKey();
            }

        }
        public class Programm5
        {
            public static void Main1()
            {
                List<int> guessed = new();
                WriteLine("Zahlen Raten:");
                int zahlGuess;
                var i = 0;
                var rndZahl = RandomNumber();
                while (true)
                {
                    i++;
                    while (true)
                    {
                        Write("Gebe eine Zahl zwischen 0 und 20 ein: ");
                        var guess = ReadLine();
                        try
                        {
                            zahlGuess = Convert.ToInt32(guess);
                            if (zahlGuess >= 0 && zahlGuess <= 20)
                            {
                                guessed.Add(zahlGuess);
                                Write("Die bisherigen Zahlen waren:");
                                foreach (var gue in guessed)
                                {
                                    Write($" {gue}");
                                }
                                WriteLine();
                                break;
                            }
                        }
                        catch (Exception e)
                        {
                            WriteLine($"{e.Message}",ForegroundColor=ConsoleColor.Red);
                            ForegroundColor = ConsoleColor.White;
                        }
                    }
                    if (zahlGuess == rndZahl)
                    {
                        WriteLine($"\nDu hast die Zahl {rndZahl} richtig erraten.\nDu hast {i} Versuche gebraucht.\nDeine geratenen Zahlen waren:");
                        for (int j = 1; j <= guessed.Count; j++)
                        {
                            WriteLine($"{j}. Versuch: {guessed[j - 1]}");
                        }
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
                }
                ReadKey();
            }
            static int RandomNumber()
            {
                var rnd = new Random();
                return rnd.Next(0, 20 + 1);
            }
        }
        public class Programm6
        {
            public static void Main1()
            {
                WriteLine("Hell nah!");
                ReadKey();
            }
        }
    }
}