namespace _043_jeu_bataille_gui {
  partial class PlayerForm {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if(disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.labelName = new System.Windows.Forms.Label();
      this.labelTable = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // labelName
      // 
      this.labelName.AutoSize = true;
      this.labelName.Dock = System.Windows.Forms.DockStyle.Top;
      this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelName.Location = new System.Drawing.Point(0, 0);
      this.labelName.Name = "labelName";
      this.labelName.Size = new System.Drawing.Size(105, 20);
      this.labelName.TabIndex = 0;
      this.labelName.Text = "Nom Joueur";
      // 
      // labelTable
      // 
      this.labelTable.AutoSize = true;
      this.labelTable.Location = new System.Drawing.Point(8, 25);
      this.labelTable.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
      this.labelTable.Name = "labelTable";
      this.labelTable.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
      this.labelTable.Size = new System.Drawing.Size(102, 23);
      this.labelTable.TabIndex = 1;
      this.labelTable.Text = "Cartes déposées";
      this.labelTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // PlayerForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.labelTable);
      this.Controls.Add(this.labelName);
      this.Name = "PlayerForm";
      this.Size = new System.Drawing.Size(202, 205);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelName;
    private System.Windows.Forms.Label labelTable;
  }
}
