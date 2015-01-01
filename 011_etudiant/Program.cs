using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace _011_etudiant {
  class Program {
    static void Main(string[] args) {
      ConsoleTools.WriteTitle("Étudiant");
      Etudiant etud1 = new Etudiant("Max");
      etud1.Note1 = 11.4;
      etud1.Note2 = 8.2;
      etud1.Note3 = 9.4;
      etud1.Note4 = 10.1;
      Console.WriteLine(etud1);
      ConsoleTools.Pause();
    }
  }
}
