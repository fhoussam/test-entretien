using Blackjack;

namespace BlacljackTests
{
    [TestClass]
    public class Step1
    {
        [TestMethod]
        public void Should_value_two_when_card_displays_two()
        {
            ICard card = new Card("2");
            Assert.IsTrue(2 == card.GetPoints());
        }

        [TestMethod]
        public void Should_value_seven_when_card_displays_seven()
        {
            ICard card = new Card("7");
            Assert.IsTrue(7 == card.GetPoints());
        }

        [TestMethod]
        public void Should_value_ten_when_card_displays_ten()
        {
            ICard card = new Card("10");
            Assert.IsTrue(10 == card.GetPoints());
        }

        [TestMethod]
        public void Should_value_ten_when_card_displays_king()
        {
            ICard card = new Card("K");
            Assert.IsTrue(10 == card.GetPoints());
        }

        [TestMethod]
        public void Should_value_ten_when_card_displays_ace()
        {
            ICard card = new Card("A");
            Assert.IsTrue(10 == card.GetPoints());
        }
    }
}