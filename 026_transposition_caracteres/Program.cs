using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

/*
 * Ecrire un programme permettant de traduire un texte en « leet », c’est-à-dire en remplaçant (cfr http://sandbox.yoyogames.com/games/73538-leet-speak-converter)
 */
namespace _026_transposition_caracteres {
  class Program {
    static void Main(string[] args) {
      char Choice;
      Leet Traductor = new Leet();
      bool Again = true;
      while (Again) {
        Console.Clear();
        ConsoleTools.WriteTitle("Traduction en \"Leet\"");
        Console.WriteLine("Opération:");
        Console.WriteLine("   1. Coder");
        Console.WriteLine("   2. Décoder");
        Console.WriteLine("   Q. Décoder");
        Choice = KeyboardTools.ReadChar("Votre choix : ", new char[] { '1', '2', 'Q', 'q' });
        switch (Choice) {
          case '1':
            Console.WriteLine("Traduction vers Leet: ");
            Traductor.Clear = KeyboardTools.ReadString("Votre texte : ");
            Console.WriteLine("Texte codé : " + Traductor.Coded);
            break;
          case '2':
            Console.WriteLine("Traduction depuis Leet: ");
            Traductor.Coded = KeyboardTools.ReadString("Texte codé : ");
            Console.WriteLine("Votre texte : " + Traductor.Clear);
            break;
          default:
            Again = false;
            break;
        }
        ConsoleTools.Pause();
      }
    }
  }
}
