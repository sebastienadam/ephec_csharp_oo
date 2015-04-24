using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeCartes {
  public class Carte {
    private Couleur _couleur;
    private Valeur _valeur;

    public Couleur Couleur { get { return _couleur; } protected set { _couleur = value; } }
    public Valeur Valeur { get { return _valeur; } protected set { _valeur = value; } }

    public Carte( Valeur Valeur, Couleur Couleur) {
      this.Couleur = Couleur;
      this.Valeur = Valeur;
    }

    public int CompareTo(Carte Carte) {
      if(Carte == null) {
        return 1;
      } else {
        return Valeur.CompareTo(Carte.Valeur);
      }
    }

    public override string ToString() {
      return (Valeur + " de " + Couleur).ToLower();
    }
  }
}
