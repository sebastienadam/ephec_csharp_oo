namespace _039_radio_check {
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
      this.groupBoxRadio = new System.Windows.Forms.GroupBox();
      this.radioButtonSushi = new System.Windows.Forms.RadioButton();
      this.radioButtonSalad = new System.Windows.Forms.RadioButton();
      this.radioButtonBeef = new System.Windows.Forms.RadioButton();
      this.groupBoxCheck = new System.Windows.Forms.GroupBox();
      this.checkBoxDessert = new System.Windows.Forms.CheckBox();
      this.checkBoxCoffee = new System.Windows.Forms.CheckBox();
      this.labelChoice = new System.Windows.Forms.Label();
      this.textBoxChoice = new System.Windows.Forms.TextBox();
      this.textBoxLog = new System.Windows.Forms.TextBox();
      this.labelLog = new System.Windows.Forms.Label();
      this.groupBoxRadio.SuspendLayout();
      this.groupBoxCheck.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBoxRadio
      // 
      this.groupBoxRadio.Controls.Add(this.radioButtonSushi);
      this.groupBoxRadio.Controls.Add(this.radioButtonSalad);
      this.groupBoxRadio.Controls.Add(this.radioButtonBeef);
      this.groupBoxRadio.Location = new System.Drawing.Point(12, 12);
      this.groupBoxRadio.Name = "groupBoxRadio";
      this.groupBoxRadio.Size = new System.Drawing.Size(200, 96);
      this.groupBoxRadio.TabIndex = 0;
      this.groupBoxRadio.TabStop = false;
      this.groupBoxRadio.Text = "Que voulez-vous manger ?";
      // 
      // radioButtonSushi
      // 
      this.radioButtonSushi.AutoSize = true;
      this.radioButtonSushi.Location = new System.Drawing.Point(29, 65);
      this.radioButtonSushi.Name = "radioButtonSushi";
      this.radioButtonSushi.Size = new System.Drawing.Size(51, 17);
      this.radioButtonSushi.TabIndex = 2;
      this.radioButtonSushi.TabStop = true;
      this.radioButtonSushi.Text = "Sushi";
      this.radioButtonSushi.UseVisualStyleBackColor = true;
      this.radioButtonSushi.CheckedChanged += new System.EventHandler(this.control_CheckedChanged);
      // 
      // radioButtonSalad
      // 
      this.radioButtonSalad.AutoSize = true;
      this.radioButtonSalad.Location = new System.Drawing.Point(29, 42);
      this.radioButtonSalad.Name = "radioButtonSalad";
      this.radioButtonSalad.Size = new System.Drawing.Size(88, 17);
      this.radioButtonSalad.TabIndex = 1;
      this.radioButtonSalad.TabStop = true;
      this.radioButtonSalad.Text = "Salade César";
      this.radioButtonSalad.UseVisualStyleBackColor = true;
      this.radioButtonSalad.CheckedChanged += new System.EventHandler(this.control_CheckedChanged);
      // 
      // radioButtonBeef
      // 
      this.radioButtonBeef.AutoSize = true;
      this.radioButtonBeef.Location = new System.Drawing.Point(29, 19);
      this.radioButtonBeef.Name = "radioButtonBeef";
      this.radioButtonBeef.Size = new System.Drawing.Size(101, 17);
      this.radioButtonBeef.TabIndex = 0;
      this.radioButtonBeef.TabStop = true;
      this.radioButtonBeef.Text = "Boeuf en daube";
      this.radioButtonBeef.UseVisualStyleBackColor = true;
      this.radioButtonBeef.CheckedChanged += new System.EventHandler(this.control_CheckedChanged);
      // 
      // groupBoxCheck
      // 
      this.groupBoxCheck.Controls.Add(this.checkBoxDessert);
      this.groupBoxCheck.Controls.Add(this.checkBoxCoffee);
      this.groupBoxCheck.Location = new System.Drawing.Point(12, 114);
      this.groupBoxCheck.Name = "groupBoxCheck";
      this.groupBoxCheck.Size = new System.Drawing.Size(200, 75);
      this.groupBoxCheck.TabIndex = 1;
      this.groupBoxCheck.TabStop = false;
      this.groupBoxCheck.Text = "Douceurs";
      // 
      // checkBoxDessert
      // 
      this.checkBoxDessert.AutoSize = true;
      this.checkBoxDessert.Location = new System.Drawing.Point(29, 42);
      this.checkBoxDessert.Name = "checkBoxDessert";
      this.checkBoxDessert.Size = new System.Drawing.Size(62, 17);
      this.checkBoxDessert.TabIndex = 1;
      this.checkBoxDessert.Text = "Dessert";
      this.checkBoxDessert.UseVisualStyleBackColor = true;
      this.checkBoxDessert.CheckedChanged += new System.EventHandler(this.control_CheckedChanged);
      // 
      // checkBoxCoffee
      // 
      this.checkBoxCoffee.AutoSize = true;
      this.checkBoxCoffee.Location = new System.Drawing.Point(29, 19);
      this.checkBoxCoffee.Name = "checkBoxCoffee";
      this.checkBoxCoffee.Size = new System.Drawing.Size(48, 17);
      this.checkBoxCoffee.TabIndex = 0;
      this.checkBoxCoffee.Text = "Café";
      this.checkBoxCoffee.UseVisualStyleBackColor = true;
      this.checkBoxCoffee.CheckedChanged += new System.EventHandler(this.control_CheckedChanged);
      // 
      // labelChoice
      // 
      this.labelChoice.AutoSize = true;
      this.labelChoice.Location = new System.Drawing.Point(270, 20);
      this.labelChoice.Name = "labelChoice";
      this.labelChoice.Size = new System.Drawing.Size(66, 13);
      this.labelChoice.TabIndex = 3;
      this.labelChoice.Text = "Votre choix :";
      // 
      // textBoxChoice
      // 
      this.textBoxChoice.Location = new System.Drawing.Point(273, 36);
      this.textBoxChoice.Name = "textBoxChoice";
      this.textBoxChoice.ReadOnly = true;
      this.textBoxChoice.Size = new System.Drawing.Size(230, 20);
      this.textBoxChoice.TabIndex = 4;
      // 
      // textBoxLog
      // 
      this.textBoxLog.Location = new System.Drawing.Point(273, 99);
      this.textBoxLog.Multiline = true;
      this.textBoxLog.Name = "textBoxLog";
      this.textBoxLog.ReadOnly = true;
      this.textBoxLog.Size = new System.Drawing.Size(230, 185);
      this.textBoxLog.TabIndex = 5;
      // 
      // labelLog
      // 
      this.labelLog.AutoSize = true;
      this.labelLog.Location = new System.Drawing.Point(270, 83);
      this.labelLog.Name = "labelLog";
      this.labelLog.Size = new System.Drawing.Size(41, 13);
      this.labelLog.TabIndex = 6;
      this.labelLog.Text = "Journal";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(531, 307);
      this.Controls.Add(this.labelLog);
      this.Controls.Add(this.textBoxLog);
      this.Controls.Add(this.textBoxChoice);
      this.Controls.Add(this.labelChoice);
      this.Controls.Add(this.groupBoxCheck);
      this.Controls.Add(this.groupBoxRadio);
      this.Name = "Form1";
      this.Text = "Form1";
      this.groupBoxRadio.ResumeLayout(false);
      this.groupBoxRadio.PerformLayout();
      this.groupBoxCheck.ResumeLayout(false);
      this.groupBoxCheck.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBoxRadio;
    private System.Windows.Forms.RadioButton radioButtonSushi;
    private System.Windows.Forms.RadioButton radioButtonSalad;
    private System.Windows.Forms.RadioButton radioButtonBeef;
    private System.Windows.Forms.GroupBox groupBoxCheck;
    private System.Windows.Forms.CheckBox checkBoxDessert;
    private System.Windows.Forms.CheckBox checkBoxCoffee;
    private System.Windows.Forms.Label labelChoice;
    private System.Windows.Forms.TextBox textBoxChoice;
    private System.Windows.Forms.TextBox textBoxLog;
    private System.Windows.Forms.Label labelLog;
  }
}

