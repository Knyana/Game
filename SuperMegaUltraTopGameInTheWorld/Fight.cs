using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMegaUltraTopGameInTheWorld
{
    public static class Fight
    {
        public static void FightSystem()
        {
            if (Player.location == Zombi.location) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Рядом враги!");
                Console.WriteLine("Ваши действия?\nДраться\nБежать");
                Console.ResetColor();

                if (Start.getCommandsFromConsole == Commands.DecideFightOrRun["FightWithEnemy"]) 
                {
                    Attack();
                }
                else if (Start.getCommandsFromConsole == Commands.DecideFightOrRun["RunFromEnemy"])
                {
                    Console.WriteLine($"Вы вернулись домой");
                    Player.location = Locations.locations[0];
                }
            }
        }
        public static void Attack()
        {
            Console.WriteLine("Бой начался");
            Start.getCommandsFromConsole = Console.ReadLine();
            if (Start.getCommandsFromConsole == Commands.fight["Attack"])
            {

                Zombi.Health -= Player.Damage;
                Console.WriteLine(Zombi.Health);
            }
        }
    }
}
