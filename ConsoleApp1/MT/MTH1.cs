namespace ConsoleApp1.MT
{
    public static class MTH1
    {
        public static void PrintNumbers()
        {
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine($"print number {i}");
                Thread.Sleep(1000);
            }
        }

        static void PrintLetters()
        {
            for (char c = 'A'; c <= 'J'; c++)
            {
                Console.WriteLine($"Letter: {c}");
                Thread.Sleep(500);
            }
        }


        public static void Main() 
        {
            var st = new Thread(PrintNumbers);
            st.Start();
            PrintLetters();
            st.Join();
            Console.WriteLine("aaaaa");
        }
    }
}
