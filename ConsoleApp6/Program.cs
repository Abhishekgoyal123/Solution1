namespace ConsoleApp6
{
    public delegate void abc(int a, int b);

    public class xyz
    {
        public static void Main()
        {
            void add(int q, int z)
            {
                Console.WriteLine((q + z));
            }

            abc abcd = new abc(add);

            abcd(100, 50);
        }



    }
}