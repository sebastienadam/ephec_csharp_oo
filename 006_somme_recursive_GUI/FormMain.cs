using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;

namespace _006_somme_recursive_GUI {
  public partial class FormMain : Form {
    private int SommeRecursive(int n) {
      if (n <= 1) {
        return n;
      } else {
        return n + SommeRecursive(n - 1);
      }
    }

    public FormMain() {
      InitializeComponent();
    }

    private void textBox1_KeyPress(object sender, KeyPressEventArgs e) {
      e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
    }

    private void buttonSum_Click(object sender, EventArgs e) {
      int num;
      string enteredValue = textBoxNum.Text;
      if (enteredValue == "") {
        labelResult.Text = "";
      } else {
        num = Int32.Parse(enteredValue);
        labelResult.Text = "La somme des nombres entre 0 et " + num + " vaut " + SommeRecursive(num);
      }
    }
  }
}
