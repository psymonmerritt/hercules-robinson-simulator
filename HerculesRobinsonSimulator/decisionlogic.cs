class Decision
{
    public static int Choice(string[] options)
    {
        List<string> afterFirst = new();
        List<char> optionLetters = new();
        foreach (string option in options)
        {
            afterFirst.Add(option);
            optionLetters.Add(option[0]);
        }
        afterFirst.RemoveAt(0);
        while (true)
        {
            Console.Write("(" + options[0]);
            foreach (string aFOption in afterFirst)
            {
                Console.Write(", " + aFOption);

            }
            Console.WriteLine(")");
            string input = Console.ReadLine().ToLower();
            int selectionLetterPosition = -1;
            if (input.Length == 1)
            {
                selectionLetterPosition = optionLetters.IndexOf(input[0]);
            }
            int selectionPosition = Array.IndexOf(options, input);
            if (selectionPosition >= 0)
            {
                return selectionPosition + 1;
            }
            if(selectionLetterPosition >= 0)
            {
                return selectionLetterPosition + 1;
            }
        }
    }
    public static bool YesNo()
    {
        return Convert.ToBoolean(2 - Choice(["yes", "no"]));
    }
}