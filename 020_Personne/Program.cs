using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using _010_voiture;

namespace _020_Personne {
  class Program {
    static void Main(string[] args) {
      ConsoleTools.WriteTitle("Marriage et voiture");
      Personne MikeHammer = new Personne("Hammer", "Mike", 1967);
      MikeHammer.CalculerAge(2014);
      Personne JaneDoe = new Personne("Doe", "Jane", 1984);
      JaneDoe.CalculerAge(2014);
      Console.WriteLine(MikeHammer);
      Console.WriteLine(JaneDoe);
      Console.WriteLine();
      Console.WriteLine("Marriage de {0} et {1}:", MikeHammer.Prenom, JaneDoe.Prenom);
      try {
        MikeHammer.Marry(JaneDoe);
        //JaneDoe.Marry(MikeHammer);
        //Township.Marry(MikeHammer, JaneDoe);
      } catch (Exception e) {
        Console.WriteLine(e.Message);
      }
      Console.WriteLine(MikeHammer);
      Console.WriteLine(JaneDoe);
      Console.WriteLine();
      Console.WriteLine("Divorce de {0} et {1}:", MikeHammer.Prenom, JaneDoe.Prenom);
      try {
        //MikeHammer.Divorce();
        JaneDoe.Divorce();
        //Township.Divoce(JaneDoe, MikeHammer);
      } catch (Exception e) {
        Console.WriteLine(e.Message);
      }
      Console.WriteLine(MikeHammer);
      Console.WriteLine(JaneDoe);
      Console.WriteLine();
      Console.WriteLine("{0} achète une voiture :", MikeHammer.Prenom);
      MikeHammer.BuyCar(new Car("Renaud", "Megane", "azertyuiodfghjkl"));
      Console.WriteLine(MikeHammer);
      Console.WriteLine(JaneDoe);
      Console.WriteLine();
      Console.WriteLine("{0} vend sa voiture à {1}:", MikeHammer.Prenom, JaneDoe.Prenom);
      JaneDoe.BuyCar(MikeHammer);
      Console.WriteLine(MikeHammer);
      Console.WriteLine(JaneDoe);
      ConsoleTools.Pause();
    }
  }
}
