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
            Console.WriteLine($"\n{T.txt[9]}");
            name = hcSelector.SelectName();
            Console.Clear();
            Console.WriteLine($"{T.txt[10] + name}.\n{T.txt[11]}");
            abcStats[0] = hcSelector.SelectStats("A", 0);
            abcStats[1] = hcSelector.SelectStats("B", 0);
            abcStats[2] = hcSelector.SelectStats("C", 1);
            Console.Clear();
            Console.WriteLine(T.txt[12]);
            icon = hcSelector.SelectIcon(["🙂", "😐", "😭", "😝", "😒"]);
            Console.Clear();
            Console.WriteLine(T.txt[13]);
            Console.WriteLine($"\n{icon} {name}\nA: {abcStats[0]}\tB: {abcStats[1]}\tC: {abcStats[2]}\n");
            if (Decision.YesNo())
            {
                break;
            }
        }
    }
}