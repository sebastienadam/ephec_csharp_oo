namespace _033_evenment_textchanged {
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
      this.textBoxInput = new System.Windows.Forms.TextBox();
      this.labelCloneInput = new System.Windows.Forms.Label();
      this.labelControl = new System.Windows.Forms.Label();
      this.labelInput = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // textBoxInput
      // 
      this.textBoxInput.Location = new System.Drawing.Point(78, 50);
      this.textBoxInput.Name = "textBoxInput";
      this.textBoxInput.Size = new System.Drawing.Size(181, 20);
      this.textBoxInput.TabIndex = 0;
      this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
      // 
      // labelCloneInput
      // 
      this.labelCloneInput.AutoSize = true;
      this.labelCloneInput.Location = new System.Drawing.Point(75, 104);
      this.labelCloneInput.Name = "labelCloneInput";
      this.labelCloneInput.Size = new System.Drawing.Size(58, 13);
      this.labelCloneInput.TabIndex = 1;
      this.labelCloneInput.Text = "CloneInput";
      this.labelCloneInput.Click += new System.EventHandler(this.labelCloneInput_Click);
      // 
      // labelControl
      // 
      this.labelControl.AutoSize = true;
      this.labelControl.Location = new System.Drawing.Point(17, 104);
      this.labelControl.Name = "labelControl";
      this.labelControl.Size = new System.Drawing.Size(52, 13);
      this.labelControl.TabIndex = 2;
      this.labelControl.Text = "Contrôle :";
      // 
      // labelInput
      // 
      this.labelInput.AutoSize = true;
      this.labelInput.Location = new System.Drawing.Point(17, 53);
      this.labelInput.Name = "labelInput";
      this.labelInput.Size = new System.Drawing.Size(44, 13);
      this.labelInput.TabIndex = 3;
      this.labelInput.Text = "Entrée :";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 153);
      this.Controls.Add(this.labelInput);
      this.Controls.Add(this.labelControl);
      this.Controls.Add(this.labelCloneInput);
      this.Controls.Add(this.textBoxInput);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBoxInput;
    private System.Windows.Forms.Label labelCloneInput;
    private System.Windows.Forms.Label labelControl;
    private System.Windows.Forms.Label labelInput;
  }
}

