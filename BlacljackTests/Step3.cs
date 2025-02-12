using Blackjack;

namespace BlacljackTests
{
    [TestClass]
    public class Step3
    {
        [TestMethod]
        public void Should_have_blackjack_when_cards_are_ace_and_ten()
        {
            ICard firstCard = new Card("A");
            ICard secondCard = new Card("10");
            IHand hand = new Hand(firstCard, secondCard);

            Assert.IsTrue(21 == hand.GetPoints());
            Assert.IsTrue(hand.IsBlackJack());
            Assert.IsFalse(hand.IsBusted());
        }

        [TestMethod]
        public void Should_not_have_blackjack_when_cards_are_ace_and_six_and_four()
        {
            ICard firstCard = new Card("A");
            ICard secondCard = new Card("6");
            ICard thirdCard = new Card("4");
            IHand hand = new Hand(firstCard, secondCard);

            hand.AddCard(thirdCard);

            Assert.IsTrue(21 == hand.GetPoints());
            Assert.IsFalse(hand.IsBlackJack());
            Assert.IsFalse(hand.IsBusted());
        }

        [TestMethod]
        public void Should_not_have_blackjack_when_cards_are_ace_and_eight()
        {
            ICard firstCard = new Card("A");
            ICard secondCard = new Card("8");
            IHand hand = new Hand(firstCard, secondCard);

            Assert.IsTrue(19 == hand.GetPoints());
            Assert.IsFalse(hand.IsBlackJack());
            Assert.IsFalse(hand.IsBusted());
        }

        [TestMethod]
        public void Should_be_busted_when_score_goes_above_21()
        {
            ICard firstCard = new Card("10");
            ICard secondCard = new Card("J");
            ICard thirdCard = new Card("2");
            IHand hand = new Hand(firstCard, secondCard);

            hand.AddCard(thirdCard);

            Assert.IsFalse(hand.IsBlackJack());
            Assert.IsTrue(hand.IsBusted());
        }
    }
}