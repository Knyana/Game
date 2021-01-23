using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SuperMegaUltraTopGameInTheWorld
{
    public class Zombi
    {
        public static string location = null;
        public static int Health { get; set; } = 50;
        public static int Damage { get; set; } = 10;
        public static async void MoveOnLocation()
        {
            await Task.Run(() =>
            {
               Random random = new Random();
               location = Locations.locations[random.Next(1, 3)];
                Thread.Sleep(3000);

            });
            
        }

    }
}
