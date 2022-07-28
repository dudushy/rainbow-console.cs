namespace RainbowConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            RainbowGenerator("ask");
        }

        static void RainbowGenerator(string mode)
        {
            mode = mode.ToLower();
            Console.WriteLine($"[RainbowGenerator] RUN --{mode}");

            string[] availableModes = { "both", "back", "fore", "all" };
            string space = "[RainbowGenerator]\n";
            string text = "";

            switch (mode)
            {
                case "ask":
                    Console.WriteLine($"{space}[RainbowGenerator] /---------------------= Available Mode =---------------------\\");
                    Console.WriteLine($"{space}[RainbowGenerator] - BOTH (Change background and foreground colors) ");
                    Console.WriteLine($"{space}[RainbowGenerator] - BACK (Change background color) ");
                    Console.WriteLine($"{space}[RainbowGenerator] - FORE (Change foreground color) ");
                    Console.WriteLine($"{space}[RainbowGenerator] - ALL (Change background and foreground with all colors) ");
                    Console.WriteLine($"{space}[RainbowGenerator] \\------------------------------------------------------------/");
                    Console.Write($"{space}[RainbowGenerator] Select Rainbow Mode: ");
                    text = Console.ReadLine();
                    if (availableModes.Any(text.Contains))
                    {
                        Console.Write(space);
                        RainbowGenerator(text);
                    }
                    else
                    {
                        Console.Write(space);
                        RainbowGenerator("fail");
                    }
                    
                    break;
                case "both":
                    Console.WriteLine($"{space}[RainbowGenerator#{mode}] We are about to run...");

                    Console.Write($"[RainbowGenerator#{mode}] Insert a text: ");
                    text = Console.ReadLine();
                    Console.Write(space);

                    while (true)
                    {
                        foreach (char c in text)
                        {
                            Console.ForegroundColor = (ConsoleColor)Enum.GetValues(typeof(ConsoleColor)).GetValue((new Random()).Next(1, 15)); // except black(0)
                            Console.BackgroundColor = (ConsoleColor)Enum.GetValues(typeof(ConsoleColor)).GetValue((new Random()).Next(0, 15)); // all colors
                            Console.Write(c);
                        }
                    }
                case "back":
                    Console.WriteLine($"{space}[RainbowGenerator#{mode}] We are about to run...");

                    Console.Write($"[RainbowGenerator#{mode}] Insert a text: ");
                    text = Console.ReadLine();
                    Console.Write(space);

                    while (true)
                    {
                        foreach (char c in text)
                        {
                            Console.BackgroundColor = (ConsoleColor)Enum.GetValues(typeof(ConsoleColor)).GetValue((new Random()).Next(0, 14)); // except white(15)
                            Console.Write(c);
                        }
                    }
                case "fore":
                    Console.WriteLine($"{space}[RainbowGenerator#{mode}] We are about to run...");

                    Console.Write($"[RainbowGenerator#{mode}] Insert a text: ");
                    text = Console.ReadLine();
                    Console.Write(space);

                    while (true)
                    {
                        foreach (char c in text)
                        {
                            Console.ForegroundColor = (ConsoleColor)Enum.GetValues(typeof(ConsoleColor)).GetValue((new Random()).Next(1, 15)); // except black(0)
                            Console.Write(c);
                        }
                    }
                case "all":
                    Console.WriteLine($"{space}[RainbowGenerator#{mode}] We are about to run...");

                    Console.Write($"[RainbowGenerator#{mode}] Insert a text: ");
                    text = Console.ReadLine();
                    Console.Write(space);

                    while (true)
                    {
                        foreach (char c in text)
                        {
                            Console.ForegroundColor = (ConsoleColor)Enum.GetValues(typeof(ConsoleColor)).GetValue((new Random()).Next(0, 15)); // all colors
                            Console.BackgroundColor = (ConsoleColor)Enum.GetValues(typeof(ConsoleColor)).GetValue((new Random()).Next(0, 15)); // all colors
                            Console.Write(c);
                        }
                    }
                default:
                    Console.WriteLine($"{space}[RainbowGenerator] Invalid mode!");
                    Console.WriteLine("[RainbowGenerator] Press any key to exit.");
                    Console.ReadKey();
                    break;
            }
        }
    }
}