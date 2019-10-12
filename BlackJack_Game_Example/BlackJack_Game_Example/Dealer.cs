using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Game_Example
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            string card = Deck.Cards.First().ToString() + "\n";
            Console.WriteLine(card);
            Deck.Cards.RemoveAt(0);
        }
    }
}
