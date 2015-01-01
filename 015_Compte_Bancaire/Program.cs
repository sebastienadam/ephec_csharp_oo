using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace _015_Compte_Bancaire {
  class Program {

    static void Main(string[] args) {
      BankAccount bc;
      bool Again = true;
      char Choice = '_';
      double Amount;
      char[] MenuOptions = { 'd', 'D', 'r', 'R', 'q', 'Q' };
      ConsoleTools.WriteTitle("Comptes bancaires");
      Console.WriteLine("Création d'un compte avec un numéro erroné:");
      try {
        bc = new BankAccount("123456789012");
        Console.WriteLine(bc);
      } catch (Exception AE) {
        Console.WriteLine("Erreur survenue : " + AE.GetType());
        Console.WriteLine(AE.Message);
      }
      Console.WriteLine();
      Console.WriteLine("Création d'un compte avec un numéro correct:");
      bc = new BankAccount("123456789002", 250, 1000);
      Console.WriteLine(bc);
      ConsoleTools.Pause();
      while (Again) {
        Console.Clear();
        ConsoleTools.WriteTitle("Comptes bancaires");
        Console.WriteLine(bc);
        Choice = Char.ToLower(Choice);
        switch (Choice) {
          case 'd':  // dépôt
            Console.WriteLine();
            Amount = KeyboardTools.ReadDouble("Montant du dépôt   : ", 0.0);
            try {
              bc.Deposit(Amount);
            } catch (Exception e) {
              Console.WriteLine(e.Message);
            }
            Console.WriteLine("Nouveau solde      : {0,12:# ### ###.00} EUR", bc.Balance);
            Console.WriteLine();
            break;
          case 'r':  // retrait
            Console.WriteLine();
            Amount = KeyboardTools.ReadDouble("Montant du retrait : ", 0.0);
            try {
              bc.Withdraw(Amount);
            } catch (Exception e) {
              Console.WriteLine(e.Message);
            }
            Console.WriteLine("Nouveau solde      : {0,12:# ### ###.00} EUR", bc.Balance);
            Console.WriteLine();
            break;
          case 'q':
            Again = false;
            break;
        }
        if (Again) {
          Console.WriteLine();
          Console.WriteLine("Opérations :");
          Console.WriteLine("  d : Dépôt");
          Console.WriteLine("  r : Retrait");
          Console.WriteLine("  q : Quitter");
          Choice = KeyboardTools.ReadChar("Votre choix : ", MenuOptions);
        }
      }
      Console.WriteLine();
      Console.WriteLine("Au revoir");
      ConsoleTools.Pause();
    }
  }
}
