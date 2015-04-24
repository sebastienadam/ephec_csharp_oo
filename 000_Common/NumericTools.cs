using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common {
  public static class NumericTools {
    /// <summary>
    /// Indique si un nombre est premier ou non.
    /// </summary>
    /// <param name="nbr">Nombre à tester</param>
    /// <returns>'True' si le nombre donné est premier, 'faux' sinon.</returns>
    public static bool IsPrime(int nbr) {
      bool isPrime;
      if (nbr < 2) {
        isPrime = false;
      } else if (nbr == 2) {
        isPrime = true;
      } else if ((nbr % 2) == 0) {
        isPrime = false;
      } else {
        int i = 3;
        isPrime = true;
        while ((i * i) <= nbr) {
          if ((nbr % i) == 0) {
            isPrime = false;
            break;
          }
          i += 2;
        }
      }
      return isPrime;
    }

    /// <summary>
    /// Indique si deux nombres sont égaux à un certains nombre de décimales près.
    /// </summary>
    /// <param name="val1">Premier nombre à tester</param>
    /// <param name="val2">Deuxième nombre à tester</param>
    /// <param name="precision">Nombre de décimales</param>
    /// <returns>'True' si les deux nombres sont égaux à la précision donnée, 'faux' sinon.</returns>
   public static bool AreEquals(double val1, double val2, int precision) {
      //precision = Math.Abs(precision);
      //return Math.Round(val1, precision) == Math.Round(val2, precision);
      precision = -(Math.Abs(precision));
      return Math.Abs(val1 - val2) < Math.Pow(10, precision);
    }
  }
}
