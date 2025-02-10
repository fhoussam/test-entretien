namespace ConsoleApp1
{
    //calculate sum between index
    public class Exo_9
    {
        public static void Main()
        {
            int[] array = { 0, 1, 2, 3, 4, 5, 3 };
            Console.WriteLine(Exo_9.calc(array, 0, 1)); // 1
            Console.WriteLine(Exo_9.calc(array, 0, 5)); // 15
            Console.WriteLine(Exo_9.calc(array, 0, 0)); // 0
            Console.WriteLine(Exo_9.calc(array, 0, 6)); // 18
        }

        public static int CalcAlt(int[] array, int n1, int n2)
        {
            return array.Skip(n1).Take(n2 - n1 + 1).Sum();
        }

        public static int calc(int[] array, int n1, int n2)
        {
            if(array.Length == 0) return 0;
            if (n2 < n1) throw new Exception();
            var sum = 0;
            for (int i = n1; i < n2; i++)
            {
                sum += array[i];
            }
            return sum;
        }
    }
}
