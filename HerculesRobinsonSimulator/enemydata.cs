struct EnemyData
{
    public string name;
    public string icon;
    public string atkTxt;
    public int hp;
    public int pValue;
    public int dmg;
    public string atkIcon;
    public EnemyData(string name, string icon, int hp, int dmg, int pValue, string atkTxt, string atkIcon)
    {
        this.name = name;
        this.icon = icon;
        this.atkTxt = atkTxt;
        this.hp = hp;
        this.pValue = pValue;
        this.dmg = dmg;
        this.atkIcon = atkIcon;
    }
}