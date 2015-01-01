using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

/*
 * Ecrire un programme qui lit un texte au clavier et l’affiche en majuscules et en élimine tous les espaces tapés au début et à la fin du texte
 */

namespace _024_majuscule_trim {
  class Program {
    static void Main(string[] args) {
      string Text;
      ConsoleTools.WriteTitle("Mise en majuscule et suppression des espaces au début et à la fin");
      Text = KeyboardTools.ReadString("Votre texte : ",false);
      Console.WriteLine("|"+Text.ToUpper().Trim()+"|");
      ConsoleTools.Pause();
    }
  }
}
