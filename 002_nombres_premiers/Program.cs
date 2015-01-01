using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace _002_nombres_premiers {
  class Program {
    static void Main(string[] args) {
      ConsoleTools.WriteTitle("Nombres premiers");
      for (int i = 0; i < 100; i++) {
        if (NumericTools.IsPrime(i)) {
          Console.WriteLine(i + " est premier.");
        } else {
          Console.WriteLine(i + " N'est PAS premier.");
        }
      }
      ConsoleTools.Pause();
    }
  }
}
