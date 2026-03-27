namespace Days_until_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                bool running = true;

                while (running)
                {
                    Console.Clear();
                    Console.WriteLine("=== Days Until Calculator ===");
                    Console.WriteLine();
                    Console.WriteLine("1 - Tage bis zu einem Datum");
                    Console.WriteLine("2 - Tage bis zum nächsten Geburtstag");
                    Console.WriteLine("0 - Beenden");
                    Console.WriteLine();

                    Console.Write("Auswahl: ");
                    bool isValid = int.TryParse(Console.ReadLine(), out int choice);

                    if (!isValid)
                    {
                        Console.WriteLine("Bitte eine Zahl zwischen 0 und 2 eingeben.");
                        Pause();
                    }
                    else
                    {
                        switch (choice)
                        {
                            case 1:
                                {
                                    Console.Write("Datum eingeben (dd.MM.yyyy): ");
                                    string input = Console.ReadLine();

                                    if (DateTime.TryParse(input, out DateTime targetDate))
                                    {
                                        DateTime today = DateTime.Today;
                                        TimeSpan diff = targetDate - today;

                                        Console.WriteLine($"Heute: {today:dd.MM.yyyy}");
                                        Console.WriteLine($"Zieldatum: {targetDate:dd.MM.yyyy}");
                                        Console.WriteLine();

                                        Console.WriteLine($"Noch {diff.Days} Tage.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ungültiges Datum.");
                                    }
                                }

                                Pause();
                                break;
                            case 2:
                                {
                                    Console.Write("Geburtsdatum eingeben (dd.MM.yyyy): ");
                                    string input = Console.ReadLine();

                                    if (DateTime.TryParse(input, out DateTime birthDate))
                                    {
                                        DateTime nextBirthday = new DateTime(DateTime.Today.Year, birthDate.Month, birthDate.Day);

                                        if (nextBirthday < DateTime.Today)
                                        {
                                            nextBirthday = nextBirthday.AddYears(1);
                                        }

                                        TimeSpan diff = nextBirthday - DateTime.Today;

                                        Console.WriteLine($"Nächster Geburtstag: {nextBirthday:dd.MM.yyyy}");
                                        Console.WriteLine($"Noch {diff.Days} Tage.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ungültiges Datum.");
                                    }

                                }
                                Pause();
                                break;
                            case 0:
                                Console.WriteLine("Programm beendet.");
                                Console.ReadKey();
                                running = false;
                                break;

                            default:
                                Console.WriteLine("Ungültige Eingabe.");
                                Pause();
                                break;
                        }

                    }
                    Console.Clear();
                }
            }

        }

        static void Pause()
        {
            Console.WriteLine();
            Console.WriteLine("Eine beliebige Taste drücken um zurück zum Menü zu gehen...");
            Console.ReadKey();
        }
    }
}