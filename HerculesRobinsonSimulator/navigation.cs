static class Room
{
    public static int RoomNav(int roomID)
    {
        RoomData room = Rooms.roomList[roomID];
        Console.WriteLine($"{room.areaText}\n{room.roomText}");
        switch (Decision.Choice(room.navigation))
        {
            case 1:
                return room.navigationIDs[0];
            case 2:
                return room.navigationIDs[1];
            case 3:
                return room.navigationIDs[2];
            default:
                return 0;
        };
    }
    public static void RoomLoot(int roomID)
    {
        RoomData room = Rooms.roomList[roomID];
        Console.WriteLine(room.areaText);
        if (Items.itemCollection.Exists(x => x.name == room.item.name))
        {
            Console.WriteLine(room.altRoomText);
            Continue.ContCheck();
        }
        else
        {
            Items.itemCollection.Add(room.item);
            Color.TextYellow($"{room.roomText} {T.txt[57]} ", room.item.name, "!");
            Continue.ContCheck();
        }
    }
    public static void RoomFight(int roomID, out bool death)
    {
        RoomData room = Rooms.roomList[roomID];
        Console.WriteLine(room.areaText);
        Console.WriteLine(room.roomText);
        Continue.ContCheck();
        death = false;
        foreach (EnemyList.ID enemy in room.enemies)
        {
            Enemy.NewEnemy(enemy, out bool dead);
            if (dead)
            {
                death = true;
                break;
            }
        }
    }
}