namespace ConsoleApp1
{
    //volatile example
    //La volatilité permet de désactiver certaines optimisations opérées par le compilateur.
    public class Exo_5
    {
        static volatile bool stop = false; // Shared variable with volatile

        public static void Main()
        {
            Thread thread = new Thread(Worker);
            thread.Start();

            Thread.Sleep(1000); // Simulate some work
            stop = true; // Main thread signals the worker thread to stop

            Console.WriteLine("Stop signal sent.");
            thread.Join();
        }

        static void Worker()
        {
            Console.WriteLine("Worker started.");
            while (!stop) // Worker keeps running while stop is false
            {
                // Simulate work
            }
            Console.WriteLine("Worker stopped.");
        }
    }
}
