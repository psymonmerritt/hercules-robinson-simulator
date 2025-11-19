class RoomData
{
    public int roomID;
    public string roomText;
    public string areaText;
    public int roomType;
    public int[][] roomTexts;
    public string altRoomText;
    public string roomTextYes;
    public string roomTextNo;
    public string[] navigation;
    public int[] navigationIDs;
    public Item item;
    public EnemyList.ID[] enemies;
    //Standard room
    public RoomData(int roomID, Area areaTextNumber, string roomText, string[] nav, int[] navIDs)
    {
        this.roomID = roomID;
        areaText = RoomAssembler.areaText[(int)areaTextNumber];
        this.roomText = roomText;
        navigation = nav;
        navigationIDs = navIDs;
        roomType = 1;
    }
    //Item room
    public RoomData(int roomID, Area areaTextNumber, string roomText, Item item, string altRoomText)
    {
        this.roomID = roomID;
        this.item = item;
        this.roomText = roomText;
        areaText = RoomAssembler.areaText[(int)areaTextNumber];
        this.altRoomText = altRoomText;
        this.item = item;
        roomType = 2;
    }
    //Enemy room
    public RoomData(int roomID, Area areaTextNumber, string roomText, EnemyList.ID[] enemies, int[] navID)
    {
        this.roomID = roomID;
        areaText = RoomAssembler.areaText[(int)areaTextNumber];
        this.roomText = roomText;
        this.enemies = enemies;
        navigationIDs = navID;
        roomType = 3;
    }
    //Disappearing room
    public RoomData(int roomID, Area areaTextNumber, string roomText, string[] nav, int[] navIDs, bool clearable)
    {
        this.roomID = roomID;
        areaText = RoomAssembler.areaText[(int)areaTextNumber];
        this.roomText = roomText;
        navigation = nav;
        navigationIDs = navIDs;
        roomType = 4;
    }
    //Dialogue room
    public RoomData(int roomID, Area areaTextNumber, int[][] roomTexts, int[] navIDs)
    {
        this.roomID = roomID;
        areaText = RoomAssembler.areaText[(int)areaTextNumber];
        this.roomTexts = roomTexts;
        navigationIDs = navIDs;
        roomType = 5;
    }
    //Yes/no room with item
    public RoomData(int roomID, Area areaTextNumber, string roomText, string roomTextYes, string roomTextNo, Item item, string altRoomText)
    {
        this.roomTextNo = roomTextNo;
        this.roomTextYes = roomTextYes;
        this.roomText = roomText;
        this.roomID = roomID;
        this.item = item;
        areaText = RoomAssembler.areaText[(int)areaTextNumber];
        this.altRoomText = altRoomText;
        roomType = 6;
    }
}
enum Area
{
    error,
    house,
    bugkingdom,
    field,
    mountain,
}
static class RoomAssembler
{
    public static string[] areaText =
    {
        "ERROR ROOM 🟥𓀅",
        "🏠House🏠",
        "🐜Bug Kingdom🐜",
        "🌲Forest🌲",
        "🏔️Mountain🏔️"
    };
}