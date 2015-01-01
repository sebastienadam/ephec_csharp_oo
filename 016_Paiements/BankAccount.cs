using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _015_Compte_Bancaire;

namespace _016_Paiements {
  class BankAccount : _015_Compte_Bancaire.BankAccount {
    protected string _Name;

    public string Name { get { return _Name; } protected set { _Name = value; } }

    /// <summary>
    /// Constructeur avec nom du propriétaire et numéro de compte. Appelle le constructeur
    /// avec un dépassement autorisé de 0€.
    /// </summary>
    /// <param name="Name">Nom du propriétaire</param>
    /// <param name="AccountNumber">Numéro de compte</param>
    public BankAccount(string Name, string AccountNumber)
      : this(Name, AccountNumber, 0) { }

    /// <summary>
    /// Constructeur avec nom du propriétaire, numéro de compte et dépassement autorisé.
    /// Appelle le constructeur avec un solde de 0€
    /// </summary>
    /// <param name="Name">Nom du propriétaire</param>
    /// <param name="AccountNumber">Numéro de compte</param>
    /// <param name="Overdraft">Dépassement autorisé</param>
    public BankAccount(string Name, string AccountNumber, double Overdraft)
      : this(Name, AccountNumber, Overdraft, 0) { }

    /// <summary>
    /// Constructeur. Assigne le nom du propriétaire et appelle le constructeur du parent
    /// pour assigner le numéro de compte, le découvert accepté et le solde.
    /// </summary>
    /// <param name="Name">Nom du propriétaire</param>
    /// <param name="AccountNumber">Numéro de compte</param>
    /// <param name="Overdraft">Dépassement autorisé</param>
    /// <param name="Balance">Solde</param>
    public BankAccount(string Name, string AccountNumber, double Overdraft, double Balance)
      : base(AccountNumber, Overdraft, Balance) {
      this.Name = Name;
    }

    /// <summary>
    /// Effectue une paiement vers un autre compte bancaire.
    /// </summary>
    /// <param name="Recipient">Le compte bancaire qui doit recevoir le paiement</param>
    /// <param name="Amount">Le montant à payer</param>
    public void Pay(BankAccount Recipient, double Amount) {
      if (Amount <= 0) {
        throw new ArgumentOutOfRangeException("Amount", "La valeur doit être strictement positive");
      } else {
        Withdraw(Amount);
        Recipient.Deposit(Amount);
      }
    }

    /// <summary>
    /// Formatage de l'objet sous forme de chaine de caractère.
    /// </summary>
    /// <returns>L'objet sous forme de chaine de caractère.</returns>
    public override string ToString() {
      string strReturn = "";
      strReturn += "Nom                : " + Name + Environment.NewLine;
      strReturn += base.ToString();
      return strReturn;
    }
  }
}
