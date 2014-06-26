namespace Poker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            if (hand.Cards.Count != 5)
            {
                return false;
            }

            for (int i = 0; i < hand.Cards.Count; i++)
            {
                for (int j = i + 1; j < hand.Cards.Count; j++)
                {
                    if (hand.Cards[i].Face == hand.Cards[j].Face && hand.Cards[i].Suit == hand.Cards[j].Suit)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool IsStraightFlush(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            int countFacesMax = CalculateFacesMaxCountInHand(hand);
            int countOfFacesTotal = CalculateCountDifferentCardsFaces(hand);
            int coutOfSuits = CalculateCountDifferentCardsSuits(hand);
            if (countFacesMax == 1 && countOfFacesTotal == 5 && coutOfSuits == 1 && IsConsecutive(hand))
            {
                return true;
            }

            return false;
        }

        public bool IsFourOfAKind(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            int countFacesMax = CalculateFacesMaxCountInHand(hand);
            if (countFacesMax == 4)
            {
                return true;
            }

            return false;
        }

        public bool IsFullHouse(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            int countFacesMax = CalculateFacesMaxCountInHand(hand);
            int countOfFacesTotal = CalculateCountDifferentCardsFaces(hand);
            if (countFacesMax == 3 && countOfFacesTotal == 2)
            {
                return true;
            }

            return false;
        }

        public bool IsFlush(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            int countSuitMax = CalculateSuitMaxCountInHand(hand);
            if (countSuitMax == 5)
            {
                return true;
            }

            return false;
        }

        public bool IsStraight(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            int countFacesMax = CalculateFacesMaxCountInHand(hand);
            int countOfFacesTotal = CalculateCountDifferentCardsFaces(hand);
            int coutOfSuits = CalculateCountDifferentCardsSuits(hand);
            if (countFacesMax == 1 && countOfFacesTotal == 5 && coutOfSuits != 1 && IsConsecutive(hand))
            {
                return true;
            }

            return false;
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            if (!this.IsValidHand(hand) || this.IsFullHouse(hand))
            {
                return false;
            }

            int countFacesMax = CalculateFacesMaxCountInHand(hand);
            if (countFacesMax == 3)
            {
                return true;
            }

            return false;
        }

        public bool IsTwoPair(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            int countFacesMax = CalculateFacesMaxCountInHand(hand);
            int countOfFacesTotal = CalculateCountDifferentCardsFaces(hand);
            if (countFacesMax == 2 && countOfFacesTotal == 3)
            {
                return true;
            }

            return false;
        }

        public bool IsOnePair(IHand hand)
        {
            if (!this.IsValidHand(hand) || this.IsFullHouse(hand) || this.IsTwoPair(hand))
            {
                return false;
            }

            int countFacesMax = CalculateFacesMaxCountInHand(hand);
            int countOfFacesTotal = CalculateCountDifferentCardsFaces(hand);
            if (countFacesMax == 2 && countOfFacesTotal == 4)
            {
                return true;
            }

            return false;
        }

        public bool IsHighCard(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            int countFacesMax = CalculateFacesMaxCountInHand(hand);
            int countOfFacesTotal = CalculateCountDifferentCardsFaces(hand);
            if (countFacesMax == 1 && countOfFacesTotal == 5 && !IsConsecutive(hand))
            {
                return true;
            }

            return false;
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            HandStrenght firstHandStrenght = this.CheckHandStrenght(firstHand);
            HandStrenght secondHandStrenght = this.CheckHandStrenght(secondHand);

            if (firstHandStrenght > secondHandStrenght)
            {
                return -1;
            }

            if (firstHandStrenght == secondHandStrenght)
            {
                return 0;
            }

            return 1;
        }

        public HandStrenght CheckHandStrenght(IHand hand)
        {
            if (this.IsStraightFlush(hand))
            {
                return HandStrenght.StraightFlush;
            }
            else if (this.IsFourOfAKind(hand))
            {
                return HandStrenght.FourOfAKind;
            }
            else if (this.IsFullHouse(hand))
            {
                return HandStrenght.FullHouse;
            }
            else if (this.IsFlush(hand))
            {
                return HandStrenght.Flush;
            }
            else if (this.IsStraight(hand))
            {
                return HandStrenght.Straight;
            }
            else if (this.IsThreeOfAKind(hand))
            {
                return HandStrenght.ThreeOfAKind;
            }
            else if (this.IsTwoPair(hand))
            {
                return HandStrenght.TwoPair;
            }
            else if (this.IsOnePair(hand))
            {
                return HandStrenght.OnePair;
            }
            else
            {
                return HandStrenght.HighCard;
            }
        }

        private static int CalculateFacesMaxCountInHand(IHand hand)
        {
            Dictionary<string, int> cardFaces = CalculateCountOfAllCardDifferentFaces(hand);

            int maxCardOftype = cardFaces.Values.Max();

            return maxCardOftype;
        }

        private static int CalculateCountDifferentCardsFaces(IHand hand)
        {
            Dictionary<string, int> cardFaces = CalculateCountOfAllCardDifferentFaces(hand);

            int cardFacesCountInHand = cardFaces.Count();

            return cardFacesCountInHand;
        }

        private static Dictionary<string, int> CalculateCountOfAllCardDifferentFaces(IHand hand)
        {
            Dictionary<string, int> cardFaces = new Dictionary<string, int>();
            for (int i = 0; i < hand.Cards.Count; i++)
            {
                ICard currentCard = hand.Cards[i];
                string currentCardFace = currentCard.Face.ToString();
                if (cardFaces.ContainsKey(currentCardFace))
                {
                    cardFaces[currentCardFace]++;
                }
                else
                {
                    cardFaces.Add(currentCardFace, 1);
                }
            }

            return cardFaces;
        }

        private static int CalculateSuitMaxCountInHand(IHand hand)
        {
            Dictionary<string, int> cardSuits = CalculateCountAllDifferentSuitsInHand(hand);

            int maxCountOfSuit = cardSuits.Values.Max();

            return maxCountOfSuit;
        }

        private static int CalculateCountDifferentCardsSuits(IHand hand)
        {
            Dictionary<string, int> cardSuits = CalculateCountAllDifferentSuitsInHand(hand);

            int cardSuitsCountInHand = cardSuits.Count();

            return cardSuitsCountInHand;
        }

        private static Dictionary<string, int> CalculateCountAllDifferentSuitsInHand(IHand hand)
        {
            Dictionary<string, int> cardSuits = new Dictionary<string, int>();
            for (int i = 0; i < hand.Cards.Count; i++)
            {
                ICard currentCard = hand.Cards[i];
                string currentCardSuit = currentCard.Suit.ToString();
                if (cardSuits.ContainsKey(currentCardSuit))
                {
                    cardSuits[currentCardSuit]++;
                }
                else
                {
                    cardSuits.Add(currentCardSuit, 1);
                }
            }

            return cardSuits;
        }

        private static bool IsConsecutive(IHand hand)
        {
            Dictionary<string, int> cardFaces = CalculateCountOfAllCardDifferentFaces(hand);

            int countconsequative = 1;
            for (int i = 1; i < hand.Cards.Count; i++)
            {
                ICard currentCard = hand.Cards[i];
                string currentCardFace = currentCard.Face.ToString();

                string previous = CalculatePreviousCard(currentCardFace);
                if (cardFaces.ContainsKey(previous))
                {
                    countconsequative++;
                }
            }

            if (countconsequative == 4)
            {
                return true;
            }

            return false;
        }

        private static string CalculatePreviousCard(string previousCardFace)
        {
            switch (previousCardFace)
            {
                case "Ace": return "King";
                case "King": return "Queen";
                case "Queen": return "Jack";
                case "Jack": return "Ten";
                case "Ten": return "Nine";
                case "Nine": return "Eight";
                case "Eight": return "Seven";
                case "Seven": return "Six";
                case "Six": return "Five";
                case "Five": return "Four";
                case "Four": return "Three";
                case "Three": return "Two";
                case "Two": return "Ace";
            }

            throw new ArgumentOutOfRangeException("Invalid Face of the card!");
        }
    }
}