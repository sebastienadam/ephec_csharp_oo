using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _038_font_color {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    private void buttonChangeFont_Click(object sender, EventArgs e) {
      DialogResult _res = fontDialog.ShowDialog();
      if (_res.Equals(DialogResult.OK)) {
        label.Font = fontDialog.Font;
      }
    }

    private void buttonChangeColor_Click(object sender, EventArgs e) {
      DialogResult _res = colorDialog.ShowDialog();
      if (_res.Equals(DialogResult.OK)) {
        label.ForeColor = colorDialog.Color;
      }
    }
  }
}
