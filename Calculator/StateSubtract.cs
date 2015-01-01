using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator {
  class StateSubtract : State {
    //Calculator calc;

    //public StateSubtract(Calculator calc) {
    //  this.calc = calc;
    //}
    public StateSubtract(Calculator calc) : base(calc) { }

    internal override void Compute() {
      calc.Result -= calc.Operand;
    }
  }
}
