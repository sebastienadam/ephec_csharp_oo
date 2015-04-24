using JeuDeCartes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuBataille {
  public class Tas {
    private Queue<Carte> Cartes;

    public int NombreCartes { get { return Cartes.Count; } }
    public bool EstVide { get { return Cartes.Count == 0; } }

    public Tas() {
      Cartes = new Queue<Carte>();
    }

    public void Ajouter(Carte Carte) {
      Cartes.Enqueue(Carte);
    }

    public Carte Prendre() {
      return Cartes.Dequeue();
    }

    public void Vider() {
      Cartes.Clear();
    }
  }
}
