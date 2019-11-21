using System;
using System.Collections.Generic;

namespace BestHandV2
{
    public class Game
    {
        public List<List<Card>> hands = new List<List<Card>>();
        private Deck deck = new Deck();
        public List<Card> shuffled;
        public Game()
        {
            this.shuffled = deck.Shuffle();
        }
        public List<List<Card>> Deal(int players, int hand)
        {
            // need a Jagged List/Array to put/remove any amount of cards on the Table in any position/cell/index.
            // need a Jagged List/Array to have any amount of players from 1 - 52 / Hand amount 1 - 52 cards.
            
            //List<List<Card>>  outer List: Players  /  inner List: Hands
            
            //List A: Loop A:  Make new List B -> Loop B: Add items to List B :End Loop B -> Add ListB to List A : End Loop A
            // Need to pass card by Index to Players  ..   All players Index 0 from the deck the 1,2,3 .. etc
            for (int plyr=0; plyr<players; plyr++)
            {
                List<Card> cDealt = new List<Card>();

                for (int crd=0; crd<hand; crd++)
                {
                    cDealt.Add(shuffled[crd]);
                    shuffled.Remove(shuffled[crd]);
                }
                    hands.Add(cDealt);
            }

            return hands;
        }

        public void Play()
        {
            List<List<Card>> hands=Deal(2,7);

           

            int p1Total = 0;
            int p2Total = 0;
            Console.Write("Player 1: ");
            for (int p1=0; p1<hands[0].Count; p1++)
            {
                p1Total += hands[0][p1].Value;
                Console.Write("{0}{1} ",hands[0][p1].Value,hands[0][p1].SuitSym());
            }
            Console.Write("  Total:  {0}",p1Total);
            Console.Write("\nPlayer 2: ");
            for (int p2=0; p2<hands[1].Count; p2++)
            {
                p2Total += hands[1][p2].Value;
                Console.Write("{0}{1} ", hands[1][p2].Value, hands[1][p2].SuitSym());
            }
            Console.Write("  Total:  {0}\n\n", p2Total);
            if (p1Total>p2Total)
                Console.WriteLine("Player 1 Wins");
            if (p1Total<p2Total)
                Console.WriteLine("Player 2 Wins");
            if (p1Total==p2Total)
                Console.WriteLine("Draw");
        }
    }
}