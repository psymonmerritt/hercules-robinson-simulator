using System.IO;
static class T
{
    static StreamReader streamReader = new("/workspaces/hercules-robinson-simulator/HerculesRobinsonSimulator/textfile.txt");
    static public List<string> txt = new();
    static string txtcollect = "Hi";
    static public void GatherText()
    {
        txt.Add("Hello");
        while (txtcollect != null)
        {
            txtcollect = streamReader.ReadLine();
            txt.Add(txtcollect);
        }
    }
    static public void Dialogue(int start, int end)
    {
        for (int dstart = start; dstart < end + 1; dstart++)
        {
            Console.WriteLine(T.txt[dstart]);
        }
        Continue.ContCheck();
    }
}