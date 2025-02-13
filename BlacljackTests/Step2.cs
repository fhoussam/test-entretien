using Blackjack;

namespace BlacljackTests
{
    [TestClass]
    public class Step2
    {
        [TestMethod]
        public void Should_have_fourteen_points_when_cards_are_eight_and_six()
        {
            ICard firstCard = new Card(Rank.Eight);
            ICard secondCard = new Card(Rank.Six);
            IHand hand = new Hand(new[] { firstCard, secondCard });

            Assert.IsTrue(14 == hand.GetPoints());
        }

        [TestMethod]
        public void Should_have_nineteen_points_when_cards_are_eight_and_six_and_five()
        {
            ICard firstCard = new Card(Rank.Eight);
            ICard secondCard = new Card(Rank.Six);
            ICard thirdCard = new Card(Rank.Five);
            IHand hand = new Hand(new[] { firstCard, secondCard });

            hand.AddCard(thirdCard);

            Assert.IsTrue(19 == hand.GetPoints());
        }

        [TestMethod]
        public void Should_have_seventeen_points_when_cards_are_four_and_five_and_two_and_six()
        {
            ICard firstCard = new Card(Rank.Four);
            ICard secondCard = new Card(Rank.Five);
            ICard thirdCard = new Card(Rank.Two);
            ICard fourthCard = new Card(Rank.Six);
            IHand hand = new Hand(new[] { firstCard, secondCard });

            hand.AddCard(thirdCard);
            hand.AddCard(fourthCard);

            Assert.IsTrue(17 == hand.GetPoints());
        }
    }
}
