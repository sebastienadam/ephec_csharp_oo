using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator {
  class StateDivide : State {
    //Calculator calc;

    //public StateDivide(Calculator calc) {
    //  this.calc = calc;
    //}
    public StateDivide(Calculator calc) : base(calc) { }

    internal override void Compute() {
      calc.Result /= calc.Operand;
    }
  }
}
