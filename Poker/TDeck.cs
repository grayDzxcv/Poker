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
            //Console.WriteLine(gameDeck[index].getName());
            return gameDeck[index];
        }
        public TDeck shuffle()
        {
            TCard[] basicCards = this.getCards();
            TDeck shuffledDeck = new TDeck();
            TCard[] shuffledCards = shuffledDeck.getCards();
            Random rand = new Random();
            int counter = 51;
            int randRandIndex;
            while (counter >= 0)
            {
                randRandIndex = rand.Next(counter);
                shuffledCards[counter] = basicCards[randRandIndex];
                basicCards = delElem(basicCards, randRandIndex);
                counter--;
            }

            shuffledDeck.setCards(shuffledCards);
            return shuffledDeck;
        }
        private TCard[] delElem(TCard[] cards, int index)
        {
            TCard[] res = new TCard[cards.Length - 1];
            cards[index] = null;
            int counter = 0;
            for(int i = 0; i < cards.Length; i++)
            {
                if (i == index)
                    continue;
                res[counter] = cards[i];
                counter++;
            }
            return res;
        }
        private TCard[] getCards()
        {
            return gameDeck;
        }
        private void setCards(TCard[] gameDeck)
        {
            this.gameDeck = gameDeck;
        }        
        public void printDeck()
        {
            for (int i = 0; i < 52; i++)
            {
                Console.WriteLine(gameDeck[i].getCardName());
            }
        }
    }
}
