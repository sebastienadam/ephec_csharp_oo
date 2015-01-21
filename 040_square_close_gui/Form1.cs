using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _040_square_close_gui {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
      textBox.AppendText("1");
      for (int i = 2; i <= 20; i++) {
        textBox.AppendText(" - "+(i * i).ToString());
      }
    }

    private void buttonClose_Click(object sender, EventArgs e) {
      Close();
    }

    private void Form1_Load(object sender, EventArgs e) {
      MessageBox.Show("Chargement de la forme");
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
      DialogResult _res = MessageBox.Show("Êtes-vous sûr de vouloir quitter l'application ?", "Confirmation fermeture", MessageBoxButtons.YesNo);
      if (_res == DialogResult.Yes) {
        e.Cancel = false;
      } else {
        e.Cancel = true;
      }
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
      MessageBox.Show("Fin de l'application à " + DateTime.Now);
    }
  }
}
