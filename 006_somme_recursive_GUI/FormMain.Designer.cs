namespace _006_somme_recursive_GUI {
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
      this.labelNbr = new System.Windows.Forms.Label();
      this.textBoxNum = new System.Windows.Forms.TextBox();
      this.buttonSum = new System.Windows.Forms.Button();
      this.labelResult = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // labelNbr
      // 
      this.labelNbr.AutoSize = true;
      this.labelNbr.Location = new System.Drawing.Point(12, 17);
      this.labelNbr.Name = "labelNbr";
      this.labelNbr.Size = new System.Drawing.Size(53, 13);
      this.labelNbr.TabIndex = 0;
      this.labelNbr.Text = "Nombre : ";
      // 
      // textBoxNum
      // 
      this.textBoxNum.Location = new System.Drawing.Point(71, 14);
      this.textBoxNum.Name = "textBoxNum";
      this.textBoxNum.Size = new System.Drawing.Size(100, 20);
      this.textBoxNum.TabIndex = 1;
      this.textBoxNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
      // 
      // buttonSum
      // 
      this.buttonSum.Location = new System.Drawing.Point(177, 12);
      this.buttonSum.Name = "buttonSum";
      this.buttonSum.Size = new System.Drawing.Size(75, 23);
      this.buttonSum.TabIndex = 2;
      this.buttonSum.Text = "Calculer";
      this.buttonSum.UseVisualStyleBackColor = true;
      this.buttonSum.Click += new System.EventHandler(this.buttonSum_Click);
      // 
      // labelResult
      // 
      this.labelResult.AutoSize = true;
      this.labelResult.Location = new System.Drawing.Point(12, 48);
      this.labelResult.Name = "labelResult";
      this.labelResult.Size = new System.Drawing.Size(0, 13);
      this.labelResult.TabIndex = 3;
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(267, 93);
      this.Controls.Add(this.labelResult);
      this.Controls.Add(this.buttonSum);
      this.Controls.Add(this.textBoxNum);
      this.Controls.Add(this.labelNbr);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "FormMain";
      this.Text = "Somme récursive";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelNbr;
    private System.Windows.Forms.TextBox textBoxNum;
    private System.Windows.Forms.Button buttonSum;
    private System.Windows.Forms.Label labelResult;
  }
}

