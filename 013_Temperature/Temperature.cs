using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_Temperature {
  class Temperature {
    public enum Unit { C, F };

    protected double _temp; // température en °C 

    public double Celcius { get { return _temp; } set { _temp = value; } }
    public double Fahrenheit { get { return InFahrenheit(_temp); } set { _temp = InCelcius(value); } }

    /// <summary>
    /// Constructeur si aucun paramètre n'est donnée. Par défaut, la température est de 0°F.
    /// </summary>
    public Temperature() : this(0, Unit.F) { }

    /// <summary>
    /// Constructeur.
    /// </summary>
    /// <param name="temp">Température de départ</param>
    /// <param name="unit">Unité de la température (Celcius ou Fahrenheit)</param>
    public Temperature(double temp, Unit unit) {
      if (unit == Unit.C) {
        Celcius = temp;
      } else if (unit == Unit.F) {
        Fahrenheit = temp;
      }
    }

    /// <summary>
    /// Convertit une température en degrés Celcius vers les degrés Fahrenheit
    /// </summary>
    /// <param name="value">La température en degrés Celcius</param>
    /// <returns>La température en degrés Fahrenheit</returns>
    protected double InFahrenheit(double value) {
      return ((value * 9.0) / 5.0) + 32.0;
    }

    /// <summary>
    /// Convertit une température en degrés Fahrenheit vers les degrés Celcius
    /// </summary>
    /// <param name="value">La température en degrés Fahrenheit</param>
    /// <returns>La température en degrés Celcius</returns>
    protected double InCelcius(double value) {
      return ((value - 32.0) * 5.0) / 9.0;
    }

    /// <summary>
    /// Indique s'il faut allumer le chauffage ou non
    /// </summary>
    /// <returns>'True' s'il faut allumer le chauffage, 'False' sinon</returns>
    public bool Chauffage() {
      return (Celcius < 15.0);
    }

    /// <summary>
    /// Retourne la température dans l'unité donnée
    /// </summary>
    /// <param name="unit">L'unité dans laquelle on veut la température</param>
    /// <returns>La température dans l'unité donnée</returns>
    public double Value(Unit unit) {
      if (unit == Unit.C) {
        return Celcius;
      } else {
        return Fahrenheit;
      }
    }

    /// <summary>
    /// Converti l'objet en chaine de caractères
    /// </summary>
    /// <returns>Les valeurs des températures sous forme de chaine de caractère</returns>
    public override string ToString() {
      return Math.Round(Celcius, 1) + "°C = " + Math.Round(Fahrenheit, 1) + "°F";
    }
  }
}
