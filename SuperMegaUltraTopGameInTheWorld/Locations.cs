using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SuperMegaUltraTopGameInTheWorld
{
    /// <summary>
    /// Все о лоакцииях (хз как будет по нормальному и надо ли здесь это воще)
    /// </summary>
    public static class Locations
    {
        /// <summary>
        /// List со всем локациями
        /// Home
        /// Shcool
        /// Shop
        /// Shelter
        /// </summary>
        public static List<string> locations = new List<string>()
        {
            "Home",
            "School",
            "Shop",
            "Shelter"
        };
        //TODO Надо переделать, ибо => будет много локаций == будет много ифок this is't good
        public static void MoveOnLocation()
        {
            if (Start.getCommandsFromConsole == Commands.locationControll["MoveOnLocation"]+ "On" + locations[0])
            {
                Player.location = locations[0];
            }
            else if (Start.getCommandsFromConsole == Commands.locationControll["MoveOnLocation"] + "On" + locations[1])
            {
                Player.location = locations[1];
            }
            else if (Start.getCommandsFromConsole == Commands.locationControll["MoveOnLocation"] + "On" + locations[2])
            {
                Player.location = locations[2];
            }
            else if (Start.getCommandsFromConsole == Commands.locationControll["MoveOnLocation"] + "On" + locations[3])
            {
                Player.location = locations[3];
            }
        }
        public static void ShowAllLocations()
        {
            if (Start.getCommandsFromConsole == Commands.locationControll["ShowAllLocations"])
            {
                foreach (string item in locations)
                {
                    Console.WriteLine(item);
                }
            }
        }
        public static void ShowPlayerLocation()
        {
            if (Start.getCommandsFromConsole == Commands.locationControll["ShowPlayerLocation"])
            {
                Console.WriteLine(Player.location);
            }
        }
    }
}
