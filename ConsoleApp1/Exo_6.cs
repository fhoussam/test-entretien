namespace ConsoleApp1
{
    public class Exo_6
    {
        struct Struct
        {
            public int foo;
        }

        public static void Main()
        {
            Struct struct1;
            struct1.foo = 5;

            Struct struct2 = struct1;
            struct2.foo = 10;

            Console.WriteLine(struct1.foo);
        }
    }
}
