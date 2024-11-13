namespace Programme_Collection
{
    internal class Program
    {

        static int SommeTableau(int[] t)
        {
            int somme = 0;

            for (int i = 0; i < t.Length; i++)
            {
                somme += t[i];
            }

            return somme;
        }

        static void Tableaux()
        {
            //int a = 5;
            //a = 10;

            // Tableaux => Array
            int[] t = new int[6];
            t[0] = 2;
            t[1] = 4;
            t[2] = 1;
            t[3] = 5;
            t[4] = 5;
            t[5] = 3;

            //Console.WriteLine(t[2]);

            for (int i = 0; i < t.Length; i++)
            {
                Console.WriteLine(t[i]);

            }
            Console.WriteLine("Somme : " + SommeTableau(t));

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Tableaux !");
            Tableaux();
        }
    }
}
