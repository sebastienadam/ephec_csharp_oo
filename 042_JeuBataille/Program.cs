using JeuBataille;
using JeuDeCartes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _042_JeuBataille {
  class Program {
    static void Main(string[] args) {
      Jeu Jeu = new Jeu();
      Jeu.NouveauJoueur("Alain");
      Jeu.NouveauJoueur("Bart");
      Jeu.NouveauJoueur("Charles");
      Jeu.NouveauJoueur("Didier");
      try {
        Jeu.NouvellePartie();
        Console.WriteLine("Joueurs :");
        foreach(Joueur Joueur in Jeu.Joueurs) {
          Console.WriteLine("   > " + Joueur);
        }
        while(!Jeu.AGagnant) {
          Jeu.Jouer();
          Console.WriteLine("Cartes déposées :");
          foreach(Joueur Joueur in Jeu.Table.CartesDonnees.Keys) {
            Console.Write("   - " + Joueur + " : ");
            foreach(Carte Carte in Jeu.Table.CartesDonnees[Joueur]) {
              Console.Write(Carte + ", ");
            }
            Console.WriteLine("");
          }
          Console.WriteLine("C'est " + Jeu.Table.Gagnant.Nom + " qui remporte la mise.");
        }
        Console.WriteLine("Le grand gagnant est : " + Jeu.Gagnant.Nom);
      } catch(Exception e) {
        Console.WriteLine("Excception: " + e);
      }
      Console.ReadKey();
    }
  }
}
