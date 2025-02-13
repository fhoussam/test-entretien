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
            var parsed = int.TryParse(value, out var val);
            if (parsed)
            {
                return val;
            }
            else if (value == "K" || value == "J")
            {
                return 10;
            }
            else if (value == "A")
            {
                return 11;
            }

            throw new Exception("wrong value format");
        }

        public bool IsAce()
        {
            return value == "A";
        }

        public bool IsFaceValue()
        {
            return value == "J" || value == "Q" || value == "K";
        }
    }
}
