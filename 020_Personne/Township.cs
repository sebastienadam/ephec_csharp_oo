using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_Personne {
  class Township {

    /// <summary>
    /// Marie deux personnes.
    /// </summary>
    /// <param name="p1">La première personne à marrier.</param>
    /// <param name="p2">La seconde personne à marrier.</param>
    static public void Marry(Personne p1, Personne p2) {
      p1.Marry(p2);
    }

    /// <summary>
    /// Prononce un divorce entre deux personnes.
    /// </summary>
    /// <param name="p1">La première personne à divorcer.</param>
    /// <param name="p2">La seconde personne à divorcer.</param>
    static public void Divoce(Personne p1, Personne p2) {
      p1.Divorce();
    }
  }
}
