using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_ExerciceGlobal {
  public class Voiture {
    protected string _marque;
    protected string _modele;
    protected double _prix;
    protected double _conso;
    protected double _contreserv;
    static readonly double _capaciteReservoire = 64.0;

    public double CapaciteReservoireManquante { get { return _capaciteReservoire - ContenuReservoire; } }
    public double Consommation { get { return _conso; } protected set { _conso = value; } }
    public double ContenuReservoire { get { return _contreserv; } protected set { _contreserv = value; } }
    public double DistanceParcourable { get { return GetDistanceParcourable(); } }
    public string Marque { get { return _marque; } protected set { _marque = value; } }
    public string Modele { get { return _modele; } protected set { _modele = value; } }
    public double Prix { get { return _prix; } protected set { _prix = value; } }

    public Voiture(string Marque, string Modele, double Prix, double Consommation) {
      this.Marque = Marque;
      this.Modele = Modele;
      this.Prix = Prix;
      this.Consommation = Consommation;
      ContenuReservoire = 0;
    }

    private double GetDistanceParcourable() {
      if (ContenuReservoire == 0) {
        return 0.0;
      } else {
        return (Consommation * 100.0) / ContenuReservoire;
      }
    }

    public void RemplirReservoire(double Litres) {
      if (Litres < 0) {
        throw new ArgumentOutOfRangeException("Litres", "Ne peut pas être négatif");
      } else if (Litres > CapaciteReservoireManquante) {
        throw new ArgumentOutOfRangeException("Litres", "Le réservoire déborde!!!");
      } else {
        ContenuReservoire += Litres;
      }
    }

    public void Rouler(double Kilometres) {
      if (Kilometres < 0) {
        throw new ArgumentOutOfRangeException("Kilometres", "La distance à parcourir doit être positive");
      } else {
        double _consoTrajet = Consommation * 100 / Kilometres;
        if (_consoTrajet <= ContenuReservoire) {
          ContenuReservoire -= _consoTrajet;
        } else {
          throw new InvalidOperationException("Il n'y a pas assez d'essence!!");
        }
      }
    }

    public override string ToString() {
      StringBuilder Result = new StringBuilder();
      Result.AppendFormat("> {0} {1}{2}", Marque, Modele, Environment.NewLine);
      Result.AppendFormat("     Prix                 : {0:#,##0.00}EUR{1}", Prix, Environment.NewLine);
      Result.AppendFormat("     Consommation         : {0} l/100km{1}", Consommation, Environment.NewLine);
      Result.AppendFormat("     Contenur réservoire  : {0} l{1}", ContenuReservoire, Environment.NewLine);
      Result.AppendFormat("     Distance parcourable : {0} l{1}", DistanceParcourable, Environment.NewLine);
      return Result.ToString();
    }
  }
}
