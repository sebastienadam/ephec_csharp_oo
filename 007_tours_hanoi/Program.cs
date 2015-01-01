using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace _007_tours_hanoi {
  class Program {
    static void Main(string[] args) {
      int from, to;
      int maxFrom = 4;
      bool canAutoPlay = true;
      HanoiTowerTextual jeu = new HanoiTowerTextual();
      ConsoleTools.WriteTitle("Tour de Hanoi");
      Console.WriteLine(jeu);
      Console.WriteLine("--- Déplacement ---");
      while (true) {
        from = KeyboardTools.ReadInt("Tour de départ : ", 0, maxFrom);
        if (from == 0) {
		      break;
	      }
        if (from == 4) {
          jeu.AutoPlay();
          Console.Clear();
          ConsoleTools.WriteTitle("Tour de Hanoi");
          Console.WriteLine(jeu);
          break;
        }
        if (canAutoPlay) {
          canAutoPlay = false;
          maxFrom = 3;
        }
        to = KeyboardTools.ReadInt("Tour d'arrivée : ", 1, 3);
        if (jeu.Move(from,to)) {
          Console.Clear();
          ConsoleTools.WriteTitle("Tour de Hanoi");
          Console.WriteLine(jeu);
          if (jeu.IsWon()) {
            break;
          }
          Console.WriteLine("--- Déplacement ---");
        } else {
          Console.WriteLine("Déplacement interdit!");
      	}
      }
      ConsoleTools.Pause();
    }
  }
}
