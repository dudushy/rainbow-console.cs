namespace RainbowConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert a text: ");
            string text = Console.ReadLine();
            Console.Write("\n");
            while (true)
            {
                foreach (char c in text)
                {
                    Console.ForegroundColor = (ConsoleColor)Enum.GetValues(typeof(ConsoleColor)).GetValue((new Random()).Next(1, 15)); // except black(0)
                    Console.BackgroundColor = (ConsoleColor)Enum.GetValues(typeof(ConsoleColor)).GetValue((new Random()).Next(1, 15)); // all colors
                    Console.Write(c);
                }
            }
        }
    }
}