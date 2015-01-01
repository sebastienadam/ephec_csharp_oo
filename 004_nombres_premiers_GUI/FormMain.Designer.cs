namespace _004_nombres_premiers_GUI {
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
      this.labelTestNum = new System.Windows.Forms.Label();
      this.textBoxTestNum = new System.Windows.Forms.TextBox();
      this.labelResult = new System.Windows.Forms.Label();
      this.buttonTestNum = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // labelTestNum
      // 
      this.labelTestNum.AutoSize = true;
      this.labelTestNum.Font = new System.Drawing.Font("DejaVu Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelTestNum.Location = new System.Drawing.Point(12, 20);
      this.labelTestNum.Name = "labelTestNum";
      this.labelTestNum.Size = new System.Drawing.Size(197, 24);
      this.labelTestNum.TabIndex = 0;
      this.labelTestNum.Text = "Nombre à tester :";
      // 
      // textBoxTestNum
      // 
      this.textBoxTestNum.Font = new System.Drawing.Font("DejaVu Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBoxTestNum.Location = new System.Drawing.Point(215, 17);
      this.textBoxTestNum.Name = "textBoxTestNum";
      this.textBoxTestNum.Size = new System.Drawing.Size(109, 32);
      this.textBoxTestNum.TabIndex = 1;
      this.textBoxTestNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTestNum_KeyPress);
      // 
      // labelResult
      // 
      this.labelResult.Font = new System.Drawing.Font("DejaVu Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelResult.Location = new System.Drawing.Point(12, 66);
      this.labelResult.Name = "labelResult";
      this.labelResult.Size = new System.Drawing.Size(437, 47);
      this.labelResult.TabIndex = 2;
      this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // buttonTestNum
      // 
      this.buttonTestNum.Font = new System.Drawing.Font("DejaVu Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonTestNum.Location = new System.Drawing.Point(330, 17);
      this.buttonTestNum.Name = "buttonTestNum";
      this.buttonTestNum.Size = new System.Drawing.Size(119, 32);
      this.buttonTestNum.TabIndex = 3;
      this.buttonTestNum.Text = "Tester";
      this.buttonTestNum.UseVisualStyleBackColor = true;
      this.buttonTestNum.Click += new System.EventHandler(this.buttonTestNum_Click);
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(472, 122);
      this.Controls.Add(this.buttonTestNum);
      this.Controls.Add(this.labelResult);
      this.Controls.Add(this.textBoxTestNum);
      this.Controls.Add(this.labelTestNum);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "FormMain";
      this.Text = "Nombres premiers";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelTestNum;
    private System.Windows.Forms.TextBox textBoxTestNum;
    private System.Windows.Forms.Label labelResult;
    private System.Windows.Forms.Button buttonTestNum;
  }
}

