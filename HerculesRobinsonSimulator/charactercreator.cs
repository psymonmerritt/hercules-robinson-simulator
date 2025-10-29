class NameAndStatSelector(int total, int remaining)
{
    public string SelectName()
    {
        string characterName = Console.ReadLine();
        while (characterName.Length < 3 || characterName.Length > 10)
        {
            if (characterName.Length < 3)
            {
                Console.WriteLine(T.txt[14]);
            }
            else
            {
                Console.WriteLine(T.txt[15]);
            }
            characterName = Console.ReadLine();
        }
        return characterName;
    }
    public int SelectStats(string statID, int valueFinality)
    {
        Console.WriteLine($"\n{T.txt[16]} {statID} {T.txt[17]}");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int selectedValue) && selectedValue >= 1 && selectedValue <= 5)
            {
                if (remaining - selectedValue == 0 && valueFinality == 0)
                {
                    Console.WriteLine(T.txt[18]);
                }
                else if (remaining - selectedValue < 0 || (valueFinality == 1 && remaining - selectedValue != 0))
                {
                    Console.WriteLine($"{T.txt[19]} {total}.");
                }
                else
                {
                    remaining -= selectedValue;
                    return selectedValue;
                }
            }
            else
            {
                Console.WriteLine(T.txt[20]);
            }
        }
    }
    public string SelectIcon(string[] iconSelection)
    {
        foreach (string icon in iconSelection)
        {
            Console.WriteLine($"({Array.IndexOf(iconSelection, icon) + 1}) - {icon}");
        }
        int selectedIconNumber;
        for(;!int.TryParse(Console.ReadLine(), out selectedIconNumber) || selectedIconNumber > iconSelection.Length || selectedIconNumber < 1;)
        {
            Console.WriteLine(T.txt[21]);
        }
        return iconSelection[selectedIconNumber-1];
    }
}