using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _017_Jeu_de_role;

namespace _019_Jeu_de_role {
  public class ArmedHero : Hero {
    private new readonly static BonusDice Dice = new BonusDice();
    protected Weapon _Weapon;

    public Weapon Weapon { get { return _Weapon; } protected set { SetWeapon(value); } }

    /// <summary>
    /// Constructeur avec seulement le nom donné. Le héros sera créé avec le nombre de points de vie
    /// par défaut.
    /// </summary>
    /// <param name="Name">Le nom du héros.</param>
    public ArmedHero(string Name) : this(Name, DefaultLifePoints) { }

    /// <summary>
    /// Constructeur avec le nom et le nombre de points de vie donnés. Le héros sera créé avec les
    /// poings (classe Fist) comme arme par défaut.
    /// </summary>
    /// <param name="Name">Le nom du héros.</param>
    /// <param name="LifePoints">Le nombre de points de vie.</param>
    public ArmedHero(string Name, int LifePoints) : this(Name, LifePoints, new Fist()) { }

    /// <summary>
    /// Constructeur avec le nom et l'arme donnés. Le héros sera créé avec le nombre de points de
    /// vie par défaut.
    /// </summary>
    /// <param name="Name">Le nom du héros.</param>
    /// <param name="Weapon">L'arme qui sera utilisée par le héros.</param>
    public ArmedHero(string Name, Weapon Weapon) : this(Name, DefaultLifePoints, Weapon) { }

    /// <summary>
    /// Constructeur avec le nom, le nombre de points de vie et l'arme donnés.
    /// </summary>
    /// <param name="Name">Le nom du héros.</param>
    /// <param name="LifePoints">Le nombre de points de vie.</param>
    /// <param name="Weapon">L'arme qui sera utilisée par le héros.</param>
    public ArmedHero(string Name, int LifePoints, Weapon Weapon)
      : base(Name, LifePoints) {
      if (Weapon == null) {
        throw new ArgumentNullException("Weapon");
      }
      this.Weapon = Weapon;
    }

    /// <summary>
    /// Constructeur avec le nom du héros, son nombre de points de vie, le nom de son arme et le
    /// nombre de points de bonus de son arme.
    /// </summary>
    /// <param name="Name">Le nom du héros.</param>
    /// <param name="LifePoints">Le nombre de points de vie.</param>
    /// <param name="WeaponName">Le nom de l'arme.</param>
    /// <param name="WeaponBonus">Le nombre de points de bonus de l'arme.</param>
    public ArmedHero(string Name, int LifePoints, string WeaponName, int WeaponBonus)
      : base(Name, LifePoints) {
      Weapon = new Weapon(WeaponName, WeaponBonus);
    }

    /// <summary>
    /// Surcharge de la méthode de la classe 'Hero' pour prendre en compte le bonus.
    /// </summary>
    /// <param name="Opponent">Le héros attaqué.</param>
    public override void Attack(Hero Opponent) {
      int OpponentDamage = Dice.Throw(Weapon.Bonus);
      Opponent.Damage(OpponentDamage);
    }

    /// <summary>
    /// Affecte l'attribut 'Weapon' d'après une arme donnée.
    /// </summary>
    /// <param name="Weapon">L'arme à affecter.</param>
    protected void SetWeapon(Weapon Weapon) {
      if (Weapon == null) {
        throw new ArgumentNullException("Weapon");
      }
      _Weapon = Weapon;
    }

    /// <summary>
    /// Donne une nouvelle arme au héros d'après une arme donnée.
    /// </summary>
    /// <param name="Weapon">L'arme à affecter.</param>
    public void NewWeapon(Weapon Weapon) {
      if (Weapon == null) {
        throw new ArgumentNullException("Weapon");
      }
      this.Weapon = Weapon;
    }

    /// <summary>
    /// Donne une nouvelle arme au héros sur base du nom et du nombre de points de bonus de l'arme. 
    /// </summary>
    /// <param name="Name">Nom de la nouvelle arme.</param>
    /// <param name="Bonus">Nombre de points bonus de la nouvelle arme.</param>
    public void NewWeapon(string Name, int Bonus) {
      Weapon = new Weapon(Name, Bonus);
    }

    /// <summary>
    /// Repésentation de l'objet sous forme de chaine de caractères.
    /// </summary>
    /// <returns>La repésentation de l'objet sous forme de chaine de caractères.</returns>
    public override string ToString() {
      if (IsDead) {
        return base.ToString();
      } else {
        return String.Format("{0} - équipé de {1}", base.ToString(), Convert.ToString(Weapon).ToLower());
      }
    }
  }
}
