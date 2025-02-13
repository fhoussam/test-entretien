//using Blackjack;

//namespace BlacljackTests
//{
//    [TestClass]
//    public class Step1
//    {
//        [TestMethod]
//        public void Should_value_two_when_card_displays_two()
//        {
//            ICard card = new Card(Rank.Two);
//            Assert.IsTrue(2 == card.GetPoints());
//        }

//        [TestMethod]
//        public void Should_value_seven_when_card_displays_seven()
//        {
//            ICard card = new Card(Rank.Seven);
//            Assert.IsTrue(7 == card.GetPoints());
//        }

//        [TestMethod]
//        public void Should_value_ten_when_card_displays_ten()
//        {
//            ICard card = new Card(Rank.Ten);
//            Assert.IsTrue(10 == card.GetPoints());
//        }

//        [TestMethod]
//        public void Should_value_ten_when_card_displays_king()
//        {
//            ICard card = new Card(Rank.King);
//            Assert.IsTrue(10 == card.GetPoints());
//        }

//        [TestMethod]
//        public void Should_value_one_when_card_displays_ace()
//        {
//            ICard card = new Card(Rank.Ace);
//            Assert.IsTrue(1 == card.GetPoints());
//        }
//    }
//}