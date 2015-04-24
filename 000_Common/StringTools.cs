using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common {
  public static class StringTools {
    /// <summary>
    /// Génère une chaine de caractères qui répète un caractère donné
    /// </summary>
    /// <param name="c">Le caractère à répéter</param>
    /// <param name="times">Le nombrede fois que le caractère doit être répété</param>
    /// <returns>La chaine générée. Si <paramref name="times"/> est égal à zéro, La fonction retournera une chaine vide</returns>
    /// <exception>Si <paramref name="times"/> est négatif, une exception de type <c>ArgumentException</c> sera généré</exception>
    public static String MultiChar(char c, int times) {
      if (times == 0) {
        return "";
      } else if (times < 0) {
        throw new System.ArgumentException("Le paramètre doit être positif", "times");
      } else {
        return new String(c, times);
      }
    }
  }
}
