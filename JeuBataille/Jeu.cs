using JeuDeCartes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuBataille {
  public class Jeu {
    private List<Joueur> _joueurs;
    private bool JeuEnCours;
    private bool TableVide;
    private Table _table;
    private Joueur _gagnant;

    public List<Joueur> Joueurs { get { return _joueurs; } protected set { _joueurs = value; } }
    public Table Table { get { return _table; } protected set { _table = value; } }
    public Joueur Gagnant { get { return _gagnant; } protected set { _gagnant = value; } }
    public bool AGagnant { get { return Gagnant != null; } }

    public Jeu() {
      Joueurs = new List<Joueur>();
      Table = new Table();
      JeuEnCours = false;
      TableVide = true;
    }

    public void Jouer() {
      if(JeuEnCours) {
        if(!TableVide) {
          Ramasser();
        }
        Table.Tour(Joueurs);
        TableVide = false;
      } else {
        throw new InvalidOperationException("Vous devez initialiser une partie pour pouvoir jouer");
      }
    }

    public void NouveauJoueur(string Nom) {
      NouveauJoueur(new Joueur(Nom));
    }

    public void NouveauJoueur(Joueur Joueur) {
      if(JeuEnCours) {
        throw new InvalidOperationException("De nouveaux joueurs ne peuvent pas être ajoutés en cours de partie");
      } else {
        Joueurs.Add(Joueur);
      }
    }

    public void NouvellePartie() {
      Reset();
      if(Joueurs.Count < 2) {
        throw new InvalidOperationException("Vous avez besoin d'au moins deux joueurs");
      } else {
        int i = 0;
        JeuEnCours = true;
        Paquet Paquet = new Paquet();
        while(!Paquet.EstVide) {
          Joueurs[i].RecoitCarte(Paquet.Prendre());
          i++;
          if(i >= Joueurs.Count) {
            i = 0;
          }
        }
      }
    }

    public void Ramasser() {
      if(JeuEnCours) {
        if(!TableVide) {
          Table.Ramasser();
          TableVide = true;
          foreach(Joueur Joueur in Joueurs) {
            if(Joueur.PossedeCartes) {
              if(Gagnant != null) {
                Gagnant = null;
                break;
              } else {
                Gagnant = Joueur;
              }
            }
          }
        }
      } else {
        throw new InvalidOperationException("Vous devez initialiser une partie pour pouvoir jouer");
      }
    }

    private void Reset() {
      foreach(Joueur JoueurCourant in Joueurs) {
        JoueurCourant.ViderTas();
      }
      JeuEnCours = false;
      Gagnant = null;
    }

    public void RetirerJoueur(string Nom) {
      if(JeuEnCours) {
        throw new InvalidOperationException("Un joueur ne peut pas être retiré en cours de partie");
      } else {
        foreach(Joueur Joueur in Joueurs) {
          if(Joueur.Nom.Equals(Nom)) {
            Joueurs.Remove(Joueur);
            break;
          }
        }
      }
    }

    public void RetirerJoueur(Joueur Joueur) {
      if(JeuEnCours) {
        throw new InvalidOperationException("Un joueur ne peut pas être retiré en cours de partie");
      } else {
        Joueurs.Remove(Joueur);
      }
    }
  }
}
