namespace PokerTest
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;

    [TestClass]
    public class PokerHandsCheckerTest
    {
        [TestMethod]
        public void IsValidHandTestWith5DifferentCards()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Hearts)
            });

            bool expectedValidHand = true;
            bool actual;
            actual = checker.IsValidHand(hand);
            Assert.AreEqual(expectedValidHand, actual);
        }

        [TestMethod]
        public void IsValidHandTestWith5DifferentCardsTwoSameFaces()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Hearts)
            });

            bool expectedValidHand = true;
            bool actual;
            actual = checker.IsValidHand(hand);
            Assert.AreEqual(expectedValidHand, actual);
        }

        [TestMethod]
        public void IsValidHandTestWith5DifferentCardsAllSameSiuts()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Hearts),
                new Card(CardFace.Seven, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Hearts)
            });

            bool expectedValidHand = true;
            bool actual;
            actual = checker.IsValidHand(hand);
            Assert.AreEqual(expectedValidHand, actual);
        }

        [TestMethod]
        public void IsValidHandTestWithZeroCards()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>());
            bool expectedValidHand = false;
            bool actual;
            actual = checker.IsValidHand(hand);
            Assert.AreEqual(expectedValidHand, actual);
        }

        [TestMethod]
        public void IsValidHandTestWithOneCard()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Queen, CardSuit.Hearts)
            });
            bool expectedValidHand = false;
            bool actual;
            actual = checker.IsValidHand(hand);
            Assert.AreEqual(expectedValidHand, actual);
        }

        [TestMethod]
        public void IsValidHandTestWithFourCards()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts)
            });
            bool expectedValidHand = false;
            bool actual;
            actual = checker.IsValidHand(hand);
            Assert.AreEqual(expectedValidHand, actual);
        }

        [TestMethod]
        public void IsValidHandTestWithFiveSameCards()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Spades)
            });

            bool expectedValidHand = false;
            bool actual;
            actual = checker.IsValidHand(hand);
            Assert.AreEqual(expectedValidHand, actual);
        }

        [TestMethod]
        public void IsFourOfAKindTestNotValidHand()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Spades)
            });

            bool expectedFourOfAKindHand = false;
            bool actual;
            actual = checker.IsFourOfAKind(hand);
            Assert.AreEqual(expectedFourOfAKindHand, actual);
        }

        [TestMethod]
        public void IsFourOfAKindTestValidHandTwoPairs()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Spades)
            });

            bool expectedFourOfAKindHand = false;
            bool actual;
            actual = checker.IsFourOfAKind(hand);
            Assert.AreEqual(expectedFourOfAKindHand, actual);
        }

        [TestMethod]
        public void IsFourOfAKindTestValidHand()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Hearts)
            });

            bool expectedFourOfAKindHand = true;
            bool actual;
            actual = checker.IsFourOfAKind(hand);
            Assert.AreEqual(expectedFourOfAKindHand, actual);
        }

        [TestMethod]
        public void IsFlushTestValidHand()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Spades)
            });

            bool expectedIsFlush = true;
            bool actual;
            actual = checker.IsFlush(hand);
            Assert.AreEqual(expectedIsFlush, actual);
        }

        [TestMethod]
        public void IsNotFlushTest()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Spades)
            });

            bool expectedIsFlush = false;
            bool actual;
            actual = checker.IsFlush(hand);
            Assert.AreEqual(expectedIsFlush, actual);
        }

        [TestMethod]
        public void IsFlushTestNotValidHand()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Spades)
            });

            bool expectedIsFlush = false;
            bool actual;
            actual = checker.IsFlush(hand);
            Assert.AreEqual(expectedIsFlush, actual);
        }

        [TestMethod]
        public void IsThreeOfAKindTestNotValidHand()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds)
            });

            bool expectedIsThreeOfAKind = false;
            bool actual;
            actual = checker.IsThreeOfAKind(hand);
            Assert.AreEqual(expectedIsThreeOfAKind, actual);
        }

        [TestMethod]
        public void IsThreeOfAKindTestValidHand()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Spades)
            });

            bool expectedIsThreeOfAKind = true;
            bool actual;
            actual = checker.IsThreeOfAKind(hand);
            Assert.AreEqual(expectedIsThreeOfAKind, actual);
        }

        [TestMethod]
        public void IsThreeOfAKindTestValidHandFullHouse()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Spades)
            });

            bool expectedIsThreeOfAKind = false;
            bool actual;
            actual = checker.IsThreeOfAKind(hand);
            Assert.AreEqual(expectedIsThreeOfAKind, actual);
        }

        [TestMethod]
        public void IsNotThreeOfAKindTestValidHand()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Spades)
            });

            bool expectedIsThreeOfAKind = false;
            bool actual;
            actual = checker.IsThreeOfAKind(hand);
            Assert.AreEqual(expectedIsThreeOfAKind, actual);
        }

        [TestMethod]
        public void IsFullHouseTestValidHand()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Spades)
            });

            bool expectedIsFullHouse = true;
            bool actual;
            actual = checker.IsFullHouse(hand);
            Assert.AreEqual(expectedIsFullHouse, actual);
        }

        [TestMethod]
        public void IsFullHouseTestNotValidHand()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Clubs)
            });

            bool expectedIsFullHouse = false;
            bool actual;
            actual = checker.IsFullHouse(hand);
            Assert.AreEqual(expectedIsFullHouse, actual);
        }

        [TestMethod]
        public void IsNotFullHouseTestValidHand()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Spades)
            });

            bool expectedIsFullHouse = false;
            bool actual;
            actual = checker.IsFullHouse(hand);
            Assert.AreEqual(expectedIsFullHouse, actual);
        }

        [TestMethod]
        public void IsTwoPairsTestValidHand()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Spades)
            });

            bool expectedIsTwoPairs = true;
            bool actual;
            actual = checker.IsTwoPair(hand);
            Assert.AreEqual(expectedIsTwoPairs, actual);
        }

        [TestMethod]
        public void IsNotTwoPairsTestValidHand()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Spades)
            });

            bool expectedIsTwoPairs = false;
            bool actual;
            actual = checker.IsTwoPair(hand);
            Assert.AreEqual(expectedIsTwoPairs, actual);
        }

        [TestMethod]
        public void IsNotTwoPairsTestNotValidHand()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Spades)
            });

            bool expectedIsTwoPairs = false;
            bool actual;
            actual = checker.IsTwoPair(hand);
            Assert.AreEqual(expectedIsTwoPairs, actual);
        }

        [TestMethod]
        public void IsOnePairTestValidHand()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Spades)
            });

            bool expectedIsOnePair = true;
            bool actual;
            actual = checker.IsOnePair(hand);
            Assert.AreEqual(expectedIsOnePair, actual);
        }

        [TestMethod]
        public void IsNotOnePairTestValidHandTwoPairs()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Spades)
            });

            bool expectedIsOnePair = false;
            bool actual;
            actual = checker.IsOnePair(hand);
            Assert.AreEqual(expectedIsOnePair, actual);
        }

        [TestMethod]
        public void IsNotOnePairTestValidHandFullHouse()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Spades)
            });

            bool expectedIsOnePair = false;
            bool actual;
            actual = checker.IsOnePair(hand);
            Assert.AreEqual(expectedIsOnePair, actual);
        }

        [TestMethod]
        public void IsNotOnePairTestNotValidHand()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Spades)
            });

            bool expectedIsOnePair = false;
            bool actual;
            actual = checker.IsOnePair(hand);
            Assert.AreEqual(expectedIsOnePair, actual);
        }

        [TestMethod]
        public void IsNotOnePairValidHandThreeOfAKind()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Spades)
            });

            bool expectedIsIsOnePair = false;
            bool actual;
            actual = checker.IsOnePair(hand);
            Assert.AreEqual(expectedIsIsOnePair, actual);
        }

        [TestMethod]
        public void IsHighCardTestNotValidHand()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Spades)
            });

            bool expectedIsHighCard = false;
            bool actual;
            actual = checker.IsHighCard(hand);
            Assert.AreEqual(expectedIsHighCard, actual);
        }

        [TestMethod]
        public void IsHighCardTestValidHand()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Spades)
            });

            bool expectedIsHighCard = true;
            bool actual;
            actual = checker.IsHighCard(hand);
            Assert.AreEqual(expectedIsHighCard, actual);
        }

        [TestMethod]
        public void IsNotHighCardTestValidHand()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Spades)
            });

            bool expectedIsHighCard = false;
            bool actual;
            actual = checker.IsHighCard(hand);
            Assert.AreEqual(expectedIsHighCard, actual);
        }

        [TestMethod]
        public void IsStraightTestValidHandFromTwoToAce()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Spades)
            });

            bool expectedIsStraight = true;
            bool actual;
            actual = checker.IsStraight(hand);
            Assert.AreEqual(expectedIsStraight, actual);
        }

        [TestMethod]
        public void IsStraightTestValidHandFromSevenToJack()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Nine, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Spades)
            });

            bool expectedIsStraight = true;
            bool actual;
            actual = checker.IsStraight(hand);
            Assert.AreEqual(expectedIsStraight, actual);
        }

        [TestMethod]
        public void IsStraightTestNotValidHand()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Spades)
            });

            bool expectedIsStraight = false;
            bool actual;
            actual = checker.IsStraight(hand);
            Assert.AreEqual(expectedIsStraight, actual);
        }

        [TestMethod]
        public void IsNotStraightTestValidHand()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Spades)
            });

            bool expectedIsStraight = false;
            bool actual;
            actual = checker.IsStraight(hand);
            Assert.AreEqual(expectedIsStraight, actual);
        }

        [TestMethod]
        public void IsNotStraightTestValidHandFromThreeToEight()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Spades)
            });

            bool expectedIsStraight = false;
            bool actual;
            actual = checker.IsStraight(hand);
            Assert.AreEqual(expectedIsStraight, actual);
        }

        [TestMethod]
        public void IsNotStraightFlushTestValidHand()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Spades)
            });

            bool expectedIsStraightFlush = false;
            bool actual;
            actual = checker.IsStraightFlush(hand);
            Assert.AreEqual(expectedIsStraightFlush, actual);
        }

        [TestMethod]
        public void IsStraightFlushTestValidNotHand()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Spades)
            });

            bool expectedIsStraightFlush = false;
            bool actual;
            actual = checker.IsStraightFlush(hand);
            Assert.AreEqual(expectedIsStraightFlush, actual);
        }

        [TestMethod]
        public void IsStraightFlushTestValidHand()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Spades)
            });

            bool expectedIsStraightFlush = true;
            bool actual;
            actual = checker.IsStraightFlush(hand);
            Assert.AreEqual(expectedIsStraightFlush, actual);
        }

        [TestMethod]
        public void CompareHandsTestFirstBetterThanSecond()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand firstHand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Spades)
            });

            Hand secondHand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Spades)
            });

            int expectedResult = -1;
            int actual;
            actual = checker.CompareHands(firstHand, secondHand);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestMethod]
        public void CompareHandsTestSecondBetterThanFirst()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand firstHand = new Hand(new List<ICard>()
            {
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Clubs)
            });

            Hand secondHand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Spades)
            });

            int expectedResult = 1;
            int actual;
            actual = checker.CompareHands(firstHand, secondHand);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestMethod]
        public void CompareHandsTestSecondEqualToFirst()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            Hand firstHand = new Hand(new List<ICard>()
            {
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Clubs)
            });

            Hand secondHand = new Hand(new List<ICard>()
            {
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Clubs)
            });

            int expectedResult = 0;
            int actual;
            actual = checker.CompareHands(firstHand, secondHand);
            Assert.AreEqual(expectedResult, actual);
        }
    }
}