using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace _021_Belge {
  class Program {
    static void Main(string[] args) {
      ConsoleTools.WriteTitle("Belges");
      Belge JanPeumans = new Belge("Jan", "Peumans", Belge.ListeCommunaute.Flamand);
      Belge JeanBonhomme = new Belge("Jean", "Bonhomme", Belge.ListeCommunaute.Wallon);
      Console.WriteLine(JanPeumans);
      Console.WriteLine(JeanBonhomme);
      ConsoleTools.Pause();
      Console.WriteLine();
      PersonneBase P1 = new PersonneBase("Personne", "Personne");
      Belge P2 = new Belge("Belge", "Belge", Belge.ListeCommunaute.Wallon);
      PersonneBase P3 = new Belge("Personne", "Belge", Belge.ListeCommunaute.Flamand);
      Console.WriteLine();
      Console.WriteLine(P1);
      Console.WriteLine(P2);
      Console.WriteLine(P3);
      ConsoleTools.Pause();
    }
  }
}
