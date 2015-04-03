using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _009_progoo;
using _010_voiture;

namespace _020_Personne {
  class Personne : _009_progoo.Personne {
    private Personne _partner;
    private bool _inDivorceProceedings;
    private Car _OwnedCar;

    public Personne Partner { get { return _partner; } protected set { _partner = value; } }
    public Car OwnedCar { get { return _OwnedCar; } protected set { _OwnedCar = value; } }

    /// <summary>
    /// Constructeur.
    /// </summary>
    /// <param name="Nom">Nom de famille.</param>
    /// <param name="Prenom">Prénom.</param>
    /// <param name="AnneeNaissance">Année de naissance.</param>
    public Personne(string Nom, string Prenom, int AnneeNaissance)
      : base(Nom, Prenom, AnneeNaissance) {
        Partner = null;
        OwnedCar = null;
        _inDivorceProceedings = false;
    }

    /// <summary>
    /// Achète une voiture. Si la personne possède déjà une voiture, lève une
    /// exception de type 'InvalidOperationException'.
    /// </summary>
    /// <param name="NewCar">La voiture achetée.</param>
    public void BuyCar(Car NewCar) {
      if (NewCar == null) {
        throw new ArgumentNullException("NewCar");
      } else if (OwnedCar == null) {
        OwnedCar = NewCar;
      } else {
        throw new InvalidOperationException("Une personne ne peut posséder qu'une seule voiture!");
      }
    }

    /// <summary>
    /// Achète une voiture à une autre personne.
    /// </summary>
    /// <param name="Seller">Le vendeur de la voiture.</param>
    public void BuyCar(Personne Seller) {
      if (Seller == null) {
        throw new ArgumentNullException("Seller");
      } else {
        Seller.SellCar(this);
      }
    }

    /// <summary>
    /// Divorce du partenaire actuel. Si la personne n'a pas de partenaire,
    /// lève une exception de type 'InvalidOperationException'.
    /// </summary>
    public void Divorce() {
      if (Partner == null) {
        throw new InvalidOperationException("Une personne célibataire ne peut pas divorcer!");
      } else {
        //if (!_inDivorceProceedings) {
        //  _inDivorceProceedings = true;
        //  Partner.Divorce();
        //  Partner = null;
        //  _inDivorceProceedings = false;
        //}
        Partner.Partner = null;
        Partner = null;
      }
    }

    /// <summary>
    /// Épouse une autre personne. Le nouveau partenaire sera également mis à
    /// jour. Si la personne est déjà marriée, lève une exception de type
    /// 'InvalidOperationException'.
    /// </summary>
    /// <param name="NewPartner">La personne avec qui la personne actuelle va se marrier.</param>
    public void Marry(Personne NewPartner) {
      if (Partner == null) {
        Partner = NewPartner;
        NewPartner.Marry(this);
      } else if (this.Partner.Equals(NewPartner)) {
        // do nothing
      } else {
        throw new InvalidOperationException("Une personne marriée ne peut se marrier une seconde fois!");
      }
    }

    /// <summary>
    /// Vend sa voiture à une autre personne. Si la personne ne possède pas de
    /// voiture, lève une exception de type 'InvalidOperationException'.
    /// </summary>
    /// <param name="Buyer"></param>
    public void SellCar(Personne Buyer) {
      if (OwnedCar == null) {
        throw new InvalidOperationException("On ne peut pas vendre une voiture si on n'en a pas!");
      } else {
        Buyer.BuyCar(OwnedCar);
        OwnedCar = null;
      }
    }

    /// <summary>
    /// Remplacement de la méthode ToString
    /// </summary>
    /// <returns>Une chaine de caractères représentant la personne</returns>
    public override string ToString() {
      string PartnerString;
      string CarString;
      if (Partner == null) {
        PartnerString = "célibataire";
      } else {
        PartnerString = String.Format("marrié(e) à {0} {1}", Partner.Prenom, Partner.Nom);
      }
      if (OwnedCar == null) {
        CarString = "ne possédant pas de voiture";
      } else {
        CarString = String.Format("possédant une {0} {1}", OwnedCar.Marque, OwnedCar.Modele);
      }
      return String.Format("{0}, {1} et {2}", base.ToString(), PartnerString, CarString);
    }
  }
}
