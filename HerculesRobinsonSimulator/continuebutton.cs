class Continue
{
    static public void ContCheck()
    {
        Console.Write("➡️ ");
        while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
    }
}