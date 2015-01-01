using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator {
  public enum CaluclatorAction { Add, Clear, Divide, Multiply, Result, Subtract };

  public class Calculator {
    private double _operand;
    private double _result;
    private State _stateAdd;
    private State _stateClear;
    private State _stateDivide;
    private State _stateMultiply;
    private State _stateSubtract;

    private State CurrentState;
    public double Result { get { return _result; } internal set { _result = value; } }
    internal double Operand { get { return _operand; } set { _operand = value; } }

    public Calculator() {
      _stateAdd = new StateAdd(this);
      _stateClear = new StateClear(this);
      _stateDivide = new StateDivide(this);
      _stateMultiply = new StateMultiply(this);
      _stateSubtract = new StateSubtract(this);

      CurrentState = _stateClear;
      Clear();
    }

    public double Action(double Number, CaluclatorAction NextAction) {
      if (NextAction == CaluclatorAction.Clear) {
        Clear();
      } else if (!Double.IsNaN(Number)) {
        Operand = Number;
        CurrentState.Compute();
      } else if (NextAction == CaluclatorAction.Result) {
        CurrentState.Compute();
      }
      SetState(NextAction);
      return Result;
    }

    private void Clear() {
      Result = 0;
      Operand = 0;
    }

    private void SetState(CaluclatorAction Action) {
      switch (Action) {
        case CaluclatorAction.Add:
          CurrentState = _stateAdd;
          break;
        case CaluclatorAction.Clear:
          CurrentState = _stateClear;
          break;
        case CaluclatorAction.Divide:
          CurrentState = _stateDivide;
          break;
        case CaluclatorAction.Multiply:
          CurrentState = _stateMultiply;
          break;
        case CaluclatorAction.Result:
          // do nothing, result just compute last action.
          break;
        case CaluclatorAction.Subtract:
          CurrentState = _stateSubtract;
          break;
        default:
          throw new NotImplementedException(Action + " not yet implemented");
      }
    }
  }
}
