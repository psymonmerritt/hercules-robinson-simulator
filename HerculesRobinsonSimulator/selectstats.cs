class SelectStats
{
    int total;
    int remaining;
    public SelectStats(int total)
    {
        this.total = total;
        this.remaining = total;
    }
    public int abcSelect(string statName)
    {
        Console.WriteLine($"Select your {statName} value from 1 to {total - 2}.");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int selection) && selection > 0 && selection < total - 2)
            {
                if (remaining - selection == 0 && !string.Equals(statName, "Divinity"))
                {
                    Console.WriteLine(T.txt[63]);
                }
                else if ((remaining - selection > 0 && string.Equals(statName, "Divinity")) || remaining - selection < 0)
                {
                    Console.WriteLine($"{T.txt[62]} {total}.");
                }
                else
                {
                    remaining -= selection;
                    return selection;
                }
            }
            else
            {
                Console.WriteLine($"{T.txt[61]} 1 to {total - 2}.");
            }
        }
    }
    public string iconSelect(string[] iconOptions)
    {
        int i = 1;
        foreach (string option in iconOptions)
        {
            Console.WriteLine($"({i}) - {option}");
            i++;
        }
        while (true)
        {
            Console.WriteLine(T.txt[67]);
            if (int.TryParse(Console.ReadLine(), out int selection) && selection > 0 && selection < 6)
            {
                return iconOptions[selection - 1];
            }
        }
    }
    public string nameSelect()
    {
        Console.WriteLine(T.txt[66]);
        while (true)
        {
            string selection = Console.ReadLine();
            if (selection.Length > 10)
            {
                Console.WriteLine(T.txt[65]);
            }
            else if (selection.Length < 3)
            {
                Console.WriteLine(T.txt[64]);
            }
            else
            {
                return selection;
            }
        }
    }
}