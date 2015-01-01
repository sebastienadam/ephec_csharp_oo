using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

// Slide 43
namespace _013_Temperature {
  class Program {
    static void Main(string[] args) {
      Temperature temp;
      ConsoleTools.WriteTitle("Température");
      Console.WriteLine("Création d'une température de 10°C :");
      temp = new Temperature(10, Temperature.Unit.C);
      Console.WriteLine("   " + temp);
      if (temp.Chauffage()) {
        Console.WriteLine("Il faut allumer le chauffage!");
      } else {
        Console.WriteLine("Pas de chauffage!");
      }
      Console.WriteLine();
      Console.WriteLine("Assignation de la température à 23°F :");
      temp.Fahrenheit = 23;
      Console.WriteLine("   "+temp);
      if (temp.Chauffage()) {
        Console.WriteLine("Il faut allumer le chauffage!");
      } else {
        Console.WriteLine("Pas de chauffage!");
      }
      Console.WriteLine();
      Console.WriteLine("Création d'une température de 60°F :");
      temp = new Temperature(60, Temperature.Unit.F);
      Console.WriteLine("   " + temp);
      if (temp.Chauffage()) {
        Console.WriteLine("Il faut allumer le chauffage!");
      } else {
        Console.WriteLine("Pas de chauffage!");
      }
      Console.WriteLine();
      Console.WriteLine("Assignation de la température à 23°C :");
      temp.Celcius = 23;
      Console.WriteLine("   " + temp);
      if (temp.Chauffage()) {
        Console.WriteLine("Il faut allumer le chauffage!");
      } else {
        Console.WriteLine("Pas de chauffage!");
      }
      ConsoleTools.Pause();
    }
  }
}
