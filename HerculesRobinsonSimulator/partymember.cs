abstract class PartyMember
{
    Random random = new();
    public string name;
    public string icon;
    public string[] battleActions;
    public int[] vcdStats = new int[3];
    public int hp;
    public int totalHP;
    public int Attack(int res)
    {
        int dmg = (int)Math.Ceiling(vcdStats[0] * vcdStats[1] * vcdStats[2] / vcdStats[res] * random.Next(75, 111) / 100d);
        return dmg;
    }
}