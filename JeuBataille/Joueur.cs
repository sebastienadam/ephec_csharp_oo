using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JeuDeCartes;

namespace JeuBataille {
  public class Joueur {
    private string _nom;
    private Tas Cartes;

    public string Nom { get { return _nom; } protected set { _nom = value; } }
    public int NombreCartes { get { return Cartes.NombreCartes; } }
    public bool PossedeCartes { get { return !Cartes.EstVide; } }

    public Joueur(string Nom) {
      this.Nom = Nom;
      Cartes = new Tas();
    }

    internal Carte DonneCarte() {
      return Cartes.Prendre();
    }

    internal void RecoitCarte(Carte Carte) {
      Cartes.Ajouter(Carte);
    }

    internal void ViderTas() {
      Cartes.Vider();
    }

    public override string ToString() {
      return String.Format("{0} ({1})", Nom, Cartes.NombreCartes);
    }
  }
}
