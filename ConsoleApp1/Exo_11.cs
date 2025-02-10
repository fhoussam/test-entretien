namespace ConsoleApp1
{
    //estimation of pi
    public class Exo_11
    {
        class Point
        {
            public double x, y;
        }

        class Pi
        {
            public static double Approx(Point[] pts)
            {
                double count = pts.Count(p => 
                    p.x < 1 
                    && p.x > 0 
                    && p.y < 1 
                    && p.y > 0
                    && Math.Pow(p.x, 2) + Math.Pow(p.y, 2) < 1  
                    );

                double result = count / pts.Length;
                return result * 4; //equals pi
            }
        }

        public static void Main()
        {
            // Code de test

            // 100 000 random points
            var rands = new Point[100000];
            Random random = new Random();
            for (int i = 0; i < rands.Length; i++)
            {
                Point p = new Point();
                p.x = random.NextDouble(); // x
                p.y = random.NextDouble(); // y
                rands[i] = p;
            }

            var result = Pi.Approx(rands);
            Console.WriteLine(result);
        }
    }
}