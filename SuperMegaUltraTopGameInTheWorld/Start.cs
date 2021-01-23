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
        private static bool isWork;
        public void InitialMethod()
        {
            StartGame();
            while (isWork)
            {
                getCommandsFromConsole = Console.ReadLine();
                Locations.ShowAllLocations();
                Locations.ShowPlayerLocation();
                Locations.MoveOnLocation();
                ExitGame();
            }
        }
        public void StartGame()
        {
            getCommandsFromConsole = Console.ReadLine();
            if (getCommandsFromConsole == Commands.handler["StartGame"])
            {
                isWork = true;
            }
        }
     
        public void ExitGame()
        {
                if (getCommandsFromConsole == Commands.handler["ExitGame"])
                {
                    isWork = false;
                }
        }
    }
}
