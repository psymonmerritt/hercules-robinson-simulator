class Decision
{
    public static int Choice(string[] options)
    {
        List<string> afterFirst = new();
        foreach (string option in options)
        {
            afterFirst.Add(option);
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
            int selectionPosition = Array.IndexOf(options, Console.ReadLine().ToLower());
            if(selectionPosition >= 0)
            {
                return selectionPosition + 1;
            }
        }
    }
    public static bool YesNo()
    {
        while (true)
        {
            Console.WriteLine("(yes, no)");
            string answer = Console.ReadLine().ToLower();
            if (answer == "no")
            {
                return false;
            }
            else if (answer == "yes")
            {
                return true;
            }
        }
    }
}