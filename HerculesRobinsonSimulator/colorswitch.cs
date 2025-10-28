class Color
{
    static public void TextRed(string text1, string text2, string text3)
    {
        Console.Write(text1);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(text2);
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(text3);
    }
}