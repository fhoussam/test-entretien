using Blackjack;

namespace BlacljackTests
{
    [TestClass]
    public class Step2
    {
        [TestMethod]
        public void Should_have_fourteen_points_when_cards_are_eight_and_six()
        {
            ICard firstCard = new Card("8");
            ICard secondCard = new Card("6");
            IHand hand = new Hand(firstCard, secondCard);

            Assert.IsTrue(14 == hand.GetPoints());
        }

        [TestMethod]
        public void Should_have_nineteen_points_when_cards_are_eight_and_six_and_five()
        {
            ICard firstCard = new Card("8");
            ICard secondCard = new Card("6");
            ICard thirdCard = new Card("5");
            IHand hand = new Hand(firstCard, secondCard);

            hand.AddCard(thirdCard);

            Assert.IsTrue(19 == hand.GetPoints());
        }

        [TestMethod]
        public void Should_have_seventeen_points_when_cards_are_four_and_five_and_two_and_six()
        {
            ICard firstCard = new Card("4");
            ICard secondCard = new Card("5");
            ICard thirdCard = new Card("2");
            ICard fourthCard = new Card("6");
            IHand hand = new Hand(firstCard, secondCard);

            hand.AddCard(thirdCard);
            hand.AddCard(fourthCard);

            Assert.IsTrue(17 == hand.GetPoints());
        }
    }
}
