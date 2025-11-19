using System.ComponentModel.DataAnnotations;

static class Enemy
{
    static readonly string[] dmgType = ["Vital", "Calculatory", "Divine"];
    static public PartyMember player;
    static string[] battleMessage;
    static Random random = new();
    static public EnemyData eData;
    public static void NewEnemy(EnemyList.ID id, out bool death)
    {
        player.hp = player.totalHP;
        eData = EnemyList.enemyList[(int)id];
        int totalHP = eData.hp;
        string battleOptionsText = $"({player.battleActions[0]}, {player.battleActions[1]}, {player.battleActions[2]})";
        while (eData.hp > 0 && player.hp > 0)
        {
            battleMessage = [T.txt[100], BattleFlavorText.FlavorText(eData.name)];
            PlayerTurn(battleOptionsText, totalHP);
            if (eData.hp > 0)
            {
                EnemyTurn(battleOptionsText, totalHP);
            }
        }
        Console.Clear();
        Console.WriteLine(BattleDisplay(eData, totalHP, 1));
        if (player.hp <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(T.txt[76]);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(T.txt[77]);
            death = true;
        }
        else
        {
            Color.TextGreen($"{eData.name} has been defeated!\nYour party gained ", $"{eData.pValue.ToString()} p-Value", ".");
            death = false;
        }
        Continue.ContCheck();
    }
    static void PlayerTurn(string battleOptionsText, int totalHP)
    {
        Console.Clear();
        Console.WriteLine(BattleDisplay(eData, totalHP, 1));
        BattleMessage([battleMessage[0], battleMessage[1]], "");
        int resistance = random.Next(0, 3);
        int playerChoice = Decision.Choice(player.battleActions);
        Console.Clear();
        Console.WriteLine(BattleDisplay(eData, totalHP, 1));
        switch (playerChoice)
        {
            case 1:
                int dmg = player.Attack(resistance);
                string mortality = "";
                if (eData.hp - dmg <= 0)
                {
                    mortality = "mortal ";
                }
                battleMessage = [$"You slashed at {eData.name}! 🗡️", $"{dmg} points of {mortality}{dmgType[resistance]} damage dealt to {eData.name}!"];
                eData.hp -= dmg;
                break;
        }
        BattleMessage([battleMessage[0], ""], battleOptionsText);
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine(BattleDisplay(eData, totalHP, 1));
        BattleMessage([battleMessage[0], battleMessage[1]], battleOptionsText);
        Thread.Sleep(1500);
    }
    static void EnemyTurn(string battleOptionsText, int totalHP)
    {
        Console.Clear();
        Console.WriteLine(BattleDisplay(eData, totalHP, 2));
        switch (1)
        {
            case 1:
                int dmg = (int)Math.Ceiling(eData.dmg * random.Next(75, 126) / 100d);
                player.hp -= dmg;
                string playerMortality = "";
                if (player.hp <= 0)
                {
                    playerMortality = "mortal ";
                }
                battleMessage = [$"{eData.name} {eData.atkTxt}! {eData.atkIcon}", $"{player.name} took {dmg} points of {playerMortality}damage!"];
                break;
        }
        BattleMessage([battleMessage[0], ""], battleOptionsText);
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine(BattleDisplay(eData, totalHP, 2));
        BattleMessage([battleMessage[0], battleMessage[1]], battleOptionsText);
        Thread.Sleep(1500);
        Console.Clear();
        Console.WriteLine(BattleDisplay(eData, totalHP, 1));
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine($"{battleMessage[0]}\n{battleMessage[1]}");
        Console.ForegroundColor = ConsoleColor.White;
    }
    static void BattleMessage(string[] msg, string bot)
    {
            Console.ForegroundColor = ConsoleColor.Gray;
            foreach (string msgs in msg)
            {
                Console.WriteLine(msgs);
            }
            Console.ForegroundColor = ConsoleColor.White;
            if (!string.Equals(bot, ""))
            {
                Console.WriteLine(bot);
            }
    }
    static string BattleDisplay(EnemyData enemy, int eTotalHP, int turn)
    {
        string playerArrow = "";
        string enemyArrow = "";
        switch (turn)
        {
            case 1:
                playerArrow = "⬅️";
                break;
            case 2:
                enemyArrow = "⬅️";
                break;
        }
        string enemyHealthIndicator = "";
        string playerHealthIndicator = "";
        switch ((double)enemy.hp / eTotalHP)
        {
            case > 0:
                enemyHealthIndicator = "♥️";
                break;
            case <= 0:
                enemyHealthIndicator = "☠️";
                break;
        }
        switch ((double)player.hp / player.totalHP)
        {
            case > 0.6:
                playerHealthIndicator = "💚";
                break;
            case > 0.3:
                playerHealthIndicator = "💛";
                break;
            case > 0:
                playerHealthIndicator = "💔";
                break;
            case <= 0:
                playerHealthIndicator = "🪦";
                break;
        }
        return @$"{enemy.icon}{enemy.name} [{enemyHealthIndicator}{Math.Max(0, enemy.hp)}/{eTotalHP}] {enemyArrow}

{player.icon}{player.name} [{playerHealthIndicator}{Math.Max(0, player.hp)}/{player.totalHP}] {playerArrow}";
    }
}