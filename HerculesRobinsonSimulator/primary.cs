Console.Clear();
T.GatherText();
Console.WriteLine("Hercules Robinson Simulator Pre-Alpha 2");
Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine($"\n{T.txt[1]}\n{T.txt[2]}\n{T.txt[3]}\n{T.txt[23]}\n{T.txt[4]}\n{T.txt[5]}");
Console.ForegroundColor = ConsoleColor.White;
Continue.ContCheck();
Console.Clear();
Color.TextRed(T.txt[6],T.txt[7],T.txt[8]);
Hercobin hcOne = new Hercobin();
Enemy.fightingParty = hcOne;
Console.Clear();
Console.WriteLine(T.txt[22]);
switch (Decision.Choice(["town", "field"]))
{
    case 1:
        break;
    case 2:
        Enemy.NewEnemy(10, "Flea", "🦟");
        Enemy.NewEnemy(20, "Lizard", "🦎");
        Enemy.NewEnemy(30, "Frog", "🐸");
        Enemy.NewEnemy(40, "Sky borg", "🦤 ");
        break;
}
Console.Clear();
Console.WriteLine("Congratulations! 🎉");