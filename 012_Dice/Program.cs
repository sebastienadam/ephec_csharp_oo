using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace _012_Dice {
  class Program {
    static void Main(string[] args) {
      ConsoleTools.WriteTitle("Lancé de dé");
      Dice dice = new Dice();
      int[] stat = new int[dice.NbFaces];
      for (int i = 0; i < stat.Length; i++) {
        stat[i] = 0;
      }
      for (int i = 0; i < 500; i++) {
        dice.Throw();
        Console.WriteLine("Lancé " + (i + 1) + " : " + dice.Value);
        stat[dice.Value-1]++;
      }
      Console.WriteLine();
      Console.WriteLine("Statistiques :");
      for (int i = 0; i < stat.Length; i++) {
        Console.WriteLine("  Face "+(i+1)+" : "+stat[i]);
      }
      ConsoleTools.Pause();
    }
  }
}
