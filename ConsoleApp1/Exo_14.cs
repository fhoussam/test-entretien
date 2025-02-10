namespace ConsoleApp1
{
    public class Exo_14
    {
        public static void Main()
        {
            var result = Reshape(3, "abc de fghij");
            Console.WriteLine(result);
        }

        public static string Reshape(int chunkSize, string input) 
        {
            var chunks = input.Replace(" ", "").Chunk(chunkSize);
            var result = string.Join("\n", chunks.Select(x => new string(x)));
            return result;
        }
    }
}
