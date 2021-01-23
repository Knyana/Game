using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SuperMegaUltraTopGameInTheWorld
{
    public class Start
    {
        public static string getCommandsFromConsole;
        private static bool isWork = false;
        public void InitialMethod()
        {
            StartGame(getCommandsFromConsole);
            while (isWork)
            {
                getCommandsFromConsole = Console.ReadLine();
                ExitGame(getCommandsFromConsole);
            }
        }
        public void StartGame(string command)
        {
            getCommandsFromConsole = Console.ReadLine();
            if (getCommandsFromConsole == Commands.handler["StartGame"])
            {
                isWork = true;
            }
        }
        public void ExitGame(string command)
        {
            getCommandsFromConsole = Console.ReadLine();
            if (getCommandsFromConsole == Commands.handler["ExitGame"])
            {
                isWork = false;
            }
        }
    }
}
