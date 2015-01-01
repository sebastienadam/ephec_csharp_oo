using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_ExerciceGlobal {
  class StationEssenceTaxecool : StationEssence {
    protected override double CalculerPrix(Personne Client, double NombreLitres) {
      double _prixAPayer = PrixEssence * NombreLitres;
      if (Client.CarteDeFideliteTaxecool != null) {
        _prixAPayer -= Client.CarteDeFideliteTaxecool.RecevoirRistourne();
        Client.CarteDeFideliteTaxecool.AcheterEssence(NombreLitres);
      }
      return _prixAPayer;
    }
  }
}
