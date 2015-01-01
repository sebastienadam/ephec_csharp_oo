namespace _003_Figure_GUI {
  partial class FormMain {
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
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
      this.buttonGenerate = new System.Windows.Forms.Button();
      this.numUpDownNbLines = new System.Windows.Forms.NumericUpDown();
      this.labelNbLines = new System.Windows.Forms.Label();
      this.textBox = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDownNbLines)).BeginInit();
      this.SuspendLayout();
      // 
      // buttonGenerate
      // 
      this.buttonGenerate.Location = new System.Drawing.Point(172, 10);
      this.buttonGenerate.Name = "buttonGenerate";
      this.buttonGenerate.Size = new System.Drawing.Size(75, 23);
      this.buttonGenerate.TabIndex = 0;
      this.buttonGenerate.Text = "Générer";
      this.buttonGenerate.UseVisualStyleBackColor = true;
      this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
      // 
      // numUpDownNbLines
      // 
      this.numUpDownNbLines.Location = new System.Drawing.Point(110, 10);
      this.numUpDownNbLines.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
      this.numUpDownNbLines.Name = "numUpDownNbLines";
      this.numUpDownNbLines.Size = new System.Drawing.Size(56, 20);
      this.numUpDownNbLines.TabIndex = 1;
      // 
      // labelNbLines
      // 
      this.labelNbLines.AutoSize = true;
      this.labelNbLines.Location = new System.Drawing.Point(9, 12);
      this.labelNbLines.Name = "labelNbLines";
      this.labelNbLines.Size = new System.Drawing.Size(95, 13);
      this.labelNbLines.TabIndex = 2;
      this.labelNbLines.Text = "Nombre de lignes :";
      // 
      // textBox
      // 
      this.textBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox.Location = new System.Drawing.Point(12, 39);
      this.textBox.Multiline = true;
      this.textBox.Name = "textBox";
      this.textBox.Size = new System.Drawing.Size(235, 203);
      this.textBox.TabIndex = 3;
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(262, 254);
      this.Controls.Add(this.textBox);
      this.Controls.Add(this.labelNbLines);
      this.Controls.Add(this.numUpDownNbLines);
      this.Controls.Add(this.buttonGenerate);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "FormMain";
      this.Text = "Figure";
      this.Load += new System.EventHandler(this.FormMain_Load);
      ((System.ComponentModel.ISupportInitialize)(this.numUpDownNbLines)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonGenerate;
    private System.Windows.Forms.NumericUpDown numUpDownNbLines;
    private System.Windows.Forms.Label labelNbLines;
    private System.Windows.Forms.TextBox textBox;
  }
}

