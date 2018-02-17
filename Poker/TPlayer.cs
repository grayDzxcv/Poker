using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    class TPlayer
    {
        private string name;
        private string image;
        private TCard[] hand = new TCard[2];
        private double money;

        private static byte[] reserved = { 0, 0, 0 };

        public TPlayer()
        {
            getRandomName();
            this.image = name;
            this.money = 10000d;
        }

        private void getRandomName()
        {
            Random rnd = new Random();
            int k = rnd.Next(1, 8);
            label:
            while(true)
            {
                for(int i = 0; i < 3; i++)
                {
                    if (k == TPlayer.reserved[i])
                    {
                        k = rnd.Next(1, 8);
                        goto label;
                    }
                }
                break;
            }
            switch(k)
            {
                case 1: this.name =  "Черный плащ"; break;
                case 2: this.name = "Чип"; break;
                case 3: this.name = "Диппер"; break;
                case 4: this.name = "Скрудж"; break;
                case 5: this.name = "Норберт"; break;
                case 6: this.name = "Котопес"; break;
                case 7: this.name = "Арнольд"; break;
                case 8: this.name = "Джинджер"; break;
            }
            
        }

        public void setHand(TCard[] twoCards)
        {
            this.hand[0] = twoCards[0];
            this.hand[1] = twoCards[1];
        }

        public void setMoney(double money)
        {
            this.money = money;
        }
        
        public double getMoney()
        {
            return money;
        }

        public string getCards()
        {
            return "Карты игрока " + name + ":" +hand[0].getName() + ", " + hand[1].getName();
        }
    }
}
