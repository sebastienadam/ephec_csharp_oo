using JeuDeCartes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuBataille {
  public class Table {
    private Dictionary<Joueur, List<Carte>> _cartesDonees;
    private Joueur _gagnant;

    public Dictionary<Joueur, List<Carte>> CartesDonnees { get { return _cartesDonees; } protected set { _cartesDonees = value; } }
    public Joueur Gagnant { get { return _gagnant; } protected set { _gagnant = value; } }

    public Table() {
      CartesDonnees = new Dictionary<Joueur,List<Carte>>();
      Gagnant = null;
    }

    internal void Ramasser() {
      if(Gagnant == null) {
        throw new InvalidOperationException("Il n'y a pas de gagnant !");
      } else {
        List<Carte> CartesCourantes;
        foreach(Joueur JoueurCourant in CartesDonnees.Keys) {
          CartesCourantes = CartesDonnees[JoueurCourant];
          if(CartesCourantes.Count != 0) {
            foreach(Carte CarteCourante in CartesCourantes) {
              Gagnant.RecoitCarte(CarteCourante);
            }
          }
        }
        Gagnant = null;
      }
    }

    internal void Tour(List<Joueur> Joueurs) {
      Carte PlusForteCarte = null;
      Carte CarteCourante = null;
      List<Joueur> DonneursPlusForteCarte = new List<Joueur>();
      CartesDonnees.Clear();
      foreach(Joueur JoueurCourant in Joueurs) {
        if(JoueurCourant.PossedeCartes) {
          CartesDonnees.Add(JoueurCourant, new List<Carte>());
          CarteCourante = JoueurCourant.DonneCarte();
          if(PlusForteCarte == null) {
            PlusForteCarte = CarteCourante;
            DonneursPlusForteCarte.Add(JoueurCourant);
          } else if(PlusForteCarte.CompareTo(CarteCourante) == 0) {
            DonneursPlusForteCarte.Add(JoueurCourant);
          } else if(PlusForteCarte.CompareTo(CarteCourante) < 0) {
            PlusForteCarte = CarteCourante;
            DonneursPlusForteCarte.Clear();
            DonneursPlusForteCarte.Add(JoueurCourant);
          }
          CartesDonnees[JoueurCourant].Add(CarteCourante);
        }
      }
      while(DonneursPlusForteCarte.Count > 1) {
        int TailleMaxListeCartesDonnees = 0;
        foreach(Joueur JoueurCourant in DonneursPlusForteCarte) {
          for(int i = 0; i < 2; i++) {
            if(JoueurCourant.PossedeCartes) {
              CartesDonnees[JoueurCourant].Add(JoueurCourant.DonneCarte());
            }
          }
        }
        foreach(List<Carte> Cartes in CartesDonnees.Values) {
          if(Cartes.Count > TailleMaxListeCartesDonnees) {
            TailleMaxListeCartesDonnees = Cartes.Count;
          }
        }
        DonneursPlusForteCarte.Clear();
        PlusForteCarte = null;
        foreach(Joueur JoueurCourant in CartesDonnees.Keys) {
          List<Carte> Cartes = CartesDonnees[JoueurCourant];
          if(Cartes.Count == TailleMaxListeCartesDonnees) {
            CarteCourante = Cartes[Cartes.Count - 1];
            if(PlusForteCarte == null) {
              PlusForteCarte = CarteCourante;
              DonneursPlusForteCarte.Add(JoueurCourant);
            } else if(PlusForteCarte.CompareTo(CarteCourante) == 0) {
              DonneursPlusForteCarte.Add(JoueurCourant);
            } else if(PlusForteCarte.CompareTo(CarteCourante) < 0) {
              PlusForteCarte = CarteCourante;
              DonneursPlusForteCarte.Clear();
              DonneursPlusForteCarte.Add(JoueurCourant);
            }
          }
        }
      }
      Gagnant = DonneursPlusForteCarte[0];
    }
  }
}
