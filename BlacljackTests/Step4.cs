using Blackjack;

namespace BlacljackTests
{
    [TestClass]
    public class Step4
    {
        [TestMethod]
        public void Should_have_fifteen_when_cards_are_ten_and_four_and_ace()
        {
            ICard firstCard = new Card("10");
            ICard secondCard = new Card("4");
            ICard thirdCard = new Card("A");
            IHand hand = new Hand(firstCard, secondCard);

            hand.AddCard(thirdCard);

            Assert.IsTrue(15 == hand.GetPoints());
            Assert.IsFalse(hand.IsBlackJack());
            Assert.IsFalse(hand.IsBusted());
        }

        [TestMethod]
        public void Should_have_twenty_two_and_busted_when_cards_are_ten_and_four_and_seven_and_ace()
        {
            ICard firstCard = new Card("10");
            ICard secondCard = new Card("4");
            ICard thirdCard = new Card("7");
            ICard fourthCard = new Card("A");
            IHand hand = new Hand(firstCard, secondCard);

            hand.AddCard(thirdCard);
            hand.AddCard(fourthCard);

            Assert.IsTrue(22 == hand.GetPoints());
            Assert.IsFalse(hand.IsBlackJack());
            Assert.IsTrue(hand.IsBusted());
        }

        [TestMethod]
        public void Should_have_thirteen_when_cards_are_ace_and_ace_and_ace_and_ace()
        {
            ICard firstCard = new Card("A");
            ICard secondCard = new Card("A");
            ICard thirdCard = new Card("A");
            IHand hand = new Hand(firstCard, secondCard);

            hand.AddCard(thirdCard);

            Assert.IsTrue(13 == hand.GetPoints());
            Assert.IsFalse(hand.IsBlackJack());
            Assert.IsFalse(hand.IsBusted());
        }

        [TestMethod]
        public void Should_have_twelve_when_hand_already_contains_ace()
        {
            ICard firstCard = new Card("A");
            ICard secondCard = new Card("A");
            ICard thirdCard = new Card("10");
            IHand hand = new Hand(firstCard, secondCard);

            hand.AddCard(thirdCard);

            Assert.IsTrue(12 == hand.GetPoints());
            Assert.IsFalse(hand.IsBlackJack());
            Assert.IsFalse(hand.IsBusted());
        }


        [TestMethod]
        public void Should_have_fourteen_when_all_cards_are_aces()
        {
            ICard firstCard = new Card("A");
            ICard secondCard = new Card("A");
            ICard thirdCard = new Card("A");
            ICard lastCard = new Card("A");
            IHand hand = new Hand(firstCard, secondCard);

            hand.AddCard(thirdCard);
            hand.AddCard(lastCard);

            Assert.IsTrue(14 == hand.GetPoints());
            Assert.IsFalse(hand.IsBlackJack());
            Assert.IsFalse(hand.IsBusted());
        }
    }
}