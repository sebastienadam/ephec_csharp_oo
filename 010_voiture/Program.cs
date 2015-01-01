using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace _010_voiture {
  class Program {
    static void Main(string[] args) {
      double PrixVente;
      ConsoleTools.WriteTitle("Voiture");
      Car v1 = new Car("Renaud", "Twingo", "12345z");
      Console.WriteLine("Création d'une voiture sans prix :");
      Console.WriteLine("  => "+v1);
      Console.WriteLine("Affectation du prix :");
      v1.PrixCatalogue = 12000;
      Console.WriteLine("  => " + v1);
      Console.WriteLine("Vente avec 12% de réduction :");
      PrixVente = v1.Vendre(12);
      Console.WriteLine("Prix de vente : "+PrixVente);
      Console.WriteLine("  => " + v1);
      Console.WriteLine();
      Console.WriteLine("Création d'une voiture avec prix :");
      Car v2 = new Car("Renaud", "Kangoo", "1x345z", 15000);
      Console.WriteLine("  => " + v2);
      Console.WriteLine("Vente avec 6.5% de réduction :");
      PrixVente = v2.Vendre(6.5);
      Console.WriteLine("Prix de vente : " + PrixVente);
      Console.WriteLine("  => " + v2);
      ConsoleTools.Pause();
    }
  }
}
