using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _017_Jeu_de_role;

namespace _022_Mage {
  class Magus : Hero {
    private int _Power;
    protected readonly static int DefaultPower = 4;

    public int Power { get { return _Power; } protected set { _Power = value; } }

    public Magus(string Name) : this(Name, DefaultLifePoints) { }

    public Magus(string Name, int LifePoints) : this(Name, LifePoints, DefaultPower) { }

    public Magus(string Name, int LifePoints, int Power)
      : base(Name, LifePoints) {
      this.Power = Power;
    }

    public new void Attack(Hero Opponent) {
      for (int i = 0; i < Power; i++) {
        base.Attack(Opponent);
      }
    }

    public override string ToString() {
      return "!Mage! " + base.ToString();
    }
  }
}
