using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _039_radio_check {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    private void setChoice() {
      string menu = "";
      foreach (RadioButton item in groupBoxRadio.Controls) {
        if (item.Checked) {
          menu = item.Text;
          break;
        }
      }
      foreach (CheckBox item in groupBoxCheck.Controls) {
        if (item.Checked) {
          menu += ", " + item.Text;
        }
      }
      textBoxChoice.Text = menu;
    }

    private void control_CheckedChanged(object sender, EventArgs e) {
      string log = ((ButtonBase)sender).Text;
      Boolean checkd;
      if (sender is CheckBox) {
        checkd = ((CheckBox)sender).Checked;
      } else if (sender is RadioButton) {
        checkd = ((RadioButton)sender).Checked;
      } else {
        checkd = false;
      }
      if (checkd) {
        log += " sélectionné";
      } else {
        log += " désélectionné";
      }
      textBoxLog.AppendText(log + Environment.NewLine);
      setChoice();
    }
  }
}
