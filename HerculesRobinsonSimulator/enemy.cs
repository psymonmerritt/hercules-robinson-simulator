class Enemy
{
    readonly string[] dmgType = ["BxC", "AxC", "AxB"];
    static public Hercobin? fightingParty;
    public string battleMessage;
    Random random = new();
    //bs
    static public int hpmult = 1;
    //bs
    public Enemy(int health, string nom, string icon)
    {
        //bs
        string name = nom;
        //bs
        if (string.Equals(fightingParty.name, "Abacus"))
        {
            name = "Fucking Evil " + nom;
        }
        //bs
        int hp = health * hpmult;
        battleMessage = name + " charges into battle!";
        int resistance = random.Next(0, 3);
        int totalHP = hp;
        while (hp > 0)
        {
            Console.Clear();
            Console.WriteLine($"{icon}{name} [♥️ {hp}/{totalHP}]\n\n{fightingParty.icon}{fightingParty.name} [💚{fightingParty.abcStats[0]}/{fightingParty.abcStats[0]}]");
            Console.WriteLine(battleMessage);
            switch (Decision.Choice(["attack", "spell", "item"]))
            {
                case 1:
                    hp -= Attack(hp, resistance, name);
                    break;
            }
        }
        Console.Clear();
        Console.WriteLine($"{icon}{name} [♥️ 0/{totalHP}]\n\n{fightingParty.icon}{fightingParty.name} [💚{fightingParty.abcStats[0]}/{fightingParty.abcStats[0]}]");
        Console.WriteLine($"{battleMessage}\n{name} has been defeated.");
        Continue.Cont();
    }
    int Attack(int hp, int res, string name)
    {
        int dmg = fightingParty.abcStats[0] * fightingParty.abcStats[1] * fightingParty.abcStats[2] / fightingParty.abcStats[res] * random.Next(75,131) / 100;
        string mortality = "";
        if (hp - dmg <= 0)
        {
            mortality = "mortal ";
        }
        battleMessage = $"{dmg} points of {mortality}{dmgType[res]} dealt to {name}!";
        return dmg;
    }
}