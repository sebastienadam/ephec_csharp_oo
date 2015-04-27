using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JeuBataille;
using JeuDeCartes;

namespace _043_jeu_bataille_gui {
  public partial class PlayerForm : UserControl {
    private Jeu Jeu;
    private Joueur JoueurCourant;

    public PlayerForm(Jeu Jeu, Joueur Joueur) {
      InitializeComponent();
      this.Jeu = Jeu;
      this.JoueurCourant = Joueur;
      Refresh();
    }

    public override void Refresh() {
      base.Refresh();
      labelName.Text = JoueurCourant.ToString();
      try {
        labelTable.Text = "";
        foreach(Carte Carte in Jeu.Table.CartesDonnees[JoueurCourant]) {
          labelTable.Text += Carte.ToString() + Environment.NewLine;
        }
      } catch(Exception) {
        labelTable.Text = "";
      }
    }
  }
}
