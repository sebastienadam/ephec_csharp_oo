using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator {
  class StateAdd : State {
    //Calculator calc;

    //public StateAdd(Calculator calc) {
    //  this.calc = calc;
    //}
    public StateAdd(Calculator calc) : base(calc) { }

    internal override void Compute() {
      calc.Result += calc.Operand;
    }
  }
}
