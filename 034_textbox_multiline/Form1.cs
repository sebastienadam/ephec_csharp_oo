using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _034_textbox_multiline {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
      labelCloneInput.Text = "";
    }

    private void textBoxInput_TextChanged(object sender, EventArgs e) {
      labelCloneInput.Text = textBoxInput.Text;
    }

    private void labelCloneInput_Click(object sender, EventArgs e) {
      if (labelCloneInput.ForeColor == Color.Red) {
        labelCloneInput.ForeColor = Color.Black;
      } else {
        labelCloneInput.ForeColor = Color.Red;
      }
    }

    private void buttonAdd_Click(object sender, EventArgs e) {
      textBoxMultiLine.Text += textBoxInput.Text + Environment.NewLine;
      textBoxInput.Text = "";
      textBoxInput.Select();
    }
  }
}
