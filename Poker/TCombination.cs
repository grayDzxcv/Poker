using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    class TCombination
    {
        private static int currentValue = 0;
        private static string comboName;

        private TCombination()
        {

        }
        public static string getCombination(TCard[] cards)
        {
            return comboName;
        }
        public static byte getValueCombination(TCard[] cards)
        {
            return 1;
        }
        private static void setComboName(string comboName)
        {
            TCombination.comboName = comboName;
        }
       
        private static void checkHighCard(TCard[] cards)
        {
            for (int i = 0; i < cards.Length; i++)
                if (currentValue < cards[i].getValue())
                    currentValue = cards[i].getValue();

            setComboName("Старшая карта " + TCard.getNameByValue(currentValue));
        }
        private static void checkPairCads(TCard[] cards)
        {

        }
        private static void checkTwoPairCads(TCard[] cards)
        {

        }
        private static void checkThreeOfAKind(TCard[] cards)
        {

        }
        private static void checkStraight(TCard[] cards)
        {

        }
        private static void checkFlush(TCard[] cards)
        {

        }
        private static void checkFullHouse(TCard[] cards)
        {

        }
        private static void checkFourOfAKind(TCard[] cards)
        {

        }
        private static void checkStraightFlush(TCard[] cards)
        {

        }
        private static void checkRoyalFlush(TCard[] cards)
        {

        }

    }
}
