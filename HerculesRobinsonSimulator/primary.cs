Console.Clear();
Console.WriteLine("Hercules Robinson Simulator v0.0.0.0.1 Alpha Beta Omega Test Build");
Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine(@"
Instructions:
When prompted, write a response.
When you are given a list of choices like (choice, choice, choice) those are your options. Not caps sensitive.
When you see a ➡️ , press enter to continue.
Don't have fun.
");
Console.ForegroundColor = ConsoleColor.White;
Continue.Cont();
Console.Clear();
Color.TextRed("You are a being of ", "great power", ", restrained by your complete inability to interact with the world, except through a tiny, insignificant creature known as a Hercobin.");
Hercobin hcOne = new Hercobin();
Enemy.fightingParty = hcOne;
new Enemy(10, "Flea", "🦟");
new Enemy(20, "Lizard", "🦎");
new Enemy(30, "Frog", "🐸");
new Enemy(40, "Sky borg", "🦤 ");
Console.Clear();
Console.WriteLine("Congratulations! 🎉\nName yourself Abacus for a surprise!");
//bs
if (string.Equals(hcOne.name, "Abacus"))
{
    Console.WriteLine("Oh wait, you already did. Here's your reward!\nhttps://imgur.com/a/7CFpMci");
}