namespace Programme_Collection
{
    internal class Program
    {

        static void Tableaux()
        {
            //int a = 5;
            //a = 10;

            int[] t = new int[3];
            t[0] = 2;
            t[1] = 4;
            t[2] = 1;
            t[2]++;

            //Console.WriteLine(t[2]);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(t[i]);

            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Tableaux !");
            Tableaux();
        }
    }
}
