class Continue
{
    static public void Cont()
    {
        Console.Write("➡️ ");
        while (Console.ReadKey().Key != ConsoleKey.Enter) { }
    }
}