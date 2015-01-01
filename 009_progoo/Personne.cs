using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_progoo {
  public class Personne {
    protected string _nom;
    protected string _prenom;
    protected int _anneeNaissance;
    protected int _age;

    /// <summary>
    /// Les attributs suivants seront en lecture seule pour 'public' et en ecriture pour 'protected'
    /// </summary>
    public string Nom { get { return _nom; } protected set { _nom = value; } }
    public string Prenom { get { return _prenom; } protected set { _prenom = value; } }
    public int AnneeNaissance { get { return _anneeNaissance; } protected set { _anneeNaissance = value; } }
    public int Age { get { return _age; } protected set { _age = value; } }

    /// <summary>
    /// Constructeur.
    /// </summary>
    /// <param name="Nom">Nom de la personne</param>
    /// <param name="Prenom">Prénom de la personne</param>
    /// <param name="AnneeNaissance">Année de naissance de la personne</param>
    public Personne(string Nom, string Prenom, int AnneeNaissance) {
      this.Nom = Nom;
      this.Prenom = Prenom;
      this.AnneeNaissance = AnneeNaissance;
      this.Age = -1;
    }

    /// <summary>
    /// Calcule l'age de la personne sur base de l'année passée en paramètre
    /// </summary>
    /// <param name="Annee">Année courante</param>
    public void CalculerAge(int Annee) {
      Age = Annee - AnneeNaissance;
    }

    /// <summary>
    /// Remplacement de la méthode ToString
    /// </summary>
    /// <returns>Une chaine de caractères représentant la personne</returns>
    public override string ToString() {
      return Prenom + " " + Nom  + " (" + Age + " ans)";
    }
  }
}
