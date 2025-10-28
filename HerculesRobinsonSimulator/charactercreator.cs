class NameAndStatSelector(int total, int remaining)
{
    public string SelectName()
    {
        string characterName = Console.ReadLine();
        while (characterName.Length < 3 || characterName.Length > 10)
        {
            if (characterName.Length < 3)
            {
                Console.WriteLine("That name is a bit short...");
            }
            else
            {
                Console.WriteLine("That name is a bit long...");
            }
            characterName = Console.ReadLine();
        }
        return characterName;
    }
    public int SelectStats(string statID, int valueFinality)
    {
        Console.WriteLine("\nSelect " + statID + " value from 1 to 5.");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int selectedValue) && selectedValue >= 1 && selectedValue <= 5)
            {
                if (remaining - selectedValue == 0 && valueFinality == 0)
                {
                    Console.WriteLine("All values must be 1 at minimum.");
                }
                else if (remaining - selectedValue < 0 || (valueFinality == 1 && remaining - selectedValue != 0))
                {
                    Console.WriteLine("Values must add up to " + total + ".");
                }
                else
                {
                    remaining -= selectedValue;
                    return selectedValue;
                }
            }
            else
            {
                Console.WriteLine("Value must be from 1 to 5.");
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
            Console.WriteLine("Select a number representing an icon.");
        }
        return iconSelection[selectedIconNumber-1];
    }
}