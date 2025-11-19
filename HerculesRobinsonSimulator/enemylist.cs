class EnemyList
{
    static public readonly EnemyData[] enemyList = new EnemyData[]
    {
        //Name, icon, HP, damage, exp, attack message, attack icon
        new EnemyData("Flea", "🦟", 10, 1, 2, T.txt[72], "🦷"),
        new EnemyData("Lizard", "🦎", 12, 1, 3, T.txt[72], "🦷"),
        new EnemyData("Frog", "🐸", 15, 2, 3, T.txt[74], "👅"),
        new EnemyData("Sky borb", "🦤", 20, 3, 4, T.txt[75], "🐾"),
        new EnemyData("Skeleton", "🩻", 100, 10, 20, T.txt[73], "🦴"),
        new EnemyData("Dark Frog", "🧿🐸", 1333, 75, 50, T.txt[71], "♍️"),
        new EnemyData("Spider", "🕷️", 15, 2, 4, T.txt[125], "🕸")
    };
    public enum ID
    {
        flea,
        lizard,
        frog,
        skyborb,
        skeleton,
        darkflea
    }
}