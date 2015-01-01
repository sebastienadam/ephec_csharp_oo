using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Dice {
  public class Dice {
    protected int _nbFaces;
    protected int _value;
    protected Random rnd;

    public int Value { get { return _value; } protected set { _value = value; } }
    public int NbFaces { get { return _nbFaces; } protected set { _nbFaces = value; } }

    public Dice()
      : this(6) {
    }

    public Dice(int NbFaces) {
      rnd = new Random();
      this.NbFaces = NbFaces;
      this.Throw();
    }

    public int Throw() {
      // on ne peut par créer un objet Random ici.
      Value = rnd.Next(NbFaces) + 1;
      return Value;
    }
  }
}
