namespace ConsoleApp1
{
    //thread safe singleton
    public class Exo_7
    {
        private static readonly Lazy<Exo_7> instance = new Lazy<Exo_7>(() => new Exo_7());

        private Exo_7() { }

        public static Exo_7 Instance => instance.Value;
    }
}
