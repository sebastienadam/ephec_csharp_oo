using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_Paiements {
  class Bank {
    /// <summary>
    /// Effectue un transfert d'argent entre deux comptes bancaires.
    /// </summary>
    /// <param name="Principal">Le compte du donneur d'ordre</param>
    /// <param name="Recipient">Le compte du bénéficiaire</param>
    /// <param name="Amount">Le montant à transférer</param>
    public void Transfer(BankAccount Principal, BankAccount Recipient, double Amount) {
      Principal.Withdraw(Amount);
      Recipient.Deposit(Amount);
    }
  }
}
