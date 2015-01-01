using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_ExerciceGlobal {
  class StationEssence {
    private double _prixEssence;

    public double PrixEssence { get { return _prixEssence; } set { SetPrixEssence(value); } }

    protected virtual double CalculerPrix(Personne Client, double NombreLitres) {
      return PrixEssence * NombreLitres;
    }

    private void SetPrixEssence(double Prix) {
      if (Prix <= 0) {
        throw new ArgumentOutOfRangeException("", "Le prix doit être strictement positif !");
      } else {
        _prixEssence = Prix;
      }
    }

    public double VendreEssence(Personne Client, double NombreLitres) {
      if (Client.Voiture == null){
        throw new InvalidOperationException("Vous devez avoir une voiture pour acheter de l'essence !");
      } else if(Client.CompteEnBanque == null){
        throw new InvalidOperationException("Vous devez avoir un compte en banque pour acheter de l'essence !");
      } else if (NombreLitres > Client.Voiture.CapaciteReservoireManquante) {
        throw new InvalidOperationException("Votre réservoire va déborder !");
      } else {
        double _PrixAPayer = CalculerPrix(Client, NombreLitres);
        if (_PrixAPayer > Client.CompteEnBanque.Solde) {
          throw new InvalidOperationException("Vous n'avez pas assez d'argent pour acheter votre essence !");
        } else {
          Client.Voiture.RemplirReservoire(NombreLitres);
          Client.CompteEnBanque.Retirer(_PrixAPayer);
          return _PrixAPayer;
        }
      }
    }
  }
}
