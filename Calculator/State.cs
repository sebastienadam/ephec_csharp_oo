using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator {
  abstract internal class State {
    protected Calculator calc;

    internal State(Calculator calc) {
      this.calc = calc;
    }

    abstract internal void Compute();
  }
}
