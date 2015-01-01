using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_etudiant {
  class Etudiant {
    protected string _nom;
    protected double _note1;
    protected double _note2;
    protected double _note3;
    protected double _note4;

    public string Nom { get { return _nom; } protected set { _nom = value; } }
    public double Note1 { get { return _note1; } set { _note1 = value; } }
    public double Note2 { get { return _note2; } set { _note2 = value; } }
    public double Note3 { get { return _note3; } set { _note3 = value; } }
    public double Note4 { get { return _note4; } set { _note4 = value; } }
    public double Moyenne { get { return ((_note1 + _note2 + _note3 + _note4) / 4); } }
    public string Resultat {
      get {
        if (Moyenne >= 10) {
          return "Réussi";
        } else {
          return "Échoué";
        }
      }
    }

    public Etudiant(string Nom) {
      this.Nom = Nom;
    }

    public override string ToString() {
      return Nom + " : " + Note1 + "/20 - " + Note2 + "/20 - " + Note3 + "/20 - " + Note4 + "/20 | " + Moyenne + "/20 | " + Resultat;
    }
  }
}
