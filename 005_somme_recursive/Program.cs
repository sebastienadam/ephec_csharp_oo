using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace _005_somme_recursive {
  class Program {
    static int SommeRecursive(int n) {
      if (n <= 1) {
        return n;
      } else {
        return n + SommeRecursive(n - 1);
      }
    }

    static void Main(string[] args) {
      int n;
      int sum;
      ConsoleTools.WriteTitle("Somme récursive");
      n = KeyboardTools.ReadInt("Introduisez une nombre entier positif : ", 0);
      sum = SommeRecursive(n);
      Console.WriteLine("La somme de tous les entiers entre 0 et " + n + " vaut : " + sum);
      ConsoleTools.Pause();
    }
  }
}
