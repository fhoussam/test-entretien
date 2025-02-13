using Blackjack;

namespace BlacljackTests
{
    [TestClass]
    public class Step3
    {
        [TestMethod]
        public void Should_have_blackjack_when_cards_are_ace_and_ten()
        {
            ICard firstCard = new Card(Rank.Ace);
            ICard secondCard = new Card(Rank.Ten);
            IHand hand = new Hand(new[] { firstCard, secondCard });

            Assert.IsTrue(21 == hand.GetPoints());
            Assert.IsTrue(hand.IsBlackJack());
            Assert.IsFalse(hand.IsBusted());
        }

        [TestMethod]
        public void Should_not_have_blackjack_when_cards_are_ace_and_six_and_four()
        {
            ICard firstCard = new Card(Rank.Ace);
            ICard secondCard = new Card(Rank.Six);
            ICard thirdCard = new Card(Rank.Four);
            IHand hand = new Hand(new[] { firstCard, secondCard });

            hand.AddCard(thirdCard);

            Assert.IsTrue(21 == hand.GetPoints());
            Assert.IsFalse(hand.IsBlackJack());
            Assert.IsFalse(hand.IsBusted());
        }

        [TestMethod]
        public void Should_not_have_blackjack_when_cards_are_ace_and_eight()
        {
            ICard firstCard = new Card(Rank.Ace);
            ICard secondCard = new Card(Rank.Eight);
            IHand hand = new Hand(new[] { firstCard, secondCard });

            Assert.IsTrue(19 == hand.GetPoints());
            Assert.IsFalse(hand.IsBlackJack());
            Assert.IsFalse(hand.IsBusted());
        }

        [TestMethod]
        public void Should_be_busted_when_score_goes_above_21()
        {
            ICard firstCard = new Card(Rank.Ten);
            ICard secondCard = new Card(Rank.Jack);
            ICard thirdCard = new Card(Rank.Two);
            IHand hand = new Hand(new[] { firstCard, secondCard });

            hand.AddCard(thirdCard);

            Assert.IsFalse(hand.IsBlackJack());
            Assert.IsTrue(hand.IsBusted());
        }
    }
}