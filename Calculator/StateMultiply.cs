using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator {
  class StateMultiply : State {
    //Calculator calc;

    //public StateMultiply(Calculator calc) {
    //  this.calc = calc;
    //}
    public StateMultiply(Calculator calc) : base(calc) { }

    internal override void Compute() {
      calc.Result *= calc.Operand;
    }
  }
}
