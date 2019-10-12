using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Game_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Dazin Casino and Hotels. Let's start by telling me your name." );
            string playerName = Console.ReadLine();
            Console.WriteLine("How much money are you bringing to play with today?");
            int playerBalance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?\n Y/N", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "y")
            {
                Player player = new Player(playerName, playerBalance);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while(player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                    Console.ReadLine();
                }
                game -= player;
                Console.WriteLine("Thanks for playing, check out our gift shop!");
            }
            Console.WriteLine("Enjoy your stay!");
            Console.ReadLine();
        }


    }
}
