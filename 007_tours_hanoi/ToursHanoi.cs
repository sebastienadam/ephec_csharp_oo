using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToursHanoi
{
    class Program
    {
        static void Dessiner(int[,] Tours)
            // Affiche Tours à la console
        {
            int x, y=0,l;
            int Numéro,Largeur;

            Console.Clear();
            for (Numéro = 0; Numéro < 3; Numéro++)
            {
                x = (Numéro + 1) * 21;

                for (y = 0; y < 10; y++)
                {
                    if (Tours[Numéro, y] == 0)
                    {
                        Console.SetCursorPosition(x, 15 - y);
                        Console.Write(".");
                    }
                    else
                    {
                        Largeur = 2 * Tours[Numéro,y] - 1;
                        Console.SetCursorPosition(x - Tours[Numéro,y] + 1, 15 - y);
                        for (l = 0; l < Largeur; l++) Console.Write("*");
                    }
                }
            }
        }

        static int Sommet(int[,] Tours, int Plot)
            // Renvoie la position du palet le plus haut sur la tour Plot, ou -1 si la tour est vide
        {
            int i = 9, Palet;
            do
            {
                Palet = Tours[Plot, i];
                i--;
            } while ((Palet == 0) && (i >= 0));
            if (Palet != 0) return i + 1;       // Si on a trouvé un palet, le dernier i-- nous a amenés un étage trop bas
            else return -1;
        }
       
        static bool Autorisé(int [,] Tours, int Origine, int Destination)
            // Renvoie true si un déplacement du sommet de origine vers celui de destination est permis, false sinon
        {
            int SommetA, SommetB, PaletA,PaletB;
            SommetA = Sommet(Tours, Origine);
            if (SommetA == -1) return false;
            SommetB = Sommet(Tours, Destination);
            if (SommetB == -1) return true;
            PaletA = Tours[Origine, SommetA];
            PaletB = Tours[Destination, SommetB];
            if (PaletA < PaletB) return true;
            else return false;
        }
        static void Déplacer(int [,] Tours, int Origine, int Destination)
        // Si c'est autorisé, déplace le palet du sommet de origine vers celui de destination 
        // Sinon, affiche un message d'erreur et ne fait rien
        {
            int Palet, i=10,SommetA,SommetB;

            if (!Autorisé(Tours, Origine, Destination))
            {
                Console.WriteLine("Déplacement interdit");
                Console.ReadLine();
                return;
            }
            SommetA = Sommet(Tours, Origine);
            Palet = Tours[Origine, SommetA];
            Tours[Origine, SommetA] = 0;
            SommetB = Sommet(Tours, Destination) +1;
            Tours[Destination, SommetB] = Palet;
        }

        static int IdentifiePlotTransit(int o, int d)
            // Renvoie le numéro du plot qui n'est ni l'origine (o), ni la destination (d)
            // Par exemple, si o vaut 0 et d vaut 2, renvoie 1
        {
            int res;
            if (o==0)
            {
                if (d == 1) res = 2;
                else res = 1;
            }
            else if (o==1)
            {
                if (d == 0) res = 2;
                else res = 0;
            }
            else
            {
                if (d == 0) res = 1;
                else res = 0;
            }
            return res;
        }

        static void DéplacerTour(int [,] Tours, int Origine, int Destination, int NbEtages)
            // Solution automatique, par récursivité
            // Déplace les NbEtages supérieurs de la tour Origine vers la tour Destination
            // /!\ Suppose qu'un tel déplacement est possible, sinon le comportement du programme n'est pas garanti
            //          On peut prouver que la situation initiale - et tous les appels qui en découleront - correspond 
            //          à un cas où le déplacement est possible)
        {
            int Transit;        // numéro du plot de transit (qui n'est ni origine, ni destination)
            if (NbEtages == 1)
            {
                Déplacer(Tours, Origine, Destination);
                Dessiner(Tours);                            // A chaque "vrai" déplacement d'un palet, dessin, puis
                Console.SetCursorPosition(0, 0);            // Pause pour affichage 
                Console.ReadKey();
            }
            else
            {
                Transit = IdentifiePlotTransit(Origine, Destination);
                DéplacerTour(Tours, Origine, Transit, NbEtages - 1);
                DéplacerTour(Tours, Origine, Destination, 1);
                DéplacerTour(Tours, Transit, Destination, NbEtages - 1);
            }
        }

        static void Initialiser(out int [,] Tours)
            /* Alloue la mémoire nécessaire et initialise les 3 tours: 
             *  - Tour 0 : palets de 10 à 1
             *  - Tours 1 et 2: vides */
            /* Remarque: pour simplifier l'exercice, on fixe la hauteur des tours à 10 étages */
        {
            int j;
            Tours = new int[3, 10]; /* Tour[i,j] = taille du palet à l'étage j de la tour i (ou 0 si pas de palet à cet endroit) 
                                          * Etage 0 = étage du bas */
            for (j = 0; j < 10; j++)
            {
                Tours[0, j] = 10 - j;
                Tours[1, j] = 0;
                Tours[2, j] = 0;
            }
        }
        static int Lireint()
            // Lit (et convertit) un entier au clavier. Les erreurs ne sont pas traitées
        {
            string s = Console.ReadLine();
            return Int32.Parse(s);
        }
        static void Main(string[] args)
        {
            int[,] Tours;
            bool Automatique = true;         
            int Départ, Arrivée;

            Initialiser(out Tours);

            if (Automatique)
            {
                Dessiner(Tours);
                Console.ReadLine();
                DéplacerTour(Tours, 0, 1, 10);
            }
            else
            {
                while ((Sommet(Tours, 0) != -1) || (Sommet(Tours, 2) != -1))            // Jeu gagné quand les tours 0 et 2 seront vides
                {
                    Dessiner(Tours);
                    Console.SetCursorPosition(0, 20);
                    Console.Write("Départ: ");
                    Départ = Lireint();
                    Console.Write("Arrivée: ");
                    Arrivée = Lireint();
                    Déplacer(Tours, Départ, Arrivée);
                }
            }
        }
    }
}
