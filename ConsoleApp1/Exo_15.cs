namespace ConsoleApp1
{
    //Webnet (fizz buzz)
    public class Exo_15
    {
        public static void Main()
        {
            int[] input = [ 1, 4, 3, 7, 5, 11, 15 ];
            Console.WriteLine(Webnet(input));
        }

        public static string Webnet(int[] input) 
        {
            var items = input.Select(x => 
            x % 3 == 0 ? "WEB" 
            : x % 5 == 0 ? "NET" 
            : x.ToString());
            var result = string.Join(string.Empty, items);
            return result;
        }
    }
}
