static class Rooms
{
    static public RoomData[] roomList =
    {
        new(0, Area.error, T.txt[52], ["please close your game"], [0]),
        new(1, Area.house, T.txt[51], ["leave", "inspect"], [2, 3]),
        new(2, Area.house, T.txt[53], ["downstairs", "bedroom", "restroom"], [6, 1, 4]),
        new(3, Area.house, T.txt[56], new Item ("Cabinet Key"), T.txt[121]),
        new(4, Area.house, T.txt[58], ["open", "leave"], [5, 2]),
        new(5, Area.house, T.txt[59], [EnemyList.ID.darkflea, EnemyList.ID.darkflea, EnemyList.ID.darkflea], [0]),
        new(6, Area.house, T.txt[78], ["continue"], [9], true),
        new(7, Area.house, T.txt[79], ["hallway", "upstairs", "hole"], [10, 2, 13]),
        new(8, Area.house, T.txt[81], ["outside", "stairs", "kitchen"], [67, 7, 11]),
        new(9, Area.house, T.txt[80], [EnemyList.ID.flea], [7]),
        new(10, Area.house, [[108, 111], [112, 115]], [8]),
        new(11, Area.house, T.txt[116], ["leave", "fridge", "cabinet"], [8, 12, 14]),
        new(12, Area.house, T.txt[117], T.txt[118], T.txt[119], new Item ("Ball of Mold"), T.txt[120]),
        new(13, Area.house, $"{T.txt[122]}\n{T.txt[123]}", ["enter", "back"], [14, 7]),
        new(14, Area.bugkingdom, T.txt[124], ["cave", "house"], [15,13]),
        new(15, Area.bugkingdom, T.txt[126], [EnemyList.ID.flea], [16])
    };
}