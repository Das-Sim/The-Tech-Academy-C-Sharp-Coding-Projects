using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Game_Example
{
    public class TwentyOneDealer : Dealer
    {
        private List<Card> _Hand = new List<Card>();
        public List<Card> Hand { get; set; }
        public bool Stay { get; set; }
        public bool isBusted { get; set; }

    }
}
