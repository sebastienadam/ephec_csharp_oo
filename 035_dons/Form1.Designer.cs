namespace _035_dons {
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
      this.comboBoxSelectValue = new System.Windows.Forms.ComboBox();
      this.labelSelectValue = new System.Windows.Forms.Label();
      this.labelCongrat = new System.Windows.Forms.Label();
      this.labelThanks = new System.Windows.Forms.Label();
      this.buttonValidate = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // comboBoxSelectValue
      // 
      this.comboBoxSelectValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBoxSelectValue.FormattingEnabled = true;
      this.comboBoxSelectValue.Items.AddRange(new object[] {
            "1",
            "10",
            "100",
            "1000"});
      this.comboBoxSelectValue.Location = new System.Drawing.Point(77, 12);
      this.comboBoxSelectValue.Name = "comboBoxSelectValue";
      this.comboBoxSelectValue.Size = new System.Drawing.Size(121, 21);
      this.comboBoxSelectValue.TabIndex = 0;
      this.comboBoxSelectValue.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectValue_SelectedIndexChanged);
      // 
      // labelSelectValue
      // 
      this.labelSelectValue.AutoSize = true;
      this.labelSelectValue.Location = new System.Drawing.Point(12, 15);
      this.labelSelectValue.Name = "labelSelectValue";
      this.labelSelectValue.Size = new System.Drawing.Size(52, 13);
      this.labelSelectValue.TabIndex = 1;
      this.labelSelectValue.Text = "Montant :";
      // 
      // labelCongrat
      // 
      this.labelCongrat.AutoSize = true;
      this.labelCongrat.Location = new System.Drawing.Point(12, 45);
      this.labelCongrat.Name = "labelCongrat";
      this.labelCongrat.Size = new System.Drawing.Size(66, 13);
      this.labelCongrat.TabIndex = 2;
      this.labelCongrat.Text = "labelCongrat";
      // 
      // labelThanks
      // 
      this.labelThanks.AutoSize = true;
      this.labelThanks.Location = new System.Drawing.Point(12, 104);
      this.labelThanks.Name = "labelThanks";
      this.labelThanks.Size = new System.Drawing.Size(105, 13);
      this.labelThanks.TabIndex = 3;
      this.labelThanks.Text = "Merci pour votre don";
      this.labelThanks.Visible = false;
      // 
      // buttonValidate
      // 
      this.buttonValidate.Location = new System.Drawing.Point(63, 68);
      this.buttonValidate.Name = "buttonValidate";
      this.buttonValidate.Size = new System.Drawing.Size(75, 23);
      this.buttonValidate.TabIndex = 4;
      this.buttonValidate.Text = "Valider";
      this.buttonValidate.UseVisualStyleBackColor = true;
      this.buttonValidate.Click += new System.EventHandler(this.buttonValidate_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(210, 130);
      this.Controls.Add(this.buttonValidate);
      this.Controls.Add(this.labelThanks);
      this.Controls.Add(this.labelCongrat);
      this.Controls.Add(this.labelSelectValue);
      this.Controls.Add(this.comboBoxSelectValue);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox comboBoxSelectValue;
    private System.Windows.Forms.Label labelSelectValue;
    private System.Windows.Forms.Label labelCongrat;
    private System.Windows.Forms.Label labelThanks;
    private System.Windows.Forms.Button buttonValidate;
  }
}

