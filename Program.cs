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

        static void AfficherTableau(int[] tableau)
        {
            ///
            for (int i = 0; i <tableau.Length; i++)
            {
                Console.WriteLine("[" + i + "] " + tableau[i]);
            }
        }

        static void Tableaux()
        {
            //int a = 5;
            //a = 10;

            // Tableaux => Array -> Taille FIXE !!!!
            //int[] t = new int[6];
            //t[0] = 2;
            //t[1] = 4;
            //t[2] = 1;
            //t[3] = 5;
            //t[4] = 5;
            //t[5] = 3;

            //int[] t = { 2, 4, 1, 5, 5, 3 }; // Notation equivalente

            //t[0] = 10;

            //Console.WriteLine(t[2]);

            /*
            string[] t = { "Martin", "Emilie", "Paul" };
            Console.WriteLine(t[0][0]); // Affiche le 1er élément et le 1er charcarter de cet élément -> M

            for (int i = 0; i < t.Length; i++)
            {
                Console.WriteLine(t[i]);

            }
            //Console.WriteLine("Somme : " + SommeTableau(t));
            */

            int[] t = { 200, 40, 15, 8, 6, 12 };
            AfficherTableau(t);


        }

        static void Main(string[] args)
        {
            Console.WriteLine("Tableaux !");
            Tableaux();
        }
    }
}