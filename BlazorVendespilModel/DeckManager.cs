using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlazorVendespilModel
{
    public static class DeckManager
    {
        public static IEnumerable<int> AllCards()
        {
            for (int i = 0; i < 52; i++)
                yield return i;
        }

        public static Queue<int> GenerateDeck(int number)
        {
            var deckQueue = new Queue<int>();
            var allCards = AllCards().ToList();
            var rnd = new Random();
            for(int idx =0; idx < number; idx++)
            {
                int cardNumber = rnd.Next(0, allCards.Count);

                deckQueue.Enqueue(allCards[cardNumber]);
                allCards.RemoveAt(cardNumber);
            }
            return deckQueue;
        }

    }
}
