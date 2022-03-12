using MachinaTrader.Globals;
using System.Threading.Tasks;

namespace MachinaTrader
{
    class Program
    {
        static async Task<int> Main(string[] args)
        {
            Global.InitGlobals();
            await RuntimeSettings.LoadSettings();
            WebApplication.ProcessInit();
            return 0;
        }
    }

    public static class WebApplication
    {
        public static void ProcessInit()
        {
            Startup.RunWebHost();
        }
    }
}
