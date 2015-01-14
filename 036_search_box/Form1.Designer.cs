namespace _036_search_box {
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
      this.buttonConfirm = new System.Windows.Forms.Button();
      this.comboBoxSearch = new System.Windows.Forms.ComboBox();
      this.SuspendLayout();
      // 
      // buttonConfirm
      // 
      this.buttonConfirm.Location = new System.Drawing.Point(222, 59);
      this.buttonConfirm.Name = "buttonConfirm";
      this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
      this.buttonConfirm.TabIndex = 1;
      this.buttonConfirm.Text = "Confirmer";
      this.buttonConfirm.UseVisualStyleBackColor = true;
      this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
      // 
      // comboBoxSearch
      // 
      this.comboBoxSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
      this.comboBoxSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.comboBoxSearch.FormattingEnabled = true;
      this.comboBoxSearch.Location = new System.Drawing.Point(12, 12);
      this.comboBoxSearch.Name = "comboBoxSearch";
      this.comboBoxSearch.Size = new System.Drawing.Size(494, 21);
      this.comboBoxSearch.Sorted = true;
      this.comboBoxSearch.TabIndex = 2;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(518, 94);
      this.Controls.Add(this.comboBoxSearch);
      this.Controls.Add(this.buttonConfirm);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button buttonConfirm;
    private System.Windows.Forms.ComboBox comboBoxSearch;
  }
}

