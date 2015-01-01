using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common {
  public class PersonneBase {
    private string _nom;
    private string _prenom;

    public string Nom { get { return _nom; } protected set { _nom = value; } }
    public string Prenom { get { return _prenom; } protected set { _prenom = value; } }

    public PersonneBase(string Prenom, string Nom) {
      this.Nom = Nom;
      this.Prenom = Prenom;
    }

    /// <summary>
    /// Remplacement de la méthode ToString
    /// </summary>
    /// <returns>Une chaine de caractères représentant la personne</returns>
    public override string ToString() {
      return String.Format("{0} {1}",Prenom,Nom);
    }
  }
}
