using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _012_Dice;

namespace _019_Jeu_de_role {
  class BonusDice : Dice {
    public int Throw(int Bonus) {
      return rnd.Next(NbFaces + Bonus) +1 ;
    }
  }
}
