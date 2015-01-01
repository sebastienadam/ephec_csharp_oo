using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator {
  class StateClear : State {
    //Calculator calc;

    //public StateClear(Calculator calc) {
    //  this.calc = calc;
    //}
    public StateClear(Calculator calc) : base(calc) { }

    internal override void Compute() {
      calc.Result = calc.Operand;
    }
  }
}
