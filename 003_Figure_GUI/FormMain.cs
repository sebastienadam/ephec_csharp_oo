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

namespace _003_Figure_GUI {
  public partial class FormMain : Form {
    public FormMain() {
      InitializeComponent();
    }

    private void buttonGenerate_Click(object sender, EventArgs e) {
      int nbLines = (int)numUpDownNbLines.Value;
      textBox.Text = "";
      for (int i = 0; i < nbLines; i++) {
        textBox.AppendText("*" + StringTools.MultiChar(' ', i) + "*" + Environment.NewLine);
      }

    }

    private void FormMain_Load(object sender, EventArgs e) {

    }
  }
}
