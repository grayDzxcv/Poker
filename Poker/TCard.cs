using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Poker
{
    class TCard
    {
        private byte suit; //Буби, Крести, Черви, Пики
        private byte value; //2 3 4 5 6 7 8 9 10 Валет Дама Король
        private string image;
        private TCard()
        {

        }

        public TCard(byte suit, byte value)
        {
            this.suit = suit;
            this.value = value;
        }

        public byte getSuit()
        {
            return suit;
        }

        public byte getValue()
        {
            return value;
        }

        public string getImage()
        {
            return (suit + value).ToString();
        }

        public string getName()
        {
            return getValueName() + " " + getSuitName();
        }
        public string getSuitName()
        {
            switch (suit)
            {
                case 0: return "Буби";
                case 1: return "Крести";
                case 2: return "Черви";
                case 3: return "Пики";
            }

            return "";
        }

        public string getValueName()
        {
            switch (value)
            {
                case 0: return "2";
                case 1: return "3";
                case 2: return "4";
                case 3: return "5";
                case 4: return "6";
                case 5: return "7";
                case 6: return "8";
                case 7: return "9";
                case 8: return "10";
                case 9: return "Валет";
                case 10: return "Дама";
                case 11: return "Король";
                case 12: return "Туз";
            }

            return "";
        }


    }
}
