namespace _031_exemple_GUI {
  partial class Form1 {
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent() {
      this.BouttonAfficher = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.ZoneSaisie = new System.Windows.Forms.TextBox();
      this.Resultat = new System.Windows.Forms.Label();
      this.BoutonEffacer = new System.Windows.Forms.Button();
      this.BoutonMessageBox = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // BouttonAfficher
      // 
      this.BouttonAfficher.Location = new System.Drawing.Point(38, 89);
      this.BouttonAfficher.Name = "BouttonAfficher";
      this.BouttonAfficher.Size = new System.Drawing.Size(96, 23);
      this.BouttonAfficher.TabIndex = 1;
      this.BouttonAfficher.Text = "Afficher";
      this.BouttonAfficher.UseVisualStyleBackColor = true;
      this.BouttonAfficher.Click += new System.EventHandler(this.BouttonAfficher_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(38, 44);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(78, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Entrez un texte";
      // 
      // ZoneSaisie
      // 
      this.ZoneSaisie.Location = new System.Drawing.Point(122, 41);
      this.ZoneSaisie.Name = "ZoneSaisie";
      this.ZoneSaisie.Size = new System.Drawing.Size(210, 20);
      this.ZoneSaisie.TabIndex = 0;
      // 
      // Resultat
      // 
      this.Resultat.AutoSize = true;
      this.Resultat.Location = new System.Drawing.Point(119, 64);
      this.Resultat.Name = "Resultat";
      this.Resultat.Size = new System.Drawing.Size(35, 13);
      this.Resultat.TabIndex = 3;
      this.Resultat.Text = "*******";
      // 
      // BoutonEffacer
      // 
      this.BoutonEffacer.Location = new System.Drawing.Point(140, 89);
      this.BoutonEffacer.Name = "BoutonEffacer";
      this.BoutonEffacer.Size = new System.Drawing.Size(96, 23);
      this.BoutonEffacer.TabIndex = 4;
      this.BoutonEffacer.Text = "Effacer";
      this.BoutonEffacer.UseVisualStyleBackColor = true;
      this.BoutonEffacer.Click += new System.EventHandler(this.BoutonEffacer_Click);
      // 
      // BoutonMessageBox
      // 
      this.BoutonMessageBox.Location = new System.Drawing.Point(242, 89);
      this.BoutonMessageBox.Name = "BoutonMessageBox";
      this.BoutonMessageBox.Size = new System.Drawing.Size(96, 23);
      this.BoutonMessageBox.TabIndex = 5;
      this.BoutonMessageBox.Text = "MessageBox";
      this.BoutonMessageBox.UseVisualStyleBackColor = true;
      this.BoutonMessageBox.Click += new System.EventHandler(this.BoutonMessageBox_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(378, 147);
      this.Controls.Add(this.BoutonMessageBox);
      this.Controls.Add(this.BoutonEffacer);
      this.Controls.Add(this.Resultat);
      this.Controls.Add(this.ZoneSaisie);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.BouttonAfficher);
      this.Name = "Form1";
      this.Text = "Première application";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button BouttonAfficher;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox ZoneSaisie;
    private System.Windows.Forms.Label Resultat;
    private System.Windows.Forms.Button BoutonEffacer;
    private System.Windows.Forms.Button BoutonMessageBox;
  }
}

