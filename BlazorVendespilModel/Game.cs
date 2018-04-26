using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorVendespilModel
{
    public class Game
    {
        public Game(Player player, int tiles)
        {
            Player = player;
            Tiles = tiles;
            if(tiles % 2 != 0)
            {
                tiles++;
            }
            GenerateBoard(tiles);
        }

        private void GenerateBoard(int tiles)
        {
            Cards = new Card[tiles];
            var tileIndexes = TileIndexes(tiles).ToList();
            var deck = DeckManager.GenerateDeck(tiles / 2);
            var rnd = new Random();

            while(tileIndexes.Count > 0)
            {
                var cardNumber = deck.Dequeue();
                AddCard(tileIndexes, rnd, cardNumber);
                AddCard(tileIndexes, rnd, cardNumber);

            }
        }

        private void AddCard(List<int> tileIndexes, Random rnd, int cardNumber)
        {
            var tileIndex = rnd.Next(0, tileIndexes.Count);
            Cards[tileIndex] = new Card(cardNumber);
            tileIndexes.RemoveAt(tileIndex);
        }

        private static IEnumerable<int> TileIndexes(int tiles)
        {
            for (int i = 0; i < tiles; i++)
                yield return i;
        }


        public Player Player { get; }
        public int Tiles { get; }

        public Card[] Cards { get; private set; }



    }
}
