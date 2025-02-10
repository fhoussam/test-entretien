namespace ConsoleApp1
{
    public class Exo_10
    {
        public static void Main()
        {
            var m = new Dictionary<object, int>();
            var o1 = new object();
            var o2 = o1;
            m[o1] = 1;
            m[o2] = 2;
            Console.WriteLine(m[o1]);
        }
    }
}
