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
        private TPlayer computer;
        private TPlayer computer2;
        private TDeck deck;
        //Карты на столе
        private TCard[] table;
        //Раздача
        private int distribution;
        private double blind;
        private int nBlind;
        private static int cardNumber = 0;

        public TGame()
        {
            firstInitialization();
            while(true)
            {
                console("Раздача №:" + distribution);
                deck = deck.shuffle();
                deck.printDeck();
                getBlindes(nBlind);
                preflop();
                console(player.getCards());



                
                break;
            }




        }

        private void preflop()
        {
            player.setHand(getCards());
            computer.setHand(getCards());
            computer2.setHand(getCards());
        }
        private void getBlindes(int nBlind)
        {
            switch (nBlind)
            {
                case 0:
                    {
                        player.setMoney(player.getMoney() - blind);
                        break;
                    }
                case 1:
                    {
                        computer.setMoney(computer.getMoney() - blind);
                        break;
                    }
                case 2:
                    {
                        computer2.setMoney(computer2.getMoney() - blind);
                        break;
                    }
            }
        }

        private void firstInitialization()
        {
            player = new TPlayer();
            computer = new TPlayer();
            computer2 = new TPlayer();
            deck = new TDeck();
            blind = 2;
            distribution = 1;
            nBlind = 0;
            cardNumber = 0;
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

        

        private void flop()
        {
           
        }

        private void turn()
        {
          
        }

        private void river()
        {
           
        }

        private void console(string str)
        {
            Console.WriteLine(str);
        }

        private int getCardNumber()
        {
            return TGame.cardNumber++;
        }

        private TCard[] getCards()
        {
            TCard[] twoCards = {deck.getCardByNumber(getCardNumber()), deck.getCardByNumber(getCardNumber())};
            return twoCards;
        }
    }
}
