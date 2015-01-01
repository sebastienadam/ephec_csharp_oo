using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_ExerciceGlobal {
  public class CompteBancaire {
    protected string _AccountNumber;
    protected double _Balance;
    protected double _Overdraft;

    public string NumeroCompte {
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
    public double Solde { get { return _Balance; } protected set { _Balance = value; } }

    /// <summary>
    /// Constructeur avec seulement le numéro de compte. Appelle le constructeur avec un découvert autorisé de 0€
    /// </summary>
    /// <param name="NumeroCompte">Le numéro de compte</param>
    public CompteBancaire(string NumeroCompte) 
      : this(NumeroCompte, 0) { }

    /// <summary>
    /// Construcgteur. 
    /// </summary>
    /// <param name="NumeroCompte">Le numéro de compte</param>
    /// <param name="Balance">Le solde du compte</param>
    public CompteBancaire(string NumeroCompte, double Balance) {
      this.NumeroCompte = NumeroCompte;
      this.Solde = Balance;
    }

    /// <summary>
    /// Effectue un versement sur le compte.
    /// </summary>
    /// <param name="Montant">Quantité à verser</param>
    /// <returns>Le nouveau solde du compte après versement</returns>
    public double Verser(double Montant) {
      if (Montant <= 0) {
        throw new ArgumentOutOfRangeException("Montant", "La valeur doit être strictement positive");
      } else {
        Solde += Montant;
      }
      return Solde;
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
    /// <param name="Montant">Le montant à retirer</param>
    /// <returns>Le nouveau solde du compte après versement</returns>
    public double Retirer(double Montant) {
      double _Balance = Solde;
      if (Montant <= 0) {
        throw new ArgumentOutOfRangeException("Montant", "La valeur doit être strictement positive");
      } else {
        _Balance -= Montant;
        if (_Balance < 0) {
          // créer une exception personnalisée
          throw new Exception("Retrait interdit : balance trop basse");
        } else {
          Solde = _Balance;
        }
      }
      return Solde;
    }

    /// <summary>
    /// Formatage de l'objet sous forme de chaine de caractère.
    /// </summary>
    /// <returns>L'objet sous forme de chaine de caractère.</returns>
    public override string ToString() {
      string strReturn = "";
      strReturn += String.Format("Numéro de compte   : {0:###-#######-##}", long.Parse(NumeroCompte)) + Environment.NewLine;
      strReturn += String.Format("Balance            : {0,12:# ### ###.00} EUR", Solde) + Environment.NewLine;
      return strReturn;
    }
  }
}
