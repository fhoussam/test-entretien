namespace ConsoleApp1.MT
{
    public static class MTH3
    {
        static readonly object counterLock = new object();
        static int counter = 0;

        public static void IncrementCounter()
        {
            for (int i = 0; i < 150; i++)
            {
                //variant 1 : counter resource not accessed by both threads,
                //therefore, not incremented as much as varint 2
                //int temp = counter;
                //Thread.Sleep(1);
                //counter = temp + 1;

                //variant 2 : counter resource locked
                //therefore, accessed by both threads
                lock (counterLock)
                {
                    Console.WriteLine($"iteration {i} of thread {Thread.CurrentThread.ManagedThreadId}");
                    int temp = counter; // Read shared variable
                    Thread.Sleep(1); // Simulate processing time (forces race condition)
                    counter = temp + 1; // Write updated value
                }
            }
        }

        public static void Main()
        {
            var t1 = new Thread(IncrementCounter);
            var t2 = new Thread(IncrementCounter);

            Console.WriteLine($"t1 id : {t1.ManagedThreadId}");
            Console.WriteLine($"t2 id : {t2.ManagedThreadId}");

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            Console.WriteLine($"Final Counter Value: {counter}");
        }
    }
}
