using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BestHandV2
{
    class _Output
    {

        public static void ConsoleIt(string strAdd, dynamic deck)
        {
            int count = 0;
            Console.WriteLine("{0}",strAdd);
            foreach (Card item in deck)
            {
                Console.WriteLine("Card {2}:   {0} of {1}", item.Value, item.SuitSym(),count);
                count++;
            }

           Console.WriteLine("Total Cards:  {0}", deck.Count);
        }
    }
}
