namespace _034_textbox_multiline {
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
      this.labelInput = new System.Windows.Forms.Label();
      this.labelControl = new System.Windows.Forms.Label();
      this.labelCloneInput = new System.Windows.Forms.Label();
      this.textBoxInput = new System.Windows.Forms.TextBox();
      this.textBoxMultiLine = new System.Windows.Forms.TextBox();
      this.buttonAdd = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // labelInput
      // 
      this.labelInput.AutoSize = true;
      this.labelInput.Location = new System.Drawing.Point(18, 15);
      this.labelInput.Name = "labelInput";
      this.labelInput.Size = new System.Drawing.Size(44, 13);
      this.labelInput.TabIndex = 7;
      this.labelInput.Text = "Entrée :";
      // 
      // labelControl
      // 
      this.labelControl.AutoSize = true;
      this.labelControl.Location = new System.Drawing.Point(18, 66);
      this.labelControl.Name = "labelControl";
      this.labelControl.Size = new System.Drawing.Size(52, 13);
      this.labelControl.TabIndex = 6;
      this.labelControl.Text = "Contrôle :";
      // 
      // labelCloneInput
      // 
      this.labelCloneInput.AutoSize = true;
      this.labelCloneInput.Location = new System.Drawing.Point(76, 66);
      this.labelCloneInput.Name = "labelCloneInput";
      this.labelCloneInput.Size = new System.Drawing.Size(58, 13);
      this.labelCloneInput.TabIndex = 5;
      this.labelCloneInput.Text = "CloneInput";
      this.labelCloneInput.Click += new System.EventHandler(this.labelCloneInput_Click);
      // 
      // textBoxInput
      // 
      this.textBoxInput.Location = new System.Drawing.Point(79, 12);
      this.textBoxInput.Name = "textBoxInput";
      this.textBoxInput.Size = new System.Drawing.Size(181, 20);
      this.textBoxInput.TabIndex = 4;
      this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
      // 
      // textBoxMultiLine
      // 
      this.textBoxMultiLine.Location = new System.Drawing.Point(21, 114);
      this.textBoxMultiLine.Multiline = true;
      this.textBoxMultiLine.Name = "textBoxMultiLine";
      this.textBoxMultiLine.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.textBoxMultiLine.Size = new System.Drawing.Size(239, 121);
      this.textBoxMultiLine.TabIndex = 8;
      // 
      // buttonAdd
      // 
      this.buttonAdd.Location = new System.Drawing.Point(185, 61);
      this.buttonAdd.Name = "buttonAdd";
      this.buttonAdd.Size = new System.Drawing.Size(75, 23);
      this.buttonAdd.TabIndex = 9;
      this.buttonAdd.Text = "Ajouter";
      this.buttonAdd.UseVisualStyleBackColor = true;
      this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 261);
      this.Controls.Add(this.buttonAdd);
      this.Controls.Add(this.textBoxMultiLine);
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

    private System.Windows.Forms.Label labelInput;
    private System.Windows.Forms.Label labelControl;
    private System.Windows.Forms.Label labelCloneInput;
    private System.Windows.Forms.TextBox textBoxInput;
    private System.Windows.Forms.TextBox textBoxMultiLine;
    private System.Windows.Forms.Button buttonAdd;
  }
}

