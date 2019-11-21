using System;
using System.Collections.Generic;
using System.Linq;

namespace BestHandV2
{
    public class Deck
    {
        private List<Card> deck = new List<Card>();
        private List<List<Card>> hands = new List<List<Card>>();
        private List<Card> shuffled = new List<Card>();
        
        public Deck()
        {
            for (int face = 2; face <= 14; face++)
            {
                for (int suits = 0; suits <= 3; suits++)
                {
                   Card card = new Card(face, suits);
                    this.deck.Add(card);
                }
            }
        }
        public Deck (int minCard, int maxCard)
        {
            for (int face = minCard; face <=maxCard; face++)
            {
                for (int suits = 0; suits <= 3; suits++)
                {
                    Card card = new Card(face, suits);
                    this.deck.Add(card);
                }
            }
        }
        //public void Shuffle()
        public List<Card> Shuffle()
        {
            Random rnd = new Random();
            IOrderedEnumerable<Card> shuffled = deck.OrderBy(Card => rnd.Next());
            shuffled.GetEnumerator();
           // shuffled.ToList<Card>();
              return shuffled.ToList<Card>();
        }

        //public List<List<Card>> Deal(int players, int hand)
        //{

        //    for (int plyr = 0; plyr < players; plyr++)
        //    {
        //        List<Card> cDealt = new List<Card>();

        //        for (int crd = 0; crd < hand; crd++)
        //        {
        //            cDealt.Add(shuffled[crd]);
        //            shuffled.Remove(shuffled[crd]);
        //        }
        //        hands.Add(cDealt);
        //    }

        //    return hands;
        //}
    }
}
