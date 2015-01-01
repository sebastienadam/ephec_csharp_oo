using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace _016_Paiements {
  class Program {
    static void Main(string[] args) {
      BankAccount AccountMax = new BankAccount("Max", "741025896329", 500, 1200);
      BankAccount AccountSam = new BankAccount("Sam", "987456321070", 750, 900);
      Bank MyBank = new Bank();
      double Amount;
      ConsoleTools.WriteTitle("Paiements");
      Console.WriteLine("Comptes:");
      Console.WriteLine(AccountMax);
      Console.WriteLine(AccountSam);
      Console.WriteLine();
      Amount = 450;
      Console.WriteLine("Transfert de {0:#.00} EUR depuis le compte de Max vers celui de Sam via la banque :", Amount);
      try {
        MyBank.Transfer(AccountMax, AccountSam, Amount);
      } catch (Exception E) {
        Console.WriteLine(E.Message);
      }
      Console.WriteLine("Solde {1}: {0,8:# ###.00} EUR", AccountMax.Balance, AccountMax.Name);
      Console.WriteLine("Solde {1}: {0,8:# ###.00} EUR", AccountSam.Balance, AccountSam.Name);
      Console.WriteLine();
      Amount = 250;
      Console.WriteLine("Transfert directe de {0:#.00} EUR depuis le compte de Sam vers celui de Max :", Amount);
      try {
        AccountSam.Pay(AccountMax, Amount);
      } catch (Exception E) {
        Console.WriteLine(E.Message);
      }
      Console.WriteLine("Solde {1}: {0,8:# ###.00} EUR", AccountMax.Balance, AccountMax.Name);
      Console.WriteLine("Solde {1}: {0,8:# ###.00} EUR", AccountSam.Balance, AccountSam.Name);
      Console.WriteLine();
      ConsoleTools.Pause();
    }
  }
}
