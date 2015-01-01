using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_ExerciceGlobal {
  class Concessionnaire : Personne {

    public Concessionnaire(string Prenom, string Nom, CompteBancaire CompteEnBanque) : base(Prenom, Nom, CompteEnBanque) { }

    public void NouvelleVoiture(Voiture Voiture) {
      if (Voiture == null) {
        throw new ArgumentNullException("Voiture");
      } else if (this.Voiture != null) {
        throw new InvalidOperationException("Vous avez déjà une voiture !");
      } else {
        this.Voiture = Voiture;
      }
    }

    public override string ToString() {
      return base.ToString() + "  *** Concessionnaire ***" + Environment.NewLine;
    }
  }
}
