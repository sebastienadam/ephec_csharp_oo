using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JeuBataille;

namespace _043_jeu_bataille_gui {
  public partial class FormMain : Form {
    Jeu JeuBataille;

    public FormMain() {
      InitializeComponent();
      JeuBataille = new Jeu();
    }

    private void buttonQuit_Click(object sender, EventArgs e) {
      this.Close();
    }

    private void buttonNewPlayer_Click(object sender, EventArgs e) {
      InputBox askForm = new InputBox("Nouveau joueur", "Nom du nouveau joueur");
      DialogResult result = askForm.ShowDialog();
      if(result == DialogResult.OK) {
        Joueur NouveauJoueur = new Joueur(askForm.Reply);
        JeuBataille.NouveauJoueur(NouveauJoueur);
        PanelPlayers.Controls.Add(new PlayerForm(JeuBataille, NouveauJoueur));
        if(PanelPlayers.Controls.Count > 1) {
          buttonStartGame.Enabled = true;
        }
      }
    }

    private void buttonStartGame_Click(object sender, EventArgs e) {
      JeuBataille.NouvellePartie();
      foreach(PlayerForm playerForm in PanelPlayers.Controls) {
        playerForm.Refresh();
      }
      while(!JeuBataille.AGagnant) {
        JeuBataille.Jouer();
        foreach(PlayerForm playerForm in PanelPlayers.Controls) {
          playerForm.Refresh();
        }
      }
    }
  }
}
