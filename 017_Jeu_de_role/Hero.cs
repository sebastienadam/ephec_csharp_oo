using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _012_Dice;

namespace _017_Jeu_de_role {
  public class Hero {
    protected string _Name;
    protected int _LifePoints;
    protected readonly static Dice Dice = new Dice();
    protected readonly static int DefaultLifePoints = 20;

    public string Name { get { return _Name; } protected set { _Name = value; } }
    public int LifePoints { get { return _LifePoints; } protected set { _LifePoints = value; } }
    public bool IsDead { get { return (LifePoints <= 0); } }

    /// <summary>
    /// Constructeur sans points de vie, appele le constructeur principal avec 20 points de vie.
    /// </summary>
    /// <param name="Name">Nom du héros</param>
    public Hero(string Name) : this(Name, DefaultLifePoints) { }

    /// <summary>
    /// Constructeur.
    /// </summary>
    /// <param name="Name">Nom du héros</param>
    /// <param name="LifePoints">Nombre de points de vie</param>
    public Hero(string Name, int LifePoints) {
      this.Name = Name;
      this.LifePoints = LifePoints;
    }

    /// <summary>
    /// Attaque une autre héros. Les dommages infligés à l'opposant sont aléatoires.
    /// </summary>
    /// <param name="Opponent">Le héros attaqué</param>
    public virtual void Attack(Hero Opponent) {
      if(Opponent == null) {
        throw new ArgumentNullException("Opponent");
      } else {
        Dice.Throw();
        Opponent.Damage(Dice.Value);
      }
    }

    /// <summary>
    /// Reçoit des coups!
    /// </summary>
    /// <param name="value">Nombre de points de vie perdus</param>
    /// <returns>Le nombre de points de vie restant</returns>
    public int Damage(int value) {
      LifePoints -= Math.Abs(value);
      if(LifePoints < 0) {
        LifePoints = 0;
      }
      return LifePoints;
    }

    /// <summary>
    /// Duel à mort avec une opposant
    /// </summary>
    /// <param name="Opponent">L'opposant avec qui le duel sera effectué</param>
    public void Duel(Hero Opponent) {
      if(Opponent == null) {
        throw new ArgumentNullException("Opponent");
      }
      while(true) {
        Attack(Opponent);
        if(Opponent.IsDead) {
          break;
        }
        Opponent.Attack(this);
        if(IsDead) {
          break;
        }
      }
    }

    /// <summary>
    /// Repésentation de l'objet sous forme de chaine de caractères
    /// </summary>
    /// <returns>La repésentation de l'objet sous forme de chaine de caractères</returns>
    public override string ToString() {
      if(IsDead) {
        return String.Format("#{0}# - Mort!", Name);
      } else {
        return String.Format("{0} - {1}PV", Name, LifePoints);
      }
    }
  }
}
