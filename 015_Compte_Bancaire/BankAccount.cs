using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_Compte_Bancaire {
  public class BankAccount {
    protected string _AccountNumber;
    protected double _Balance;
    protected double _Overdraft;

    public string AccountNumber {
      get { 
        return _AccountNumber;
      }
      protected set {
        if (IsValidAccountNumber(value)) {
          _AccountNumber = value;
        } else {
          throw new ArgumentException("Ceci n'est pas un numéro de compte valide", "AccountNumber");
        }
      }
    }
    public double Balance { get { return _Balance; } protected set { _Balance = value; } }
    public double Overdraft { get { return _Overdraft; } set { _Overdraft = -Math.Abs(value); } }

    /// <summary>
    /// Constructeur avec seulement le numéro de compte. Appelle le constructeur avec un découvert autorisé de 0€
    /// </summary>
    /// <param name="AccountNumber">Le numéro de compte</param>
    public BankAccount(string AccountNumber) 
      : this(AccountNumber, 0) { }

    /// <summary>
    /// Constructeur avec le numéro de compte et découvert autorisé donné. Appel le constructeur avec un solde de 0€
    /// </summary>
    /// <param name="AccountNumber">Le numéro de compte</param>
    /// <param name="Overdraft">Le découvert autorisé</param>
    public BankAccount(string AccountNumber, double Overdraft)
      : this(AccountNumber, Overdraft, 0) { }

    /// <summary>
    /// Construcgteur. 
    /// </summary>
    /// <param name="AccountNumber">Le numéro de compte</param>
    /// <param name="Overdraft">Le découvert autorisé</param>
    /// <param name="Balance">Le solde du compte</param>
    public BankAccount(string AccountNumber, double Overdraft, double Balance) {
      this.AccountNumber = AccountNumber;
      this.Overdraft = Overdraft;
      this.Balance = Balance;
    }

    /// <summary>
    /// Effectue un versement sur le compte.
    /// </summary>
    /// <param name="Amount">Quantité à verser</param>
    /// <returns>Le nouveau solde du compte après versement</returns>
    public double Deposit(double Amount) {
      if (Amount <= 0) {
        throw new ArgumentOutOfRangeException("Amount", "La valeur doit être strictement positive");
      } else {
        Balance += Amount;
      }
      return Balance;
    }

    /// <summary>
    /// Vérifie si un numéro de compte donné est valide ou non
    /// </summary>
    /// <param name="AccountNumber">Le numéro de compte à vérifier</param>
    /// <returns>'true' si le numéro de compte est correct. Sinon, retourne 'false'.</returns>
    protected bool IsValidAccountNumber(string AccountNumber) {
      long _NumberPart;
      long _VerificationPart;
      if (AccountNumber.Length != 12) {
        return false;
      } else if (long.TryParse(AccountNumber.Substring(0, 10), out _NumberPart) && long.TryParse(AccountNumber.Substring(10, 2), out _VerificationPart)) {
        if ((_NumberPart % 97) == _VerificationPart) {
          return true;
        } else {
          return false;
        }
      } else {
        return false;
      }
    }

    /// <summary>
    /// Effectue un retrait à partir du compte. Si le solde est insuffisant pour effectuer le retrait, une
    /// exception sera levée.
    /// </summary>
    /// <param name="Amount">Le montant à retirer</param>
    /// <returns>Le nouveau solde du compte après versement</returns>
    public double Withdraw(double Amount) {
      double _Balance = Balance;
      if (Amount <= 0) {
        throw new ArgumentOutOfRangeException("Amount", "La valeur doit être strictement positive");
      } else {
        _Balance -= Amount;
        if (_Balance < Overdraft) {
          // créer une exception personnalisée
          throw new Exception("Retrait interdit : balance trop basse");
        } else {
          Balance = _Balance;
        }
      }
      return Balance;
    }

    /// <summary>
    /// Formatage de l'objet sous forme de chaine de caractère.
    /// </summary>
    /// <returns>L'objet sous forme de chaine de caractère.</returns>
    public override string ToString() {
      string strReturn = "";
      strReturn += String.Format("Numéro de compte   : {0:###-#######-##}", long.Parse(AccountNumber)) + Environment.NewLine;
      strReturn += String.Format("Balance            : {0,12:# ### ###.00} EUR", Balance) + Environment.NewLine;
      strReturn += String.Format("Découvert autorisé : {0,12:# ### ###.00} EUR", Overdraft);
      return strReturn;
    }
  }
}
