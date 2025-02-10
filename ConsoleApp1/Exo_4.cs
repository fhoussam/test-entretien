using System.Collections;

namespace ConsoleApp1
{
    public class Exo_4
    {
        static List<int> numbers = new List<int>();
        static readonly object syncRoot = ((ICollection)numbers).SyncRoot;
        static int lastPrintedIndex = -1; // Track the last printed index

        public static void Main()
        {
            Thread writer = new Thread(AddNumbers);
            Thread reader = new Thread(PrintNumbers);

            writer.Start();
            reader.Start();

            writer.Join();
            reader.Join();
        }

        static void AddNumbers()
        {
            for (int i = 0; i < 100; i++)
            {
                lock (syncRoot) // Synchronize writing
                {
                    numbers.Add(i);
                }
                Thread.Sleep(4); // Simulate work
            }
        }

        static void PrintNumbers()
        {
            while (true)
            {
                List<int> snapshot;

                // Take a snapshot of only unprinted numbers under the lock
                lock (syncRoot)
                {
                    if (lastPrintedIndex >= numbers.Count - 1)
                        continue;

                    snapshot = numbers.GetRange(lastPrintedIndex + 1, numbers.Count - (lastPrintedIndex + 1));
                    lastPrintedIndex = numbers.Count - 1; // Update the last printed index
                }

                // Print the snapshot (no lock required here)
                foreach (var number in snapshot)
                {
                    Console.WriteLine(number);
                    Thread.Sleep(15); // Simulate work
                }

                // Break out of the loop when writing finishes
                if (lastPrintedIndex >= 99)
                    break;
            }
        }
    }
}
