using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMegaUltraTopGameInTheWorld
{
    static class Commands
    {
        public static Dictionary<string, string> handler = new Dictionary<string, string>()
        {
            {"StartGame","-start" },
            {"ExitGame","-exit" },
            {"","" }
        };
    }
}
