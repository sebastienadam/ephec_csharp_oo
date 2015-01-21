namespace _038_font_color {
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
      this.colorDialog = new System.Windows.Forms.ColorDialog();
      this.fontDialog = new System.Windows.Forms.FontDialog();
      this.label = new System.Windows.Forms.Label();
      this.buttonChangeColor = new System.Windows.Forms.Button();
      this.buttonChangeFont = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label
      // 
      this.label.Location = new System.Drawing.Point(12, 9);
      this.label.Name = "label";
      this.label.Size = new System.Drawing.Size(434, 96);
      this.label.TabIndex = 0;
      this.label.Text = "Donnez à ce monsieur au chapeau un verre de ce qu\'il voudra";
      // 
      // buttonChangeColor
      // 
      this.buttonChangeColor.Location = new System.Drawing.Point(77, 123);
      this.buttonChangeColor.Name = "buttonChangeColor";
      this.buttonChangeColor.Size = new System.Drawing.Size(75, 23);
      this.buttonChangeColor.TabIndex = 1;
      this.buttonChangeColor.Text = "Couleur";
      this.buttonChangeColor.UseVisualStyleBackColor = true;
      this.buttonChangeColor.Click += new System.EventHandler(this.buttonChangeColor_Click);
      // 
      // buttonChangeFont
      // 
      this.buttonChangeFont.Location = new System.Drawing.Point(283, 123);
      this.buttonChangeFont.Name = "buttonChangeFont";
      this.buttonChangeFont.Size = new System.Drawing.Size(75, 23);
      this.buttonChangeFont.TabIndex = 2;
      this.buttonChangeFont.Text = "Police";
      this.buttonChangeFont.UseVisualStyleBackColor = true;
      this.buttonChangeFont.Click += new System.EventHandler(this.buttonChangeFont_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(458, 178);
      this.Controls.Add(this.buttonChangeFont);
      this.Controls.Add(this.buttonChangeColor);
      this.Controls.Add(this.label);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ColorDialog colorDialog;
    private System.Windows.Forms.FontDialog fontDialog;
    private System.Windows.Forms.Label label;
    private System.Windows.Forms.Button buttonChangeColor;
    private System.Windows.Forms.Button buttonChangeFont;
  }
}

