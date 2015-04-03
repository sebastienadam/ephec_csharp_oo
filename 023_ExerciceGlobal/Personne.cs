using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_ExerciceGlobal {
  public class Personne {
    private string _nom;
    private string _prenom;
    private CompteBancaire _compteBancaire;
    private Voiture _voiture;
    //private bool _venteEnCours = false;
    private CarteFideliteTaxecool _carteFidTaxecool;

    public string Nom { get { return _nom; } protected set { _nom = value; } }
    public string Prenom { get { return _prenom; } protected set { _prenom = value; } }
    public CompteBancaire CompteEnBanque { get { return _compteBancaire; } set { SetCompteEnBanque(value); } }
    public Voiture Voiture { get { return _voiture; } protected set { _voiture = value; } }
    public CarteFideliteTaxecool CarteDeFideliteTaxecool { get { return _carteFidTaxecool; } set { SetCarteDeFideliteTaxecool(value); } }

    public Personne(string Prenom, string Nom, CompteBancaire CompteEnBanque) {
      this.Nom = Nom;
      this.Prenom = Prenom;
      this.CompteEnBanque = CompteEnBanque;
      _voiture = null;
      _carteFidTaxecool = null;
    }

    public void AcheterVoiture(Personne Vendeur) {
      if (Vendeur == null) {
        throw new ArgumentNullException("Vendeur");
      } else if (Voiture != null) {
        throw new InvalidOperationException("Vous avez déjà une voiture !");
      } else if (Vendeur.Voiture == null) {
        throw new InvalidOperationException("Le vendeur n'a pas de voiture !");
      } else if (CompteEnBanque == null) {
        throw new InvalidOperationException("Vous n'avez pas de compte en banque !");
      } else if (Vendeur.CompteEnBanque == null) {
        throw new InvalidOperationException("Le vendeur n'a pas de compte en banque !");
      } else if (CompteEnBanque.Solde < Vendeur.Voiture.Prix) {
        throw new InvalidOperationException("Vous n'avez pas assez d'argent sur votre compte pour acheter la voiture!");
      } else {
        this.Voiture = Vendeur.Voiture;
        Vendeur.Voiture = null;
        this.CompteEnBanque.Retirer(Voiture.Prix);
        Vendeur.CompteEnBanque.Verser(Voiture.Prix);
      }
    }

    private void SetCarteDeFideliteTaxecool(CarteFideliteTaxecool CarteDeFideliteTaxecool) {
      if (CarteDeFideliteTaxecool == null) {
        throw new ArgumentNullException("CarteDeFideliteTaxecool");
      } else if (_carteFidTaxecool != null) {
        throw new InvalidOperationException("Vous avez déjà une carte de fidélité Taxecool !");
      } else {
        _carteFidTaxecool = CarteDeFideliteTaxecool;
      }
    }

    private void SetCompteEnBanque(CompteBancaire CompteEnBanque) {
      if (CompteEnBanque == null && _compteBancaire != null) {
        throw new ArgumentNullException("CompteEnBanque");
      } else if (_compteBancaire != null) {
        throw new InvalidOperationException("Vous avez déjà un compte en banque !");
      } else {
        _compteBancaire = CompteEnBanque;
      }
    }

    public void VendreVoiture(Personne Acheteur) {
      if (Acheteur == null) {
        throw new ArgumentNullException("Vendeur");
      } else if (Voiture == null) {
        throw new InvalidOperationException("Vous n'avez pas de voiture!");
      } else if (Acheteur.Voiture != null) {
        throw new InvalidOperationException("L'acheteur a déjà une voiture!");
      } else if (CompteEnBanque == null) {
        throw new InvalidOperationException("Vous n'avez pas de compte en banque!");
      } else if (Acheteur.CompteEnBanque == null) {
        throw new InvalidOperationException("L'acheteur n'a pas de compte en banque!");
      } else if (Acheteur.CompteEnBanque.Solde < Voiture.Prix) {
        throw new InvalidOperationException("L'acheteur n'a pas assez d'argent pour acheter votre voiture!");
      } else {
        Acheteur.Voiture = this.Voiture;
        Acheteur.CompteEnBanque.Retirer(Voiture.Prix);
        this.CompteEnBanque.Verser(Voiture.Prix);
        this.Voiture = null;
      }
    }
    /// <summary>
    /// Remplacement de la méthode ToString
    /// </summary>
    /// <returns>Une chaine de caractères représentant la personne</returns>
    public override string ToString() {
      StringBuilder Result = new StringBuilder();
      Result.AppendFormat("--- {0} {1} ---{2}", Prenom, Nom, Environment.NewLine);
      if (CompteEnBanque == null) {
        Result.Append("  * Pas de compte en banque" + Environment.NewLine);
      } else {
        Result.AppendFormat("  * Compte en banque n° {0} (solde = {1,12:# ### ###.00} EUR){2}", CompteEnBanque.NumeroCompte, CompteEnBanque.Solde, Environment.NewLine);
      }
      if (Voiture == null) {
        Result.Append("  * Pas de voiture" + Environment.NewLine);
      } else {
        Result.AppendFormat("  * Voiture {0} {1} @ {2}EUR avec {3} litres {4}", Voiture.Marque, Voiture.Modele, Voiture.Prix, Voiture.ContenuReservoire, Environment.NewLine);
      }
      if (CarteDeFideliteTaxecool != null) {
        Result.AppendFormat("  * Carte de fidélité Taxecool avec {0} points{1}", CarteDeFideliteTaxecool.NombreDePoints, Environment.NewLine);
      }
      return Result.ToString();
    }
  }
}
