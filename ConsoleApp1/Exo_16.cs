namespace ConsoleApp1
{
    //IsReversable
    public class Exo_16
    {
        public static void Main()
        {
            var result_1 = IsReversable("kayak");
            var result_2 = IsReversable("houssam");
            Console.WriteLine($"kayak : {result_1}");
            Console.WriteLine($"houssam : {result_2}");
        }

        public static bool IsReversable(string input)
        {
            return new String(input?.Reverse().ToArray()) == input;
        }
    }
}
