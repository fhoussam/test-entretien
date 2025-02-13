namespace Blackjack
{
    public class Card : ICard
    {
        private string value;

        public Card(string value)
        {
            this.value = value;
        }

        public int GetPoints()
        {
            return 2;
        }
    }
}
