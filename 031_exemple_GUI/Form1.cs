using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _031_exemple_GUI {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    private bool IsSaisieEmpty() {
      return ZoneSaisie.Text.Equals("");
    }

    private void BouttonAfficher_Click(object sender, EventArgs e) {
      if (IsSaisieEmpty()) {
        Resultat.Text = "Saisie vide";
      } else {
        Resultat.Text = ZoneSaisie.Text;
      }
    }

    private void BoutonEffacer_Click(object sender, EventArgs e) {
      ZoneSaisie.Text = "";
    }

    private void BoutonMessageBox_Click(object sender, EventArgs e) {
      if (IsSaisieEmpty()) {
        DialogResult Result;
        bool again;
        do {
          again = false;
          Result = MessageBox.Show("Etes-vous sûr de ne rien vouloir saisir ?", "Saisie vide", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
          if (Result == DialogResult.No) {
            MessageBox.Show("Il me semblait bien","Saisie vide");
          } else if (Result == DialogResult.Yes) {
            MessageBox.Show("OK: c’est vous qui voyez","Saisie vide");
          } else {
            MessageBox.Show("Ne touchez pas à ce bouton!!!!", "*** ERREUR ***", MessageBoxButtons.OK, MessageBoxIcon.Error);
            again = true;
          }
        } while (again);
      }
    }
  }
}
