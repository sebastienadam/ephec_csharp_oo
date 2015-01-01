using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_ExerciceGlobal {
  public class CarteFideliteTaxecool {
    private int _nbPoints;

    public int NombreDePoints { get { return _nbPoints; } protected set { _nbPoints = value; } }

    public CarteFideliteTaxecool() {
      NombreDePoints = 0;
    }

    public int AcheterEssence(double NombreLitres) {
      if (NombreLitres < 0) {
        throw new ArgumentOutOfRangeException("NombreLitres", "Le nombre de litres ne peut être négatif !");
      } else {
        NombreDePoints += (int)Math.Floor(NombreLitres);
        return NombreDePoints;
      }
    }

    public int RecevoirRistourne() {
      int _ristourne = NombreDePoints / 100;
      NombreDePoints -= _ristourne * 100;
      return _ristourne;
    }
  }
}
