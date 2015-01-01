using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

/*
 * Ecrire un programme permettant de lire une phrase et de a découper en mots, les mots étant séparés par des espaces dans la phrase initiale.
 * Afficher combien de fois un groupe de lettres donné apparaît dans la phrase.
 */
namespace _025_string_split {
  class Program {
    static void Main(string[] args) {
      string Text;
      string Token;
      string[] Words;
      ConsoleTools.WriteTitle("Découpage de chaînes de caractères");
      Text = KeyboardTools.ReadString("Votre phase: ",false);
      Token = KeyboardTools.ReadString("Chaîne à retrouver: ",false);
      Text = Text.Trim();
      Words = Text.Split(' ');
      Console.WriteLine("Liste des mots:");
      foreach (string Word in Words) {
        Console.WriteLine(Word);
      }
      Console.WriteLine("Nombre d'occurences de '{0}': {1}", Token, Words.Count(p => p.ToLower().Equals(Token.ToLower())));
      ConsoleTools.Pause();
    }
  }
}
