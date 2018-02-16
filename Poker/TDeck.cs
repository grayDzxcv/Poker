using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    class TDeck
    {
        private TCard[] gameDeck = new TCard[52];

        public TDeck()
        {
            int counter = 0;
            for (byte i = 0; i < 4; i++)
            {
                for (byte j = 0; j < 13; j++)
                {
                    gameDeck[counter] = new TCard(i, j);
                    counter++;
                }
            }
        }

        public TCard getCardByNumber(int index)
        {
            Console.WriteLine(gameDeck[index].getName());
            return gameDeck[index];
        }

        //Перетасовка колоды
        public void shuffle()
        {
            int index = 0;
            int iterCount = 51;
            int nextRand;
            TCard tmp;
            Random rand = new Random();
            while (index < 52)
            {
                nextRand = rand.Next(iterCount);
                tmp = gameDeck[index];
                gameDeck[index] = gameDeck[nextRand];
                gameDeck[index] = tmp;
                iterCount--;
                index++;
            }
        }
 
    }
}
