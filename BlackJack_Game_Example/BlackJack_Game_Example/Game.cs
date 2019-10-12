using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Game_Example
{
    public abstract class Game
    {
        private List<Player> _players = new List<Player>();
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get; set; }

        public abstract void Play();

        public virtual void ListPlayers()
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }

    }
}
