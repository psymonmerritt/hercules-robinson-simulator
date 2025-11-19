class Hercules : PartyMember
{
    SelectStats hercStats = new(7);
    public Hercules()
    {
        battleActions = ["attack", "calculate", "block"];
        Console.WriteLine(T.txt[60]);
        Continue.ContCheck();
        vcdStats[0] = hercStats.abcSelect("Vitality");
        vcdStats[1] = hercStats.abcSelect("Calculality");
        vcdStats[2] = hercStats.abcSelect("Divinity");
        icon = hercStats.iconSelect(["😇", "😭", "😝", "😱", "😐"]);
        name = hercStats.nameSelect();
        T.Dialogue(68, 70);
        name = "Hercules";
        hp = 2 * vcdStats[0];
        totalHP = hp;
    }
}