class BattleFlavorText
{
    static Random random = new();
    static readonly string[] lunarPhases = { "🌑", "🌒", "🌓", "🌔", "🌕", "🌖", "🌗", "🌘" };
    static readonly string[] weather = { "☀️", "🌤", "⛅️", "☁️", "🌦", "🌧", "🌩", "🌨", "🌪" };
    static readonly string[] food = { "🍎", "🍉", "🍍", "🥑", "🥨", "🥖", "🌮", "🍪", "🍟", "🥕" };
    static readonly string[] vehicle = { "🚗", "🚌", "🚜", "🚖", "🚠", "🚂", "🚀", "🚁", "🛶", "⛵️" };
    static readonly string[] crime = { "🦹‍♀️", "🧙‍♀️", "🧛", "👨‍🔬", "🏃‍♂️", "🧑‍🦯", "🕴", "👨‍🍳", "🧑‍🌾", "💂‍♀️" };
    static public string FlavorText(string enemyName)
    {
        switch (random.Next(1, 16))
        {
            case 1:
                return $"{T.txt[82]} {lunarPhases[random.Next(0, 8)]}";
            case 2:
                return $"{T.txt[83]} {weather[random.Next(0, 9)]}";
            case 3:
                return $"{T.txt[84]} {T.txt[random.Next(85,100)]}";
            case 4:
                return T.txt[103];
            case 5:
                return $"{T.txt[101]} {food[random.Next(0, 10)]}";
            case 6:
                return $"{T.txt[102]} {vehicle[random.Next(0, 10)]}";
            case 7:
                return T.txt[104];
            case 8:
                return T.txt[105];
            case 9:
                return $"{T.txt[106]} {random.Next(1, 13)}/{random.Next(1, 32)}/{random.Next(1000, 2026)}";
            case 10:
                return $"{T.txt[107]} {crime[random.Next(0, 11)]}";
            case 11:
                return $"{enemyName} {T.txt[153]}";
            case 12:
                return $"{enemyName} {T.txt[random.Next(143, 153)]}";
            case 13:
                return $"{enemyName} {T.txt[157]}";
            case 14:
                return T.txt[158];
            case 15:
                return T.txt[159];
            //puzzle 1
            case 16:
                return T.txt[random.Next(154, 157)];
            default:
                return "ERROR 🟥𓀅";
        }
    }
}