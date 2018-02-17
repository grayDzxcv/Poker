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
        private int suit; //Буби, Крести, Черви, Пики
        private int value; //2 3 4 5 6 7 8 9 10 Валет Дама Король

        private TCard()
        {

        }
        public TCard(int suit, int value)
        {
            this.suit = suit;
            this.value = value;
        }

        public int getSuit()
        {
            return suit;
        }
        public int getValue()
        {
            return value;
        }
        public void setSuit(byte suit)
        {
            this.suit = suit;
        }
        public void setValue(byte value)
        {
            this.value = value;
        }

        public string getCardName()
        {
            string strSuit = "";
            string strValue = "";

            switch (suit)
            {
                case 0:
                    {
                        strSuit = "Буби";
                        break;
                    }
                case 1:
                    {
                        strSuit = "Крести";
                        break;
                    }
                case 2:
                    {
                        strSuit = "Черви";
                        break;
                    }
                case 3:
                    {
                        strSuit = "Пики";
                        break;
                    }
            }
            switch (value)
            {
                case 0:
                    {
                        strValue = "2";
                        break;
                    }
                case 1:
                    {
                        strValue = "3";
                        break;
                    }
                case 2:
                    {
                        strValue = "4";
                        break;
                    }
                case 3:
                    {
                        strValue = "5";
                        break;
                    }
                case 4:
                    {
                        strValue = "6";
                        break;
                    }
                case 5:
                    {
                        strValue = "7";
                        break;
                    }
                case 6:
                    {
                        strValue = "8";
                        break;
                    }
                case 7:
                    {
                        strValue = "9";
                        break;
                    }
                case 8:
                    {
                        strValue = "10";
                        break;
                    }
                case 9:
                    {
                        strValue = "Валет";
                        break;
                    }
                case 10:
                    {
                        strValue = "Дама";
                        break;
                    }
                case 11:
                    {
                        strValue = "Король";
                        break;
                    }
                case 12:
                    {
                        strValue = "Туз";
                        break;
                    }
            }

            return strValue + " " + strSuit;
        }
        
        

        public static string getNameByValue(int value)
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
