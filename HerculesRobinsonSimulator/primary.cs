using System.Text;
using System.Threading.Tasks;
T.GatherText();
Console.Clear();
Console.WriteLine("✌️".Length);
Console.WriteLine("🐸".Length);
Continue.ContCheck();
//all above is required
List<int> roomsCleared = new();
Console.WriteLine("Hercules Robinson Simulator");
Console.ForegroundColor = ConsoleColor.Gray;
T.Dialogue(1, 6);
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine(T.txt[54]);
if (Decision.Choice(["continue", "skip"]) == 1)
{
    Console.Clear();
    T.Dialogue(7, 12);
    T.Dialogue(13, 17);
    Console.Clear();
    T.Dialogue(18, 25);
    T.Dialogue(26, 32);
    Console.Clear();
    T.Dialogue(33, 38);
    Console.WriteLine($"{T.txt[39]}\n{T.txt[40]}");
    Decision.Choice(["slap"]);
    Console.Clear();
    T.Dialogue(41, 50);
}
Console.Clear();
Hercules hercules = new Hercules();
Enemy.player = hercules;
Console.Clear();
int currentRoom = Room.RoomNav(1);
int priorRoom = 1;
Console.Clear();
while (true)
{
    RoomData room = Rooms.roomList[currentRoom];
    string spaces = "";
    for (int f = 0; f == 30 - room.areaText.Length; f++)
    {
        spaces += " ";
    }
    Console.WriteLine($@"{room.areaText}");
    switch (room.roomType)
    {
        case 0:
            break;
        case 1:
            priorRoom = currentRoom;
            currentRoom = Room.RoomNav(currentRoom);
            break;
        case 2:
            Room.RoomLoot(currentRoom);
            currentRoom = priorRoom;
            break;
        case 3:
            if (roomsCleared.Contains(currentRoom))
            {
                currentRoom = room.navigationIDs[0];
                break;
            }
            Room.RoomFight(currentRoom, out bool death);
            if (death)
            {
                currentRoom = priorRoom;
                break;
            }
            roomsCleared.Add(currentRoom);
            currentRoom = room.navigationIDs[0];
            break;
        case 4:
            if (roomsCleared.Contains(currentRoom))
            {
                currentRoom = room.navigationIDs[0];
                break;
            }
            roomsCleared.Add(currentRoom);
            currentRoom = Room.RoomNav(currentRoom);
            break;
        case 5:
            if (roomsCleared.Contains(currentRoom))
            {
                currentRoom = room.navigationIDs[0];
                break;
            }
            roomsCleared.Add(currentRoom);
            foreach (int[] texts in room.roomTexts)
            {
                T.Dialogue(texts[0], texts[1]);
            }
            currentRoom = room.navigationIDs[0];
            break;
        case 6:
            if (roomsCleared.Contains(currentRoom))
            {
                Console.WriteLine(room.altRoomText);
                currentRoom = priorRoom;
                Continue.ContCheck();
                break;
            }
            Console.WriteLine(room.roomText);
            if (Decision.YesNo())
            {
                Items.itemCollection.Add(room.item);
                Color.TextYellow($"{room.roomTextYes} {T.txt[57]} ", room.item.name, "!");
                roomsCleared.Add(currentRoom);
                currentRoom = priorRoom;
                Continue.ContCheck();
                break;
            }
            Console.WriteLine(room.roomTextNo);
            currentRoom = priorRoom;
            Continue.ContCheck();
            break;
    }
    Console.Clear();
}
Room.RoomNav(0);
while (true) ;