using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_ExerciceGlobal {
  class StationEssenceFinoil : StationEssence {
    private Random _rnd;

    public StationEssenceFinoil() {
      _rnd = new Random();
    }

    protected override double CalculerPrix(Personne Client, double NombreLitres) {
      if (_rnd.Next(100) == 50) {
        return 0;
      } else {
        return PrixEssence * NombreLitres;
      }
    }
  }
}
