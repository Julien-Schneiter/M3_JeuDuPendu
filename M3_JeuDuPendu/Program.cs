


namespace M3_JeuDuPendu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "data",
                "mots_fr.txt"
                );

            List<string> mots = ChargerListeMots(path);

            string motADeviner = ObtenirMotADeviner(mots);

            Console.WriteLine("Mot choisi");
            Console.WriteLine(motADeviner);

            int nombreErreur = 6;

            AfficherPotence(nombreErreur);

            /* Console.WriteLine("Mots Chargés : ");


            //*foreach (string mot in mots)
            {
                Console.WriteLine(mot);
            }*/

        }



        /// <summary>
        /// Foncion qui permet de charger le fichier de mota deviner 
        /// </summary>
       /// <param name="nomFichier"> c'est le nom du fichier qui contient les mots a deviner</param>
       /// <returns>  retourne une lsite de mot qu'on peut utiliser pour faire deviner </returns>
        static List<string> ChargerListeMots(string nomFichier)
        {
          List<string> mots = File.ReadLines(nomFichier).ToList();

          return mots;
        }



        /// <summary>
        /// Fonction qui permet d'obtenir par hasard un mot a deviner dans la liste des mots 
        /// </summary>
        /// <param name="mots">liste de mots a deviner </param>
        /// <returns>  retouner le mot a deviner </returns>
        static string ObtenirMotADeviner (List<string>mots)
        {
            Random inconnuADeviner = new Random();

            int positonMot = inconnuADeviner.Next(mots.Count);

            string motADeviner = mots[positonMot];

            return motADeviner;

        }


        static void AfficherPotence(int nombreErreur)
        {
            string[] potence =
            {
                """
                +--+----
                |
                |
                |
                |
                |
                |
                +-------------
                """,

                """
                +--+----
                |  |
                |  O
                | 
                |
                |
                |
                +-------------
                """,

                """
                +--+----
                |  |
                |  O
                |  |
                |
                |
                |
                +-------------
                """,
                """
                +--+----
                |  |
                |  O
                | /|
                |
                |
                |
                +-------------
                """,
                """
                +--+----
                |  |
                |  O
                | /|\
                |
                |
                |
                +-------------
                """,
                """
                +--+----
                |  |
                |  O
                | /|\
                | /
                |
                |
                +-------------
                """,
                """
                +--+----
                |  |
                |  O
                | /|\
                | / \
                |
                |
                +-------------
                """,

            };
            Console.WriteLine(potence[nombreErreur]);
        }


        
        static string SaisirLettreAZ()
        {


            while ( ! saisieValide )
            {
                Console.WriteLine("Quelle lettre voulez-vous jouer ?");
                saisie = Console.ReadLine() ?? "";

                if (saisie.Length ==1 && char.IsLetter(saisie[0]))
                {
                    lettre = char.ToUpper(saisie[0]);
                    saisieValide = true;
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Votre saisie est invalide.");
                    Console.ResetColor();
                }
            }
            return lettre;

        }

        
    }
}
