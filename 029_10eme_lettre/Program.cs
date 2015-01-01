using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace _029_10eme_lettre {
  class Program {
    static char Get10steLetter(string word) {
      return word[9];
    }
    static void Main(string[] args) {
      string input;
      ConsoleTools.WriteTitle("10e lettre d'une chaine de caractères");
      while (true) {
        input = KeyboardTools.ReadString("Votre mot: ", true);
        if (input.Equals("")) {
          break;
        } else {
          try {
            Console.WriteLine("La 10e lettre de '{0}' est : {1}", input, Get10steLetter(input));
          } catch (IndexOutOfRangeException) {
            Console.WriteLine("Vous avez introduit un mot trop petit");
          } catch (Exception e) {
            Console.WriteLine("Une erreur indéterminée s'est produite: {0} - {1}", e.GetType(), e.Message);
          }
        }
      }
//      ConsoleTools.Pause();
    }
  }
}
