using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_Jeu_de_role {
  public class Arena {

    /// <summary>
    /// Duel à mort entre deux héros.
    /// </summary>
    /// <param name="Fighter1">Le premier attaquant</param>
    /// <param name="Fighter2">Le second attaquant</param>
    public static void Duel(Hero Fighter1, Hero Fighter2) {
      Fighter1.Duel(Fighter2);
      //while (true) {
      //  Fighter1.Attack(Fighter2);
      //  if (Fighter2.IsDead) {
      //    break;
      //  }
      //  Fighter2.Attack(Fighter1);
      //  if (Fighter1.IsDead) {
      //    break;
      //  }
      //}
    }
  }
}
