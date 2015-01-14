using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _035_dons {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
      labelCongrat.Text = "";
    }

    private void buttonValidate_Click(object sender, EventArgs e) {
      labelThanks.Visible = true;
    }

    private void comboBoxSelectValue_SelectedIndexChanged(object sender, EventArgs e) {
      labelThanks.Visible = false;
      switch (comboBoxSelectValue.Text) {
        case "1":
          labelCongrat.Text = "OK";
          break;
        case "10":
          labelCongrat.Text = "Cool";
          break;
        case "100":
          labelCongrat.Text = "Waow";
          break;
        case "1000":
          labelCongrat.Text = "Génial";
          break;
        default:
      labelCongrat.Text = "";
          break;
      }
    }
  }
}
