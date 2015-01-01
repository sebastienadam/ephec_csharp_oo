using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace _009_progoo {
  class Program {
    static void Main(string[] args) {
      ConsoleTools.WriteTitle("Programmation orienté objet");
      Personne pers = new Personne("Adam", "Sébastien", 1970);
      // pers.Age = 44; // ceci génrère une erreur
      pers.CalculerAge(2014);
      Console.WriteLine(pers);
      ConsoleTools.Pause();
    }
  }
}
