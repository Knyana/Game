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
            getCommandsFromConsole = Console.ReadLine();
            if (getCommandsFromConsole == Commands.handler["StartGame"])
            {
                isWork = true;
            }
            while (isWork)
            {
                Console.WriteLine("Цикл работает");
                Thread.Sleep(10000);
            }
        }

    }
}
