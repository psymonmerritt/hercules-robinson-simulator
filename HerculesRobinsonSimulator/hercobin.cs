public class Hercobin
{
    public string name = "hercobinName";
    public int[] abcStats = new int[3];
    public string icon = "hercobinIcon";
    public Hercobin()
    {
        while (true)
        {
            NameAndStatSelector hcSelector = new NameAndStatSelector(7, 7);
            Console.WriteLine("\nGive your Hercobin a name.");
            name = hcSelector.SelectName();
            //bs
            if (string.Equals(name, "Abacus"))
            {
                Enemy.hpmult = 3;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkRed;
            }
            Console.Clear();
            //bs
            if (string.Equals(name, "Abacus"))
            {
                Console.WriteLine("HARD MODE ACTIVATED!!!\n");
            }
            Console.WriteLine("Its name has been chosen as " + name + ".\nNow, you must select its A, B, and C values. They must total to 7.");
            abcStats[0] = hcSelector.SelectStats("A", 0);
            abcStats[1] = hcSelector.SelectStats("B", 0);
            abcStats[2] = hcSelector.SelectStats("C", 1);
            Console.Clear();
            Console.WriteLine("Finally, select the number of the icon that best represents your character.");
            icon = hcSelector.SelectIcon(["🙂", "😐", "😭", "😝", "😒"]);
            Console.Clear();
            Console.WriteLine("Are you satisfied with your character?\n");
            Console.WriteLine($"{icon} {name}\nA: {abcStats[0]}\tB: {abcStats[1]}\tC: {abcStats[2]}\n");
            if (Decision.YesNo())
            {
                break;
            }
        }
    }
}