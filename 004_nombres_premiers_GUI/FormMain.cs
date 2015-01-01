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

namespace _004_nombres_premiers_GUI {
  public partial class FormMain : Form {
    public FormMain() {
      InitializeComponent();
    }

    private void textBoxTestNum_KeyPress(object sender, KeyPressEventArgs e) {
      e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
    }

    private void buttonTestNum_Click(object sender, EventArgs e) {
      int num;
      string enteredValue = textBoxTestNum.Text;
      if (enteredValue == "") {
        labelResult.Text = "";
      } else {
        num = Int32.Parse(enteredValue);
        if (NumericTools.IsPrime(num)) {
          labelResult.ForeColor = System.Drawing.Color.Green;
          labelResult.Text = num + " est un nombre premier!";
        } else {
          labelResult.ForeColor = System.Drawing.Color.Red;
          labelResult.Text = num + " N'est PAS un nombre premier!";
        }
      }
    }
  }
}
