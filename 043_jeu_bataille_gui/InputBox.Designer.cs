namespace _043_jeu_bataille_gui {
  partial class InputBox {
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.panelButtons = new System.Windows.Forms.Panel();
      this.buttonCancel = new System.Windows.Forms.Button();
      this.buttonOK = new System.Windows.Forms.Button();
      this.labelPrompt = new System.Windows.Forms.Label();
      this.textBoxInput = new System.Windows.Forms.TextBox();
      this.panelButtons.SuspendLayout();
      this.SuspendLayout();
      // 
      // panelButtons
      // 
      this.panelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panelButtons.AutoSize = true;
      this.panelButtons.Controls.Add(this.buttonCancel);
      this.panelButtons.Controls.Add(this.buttonOK);
      this.panelButtons.Location = new System.Drawing.Point(12, 87);
      this.panelButtons.Name = "panelButtons";
      this.panelButtons.Size = new System.Drawing.Size(436, 42);
      this.panelButtons.TabIndex = 0;
      // 
      // buttonCancel
      // 
      this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.buttonCancel.Location = new System.Drawing.Point(221, 10);
      this.buttonCancel.Name = "buttonCancel";
      this.buttonCancel.Size = new System.Drawing.Size(75, 23);
      this.buttonCancel.TabIndex = 2;
      this.buttonCancel.Text = "Annuler";
      this.buttonCancel.UseVisualStyleBackColor = true;
      // 
      // buttonOK
      // 
      this.buttonOK.Location = new System.Drawing.Point(140, 10);
      this.buttonOK.Name = "buttonOK";
      this.buttonOK.Size = new System.Drawing.Size(75, 23);
      this.buttonOK.TabIndex = 1;
      this.buttonOK.Text = "OK";
      this.buttonOK.UseVisualStyleBackColor = true;
      this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
      // 
      // labelPrompt
      // 
      this.labelPrompt.AutoSize = true;
      this.labelPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelPrompt.Location = new System.Drawing.Point(9, 9);
      this.labelPrompt.Name = "labelPrompt";
      this.labelPrompt.Size = new System.Drawing.Size(118, 20);
      this.labelPrompt.TabIndex = 1;
      this.labelPrompt.Text = "Vorte réponse :";
      // 
      // textBoxInput
      // 
      this.textBoxInput.AcceptsReturn = true;
      this.textBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBoxInput.Location = new System.Drawing.Point(12, 47);
      this.textBoxInput.Name = "textBoxInput";
      this.textBoxInput.Size = new System.Drawing.Size(436, 26);
      this.textBoxInput.TabIndex = 0;
      // 
      // InputBox
      // 
      this.AcceptButton = this.buttonOK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.buttonCancel;
      this.ClientSize = new System.Drawing.Size(460, 141);
      this.Controls.Add(this.textBoxInput);
      this.Controls.Add(this.labelPrompt);
      this.Controls.Add(this.panelButtons);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "InputBox";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "InputBox";
      this.panelButtons.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel panelButtons;
    private System.Windows.Forms.Button buttonCancel;
    private System.Windows.Forms.Button buttonOK;
    private System.Windows.Forms.Label labelPrompt;
    private System.Windows.Forms.TextBox textBoxInput;
  }
}