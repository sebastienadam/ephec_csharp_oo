using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019_Jeu_de_role {
  public class Weapon {
    protected string _Name;
    protected int _Bonus;

    public string Name { get { return _Name; } protected set { _Name = value; } }
    public int Bonus { get { return _Bonus; } protected set { _Bonus = value; } }

    public Weapon(string Name, int Bonus) {
      this.Name = Name;
      this.Bonus = Bonus;
    }

    public override string ToString() {
      return String.Format("{0} ({1} points de bonus)", Name, Bonus);
    }
  }
}
