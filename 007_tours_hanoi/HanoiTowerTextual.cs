using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace _007_tours_hanoi  {
  class HanoiTowerTextual : HanoiTower {
    /// <summary>
    /// Transforme l'objet en chaine de caractères.
    /// </summary>
    /// <returns>L'objet sous forme de chaine de caractères.</returns>
    public override String ToString() {
      String strReturn = "";
      int nbSpaces;
      int nbStars;
      char space = ' ';
      char border = '=';
      for (int i = 0; i < Towers.GetLength(0); i++) {
        strReturn += StringTools.MultiChar(space, Towers.GetLength(1) + 1) + "|" + StringTools.MultiChar(space, Towers.GetLength(1) + 1);
      }
      strReturn += Environment.NewLine;
      for (int i = Towers.GetLength(1) - 1; i >= 0; i--) {
        for (int j = 0; j < Towers.GetLength(0); j++) {
          nbStars = Towers[j, i];
          nbSpaces = Towers.GetLength(1) - nbStars + 1;
          strReturn += StringTools.MultiChar(space, nbSpaces) + StringTools.MultiChar(border, nbStars) + "|" + StringTools.MultiChar(border, nbStars) + StringTools.MultiChar(space, nbSpaces);
        }
        strReturn += Environment.NewLine;
      }
      for (int i = 0; i < Towers.GetLength(0); i++) {
        strReturn += StringTools.MultiChar('-', Towers.GetLength(1) + 1) + "+" + StringTools.MultiChar('-', Towers.GetLength(1) + 1);
      }
      strReturn += Environment.NewLine;
      for (int i = 0; i < Towers.GetLength(0); i++) {
        strReturn += StringTools.MultiChar(space, Towers.GetLength(1) + 1) + (i + 1) + StringTools.MultiChar(space, Towers.GetLength(1) + 1);
      }
      strReturn += Environment.NewLine + Environment.NewLine;
      strReturn += "Nombre optimal de mouvements : " + nbOptimalMoves + Environment.NewLine;
      strReturn += "Nombre de mouvements         : " + nbMoves + Environment.NewLine;
      strReturn += "Tour à atteindre             : " + (TowerTarget + 1) + Environment.NewLine;
      if (success) {
        strReturn += "Vous avez gagné !!!" + Environment.NewLine;
      }
      strReturn += Environment.NewLine;
      return strReturn;
    }
  }
}
