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
            for (int i = 0; i < tableau.Length; i++)
            {
                Console.WriteLine("[" + i + "] " + tableau[i]);
            }
        }

        static void AfficherValeurMaximal(int[] t)
        {
            int max = t[0];
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] > max)
                {
                    max = t[i];
                }
            }
            Console.WriteLine("La valeur maximal est : " + max);
        }

        static void AfficherValeurMinimal(int[] t)
        {
            int min = t[0];
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] < min)
                {
                    min = t[i];
                }
            }
            Console.WriteLine("La valeur minimal est : " + min);
        }
        static void Tableaux()
        {
            /*
            int a = 5;
            a = 10;

            Tableaux => Array->Taille FIXE!!!!
            int[] t = new int[6];
            t[0] = 2;
            t[1] = 4;
            t[2] = 1;
            t[3] = 5;
            t[4] = 5;
            t[5] = 3;

            int[] t = { 2, 4, 1, 5, 5, 3 }; // Notation equivalente

            t[0] = 10;

            Console.WriteLine(t[2]);
            */

            /*
            string[] t = { "Martin", "Emilie", "Paul" };
            Console.WriteLine(t[0][0]); // Affiche le 1er élément et le 1er charcarter de cet élément -> M

            for (int i = 0; i < t.Length; i++)
            {
                Console.WriteLine(t[i]);

            }
            //Console.WriteLine("Somme : " + SommeTableau(t));
            */

            // int[] t = { 200, 40, 15, 8, 6, 12 };
            /*
            const int TAILLE_TABLEAU = 22;

            int[] t = new int[TAILLE_TABLEAU];
            Random r = new Random();

            for (int i = 0; i < t.Length; i++)
            {
                t[i] = r.Next(101);
            }

            AfficherTableau(t);
            AfficherValeurMaximal(t);
            AfficherValeurMinimal(t);
            */
        }

        static void AfficherListe(List<string> liste)
        {
            for (int i = 0; i < liste.Count; i++)
            {
                Console.WriteLine(liste[i]);
            }
        }
        static void Listes()
        {
            List<int> liste = new List<int>();

            /* liste
            liste.Add(5);
            liste.Add(8);
            liste.Add(1);
            liste.Add(10);
            liste.Add(6);
            liste.Add(3);

            //liste.Remove(8);
            liste.RemoveAt(2);
            liste.Add(44);

            AfficherListe(liste);
            */

            List<string> noms = new List<string>();  // Idem à ==>     var noms = new List<string>(); 
            while (true)
            {
                Console.Write("Entrer un nom (Enter pour finir) : ");
                string nom = Console.ReadLine();

                if (nom == "")
                {
                    break;
                }

                if (noms.Contains(nom))
                {
                    Console.WriteLine("Erreur, ce nom est déjà dans la liste.");
                    Console.WriteLine();
                }
                else
                {
                    noms.Add(nom);
                }
            }
            AfficherListe(noms);

            //List<string> lesPremierNoms = noms.GetRange(0, 3);
            //AfficherListe(lesPremierNoms);
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Tableaux Aléatoire !");
            Console.WriteLine("Liste !");
            //Tableaux();
            Listes();
        }
    }
}
