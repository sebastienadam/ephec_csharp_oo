using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeCartes {
  public class Paquet {
    private List<Carte> Cartes;
    private static Random rnd = new Random();

    public int NombreCartes { get { return Cartes.Count; } }
    public bool EstVide { get { return Cartes.Count == 0; } }

    public Paquet() {
      Cartes = new List<Carte>();
      foreach(Valeur val in Enum.GetValues(typeof(Valeur))) {
        foreach(Couleur col in Enum.GetValues(typeof(Couleur))) {
          Cartes.Add(new Carte(val, col));
        }
      }
    }

    public Carte Prendre() {
      if(EstVide) {
        return null;
      } else {
        int index = rnd.Next(NombreCartes);
        Carte Carte = Cartes[index];
        Cartes.RemoveAt(index);
        return Carte;
      }
    }
  }
}
