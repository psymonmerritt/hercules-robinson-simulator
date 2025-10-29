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
}