using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    class TGame
    {
        private TPlayer player;
        private TPlayer comuter1;
        private TPlayer comuter2;
        private TDeck deck;
        //Карты на столе
        private TCard[] table;
        //Раздача
        private int distribution = 1;
        private double blind = 2;

        public TGame()
        {
            player = new TPlayer();
            comuter1 = new TPlayer();
            comuter2 = new TPlayer();
            gameProcess();
        }

        private void checkBlind()
        {
            if (distribution % 4 == 0)
                blind *= 2;
        }
        
        private void nextDistribution()
        {
            distribution++;
        }

        private void gameProcess()
        {
            deck = new TDeck();
            table = new TCard[5];
            preflop();
            flop();
            river();
        }

        private void preflop()
        {
            player.setHand(deck.getCardByNumber(0), deck.getCardByNumber(1));
            comuter1.setHand(deck.getCardByNumber(2), deck.getCardByNumber(3));
            comuter2.setHand(deck.getCardByNumber(4), deck.getCardByNumber(5));
        }

        private void flop()
        {
            table[0] = deck.getCardByNumber(6);
            table[1] = deck.getCardByNumber(7);
            table[2] = deck.getCardByNumber(8);
        }

        private void turn()
        {
            table[3] = deck.getCardByNumber(9);
        }

        private void river()
        {
            table[4] = deck.getCardByNumber(10);
        }



    }
}
