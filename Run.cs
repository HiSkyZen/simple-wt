using System.Diagnostics;

namespace simple_wt
{
    class Run
    {
        static void Main(string[] args)
        {
            Process.Start(
                "explorer.exe",
                "shell:appsFolder\\Microsoft.WindowsTerminal_8wekyb3d8bbwe!App"
            );
        }
    }
}
