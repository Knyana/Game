using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMegaUltraTopGameInTheWorld
{
    static class Commands
    {
        /// <summary>
        /// Словарь с -start
        ///           -exit 
        /// </summary>
        public static Dictionary<string, string> handler = new Dictionary<string, string>()
        {
            {"StartGame","-start" },
            {"ExitGame","-exit" },
            {"","" }
        };
        /// <summary>
        /// Словарь с -move
        ///          -showAllLoc
        ///          -showMyLoc
        /// </summary>
        public static Dictionary<string, string> locationControll = new Dictionary<string, string>()
        {
            {"MoveOnLocation","-move" },
            {"ShowAllLocations","-showAllLoc" },
            {"ShowPlayerLocation","-showMyLoc" }
        };

        public static Dictionary<string, string> DecideFightOrRun = new Dictionary<string, string>()
        {
            {"FightWithEnemy","-fight" },
            {"RunFromEnemy","-run" },

        };
        public static Dictionary<string, string> fight = new Dictionary<string, string>()
        {
            {"Attack","-attack" },
            {"Block","-block" },

        };
    }
}
