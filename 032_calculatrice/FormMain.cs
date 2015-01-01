using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator;

namespace _032_calculatrice {
  public partial class FormMain : Form {

    Calculator.Calculator calc;
    StringBuilder input;

    public FormMain() {
      InitializeComponent();
      calc = new Calculator.Calculator();
      input = new StringBuilder();
    }

    private CaluclatorAction GetCaluclatorAction(String Sign) {
      switch (Sign) {
        case "+":
          return CaluclatorAction.Add;
        //case "c":
        case "C":
          return CaluclatorAction.Clear;
        //case ":":
        case "/":
          return CaluclatorAction.Divide;
        //case "x":
        //case "X":
        case "*":
          return CaluclatorAction.Multiply;
        case "=":
          return CaluclatorAction.Result;
        case "-":
          return CaluclatorAction.Subtract;
        default:
          throw new ArgumentException("Unknown action (" + Sign+")", "Sing");
      }
    }

    private void ButtonNumber_Click(object sender, EventArgs e) {
      Button ButtonSender = (Button)sender;
      input.Append(ButtonSender.Text);
      TextBoxDisplay.Text = input.ToString();
    }

    private void ButtonComma_Click(object sender, EventArgs e) {
      if (input.ToString().Contains(",")) {
        input.Append(",");
      }
    }

    private void ButtonAction_Click(object sender, EventArgs e) {
      Button ButtonSender = (Button)sender;
      double result;
      double value;
      if (!Double.TryParse(input.ToString(),out value)) {
        value = double.NaN;
      }
      input.Clear();
      try {
        result = calc.Action(value, GetCaluclatorAction(ButtonSender.Text));
        TextBoxDisplay.Text = result.ToString();
      } catch (Exception Exept) {
         MessageBox.Show(Exept.Source+" : "+Exept.Message);
      }
    }
  }
}
