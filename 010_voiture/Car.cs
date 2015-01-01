using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_voiture {
  public class Car {
    protected string _marque;
    protected string _modele;
    protected string _noserie;
    protected double _prixcatalogue;
    protected double _reduction;

    public string Marque { get { return _marque; } protected set { _marque = value; } }
    public string Modele { get { return _modele; } protected set { _modele = value; } }
    public string NumeroSerie { get { return _noserie; } protected set { _noserie = value; } }
    public double PrixCatalogue { get { return _prixcatalogue; } set { _prixcatalogue = value; } }
    public double Reduction { get { return _reduction; } protected set { _reduction = value; } }
    public double PrixReel { get { return _prixcatalogue * (1 - _reduction / 100); } }

    public Car(string Marque, string Modele, string NoSerie, double PrixCatalogue) {
      this.Marque = Marque;
      this.Modele = Modele;
      this.NumeroSerie = NoSerie;
      this.PrixCatalogue = PrixCatalogue;
    }

    public Car(string Marque, string Modele, string NoSerie) : this(Marque, Modele, NoSerie, 0) {
    }

    public double Vendre(double Reduction) {
      this.Reduction = Reduction;
      return PrixReel;
    }

    public override string ToString() {
      return Marque + " " + Modele + " @ " + PrixReel + "EUR (<" + PrixCatalogue + "EUR)";
    }
  }
}
