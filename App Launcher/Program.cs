using System;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string directory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        try
        {
            string appLaunch = File.ReadAllText(directory + $@"\{Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetExecutingAssembly().Location)}.txt");
            ProcessStartInfo steamApp = new ProcessStartInfo
            {
                FileName = $"\"{appLaunch}\"",
                Arguments = ""
            };
            Process.Start(steamApp);
        }
        catch (Exception e)
        {
            //Todo: Show some sort of window pop up or something. 
        }
    }
}
