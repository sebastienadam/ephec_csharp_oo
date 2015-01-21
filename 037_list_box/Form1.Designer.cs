namespace _037_list_box {
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
      this.label1 = new System.Windows.Forms.Label();
      this.labelList2 = new System.Windows.Forms.Label();
      this.labelList1 = new System.Windows.Forms.Label();
      this.buttonAdd = new System.Windows.Forms.Button();
      this.buttonMoveL2L1 = new System.Windows.Forms.Button();
      this.buttonMoveL1L2 = new System.Windows.Forms.Button();
      this.buttonClearList1 = new System.Windows.Forms.Button();
      this.buttonClearList2 = new System.Windows.Forms.Button();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.listBox2 = new System.Windows.Forms.ListBox();
      this.SuspendLayout();
      // 
      // textBoxInput
      // 
      this.textBoxInput.Location = new System.Drawing.Point(212, 25);
      this.textBoxInput.Name = "textBoxInput";
      this.textBoxInput.Size = new System.Drawing.Size(176, 20);
      this.textBoxInput.TabIndex = 0;
      this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(28, 28);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(178, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Tapez un texte à ajouter à la liste 1 :";
      // 
      // labelList2
      // 
      this.labelList2.AutoSize = true;
      this.labelList2.Location = new System.Drawing.Point(347, 77);
      this.labelList2.Name = "labelList2";
      this.labelList2.Size = new System.Drawing.Size(38, 13);
      this.labelList2.TabIndex = 2;
      this.labelList2.Text = "Liste 2";
      // 
      // labelList1
      // 
      this.labelList1.AutoSize = true;
      this.labelList1.Location = new System.Drawing.Point(28, 77);
      this.labelList1.Name = "labelList1";
      this.labelList1.Size = new System.Drawing.Size(38, 13);
      this.labelList1.TabIndex = 3;
      this.labelList1.Text = "Liste 1";
      // 
      // buttonAdd
      // 
      this.buttonAdd.Enabled = false;
      this.buttonAdd.Location = new System.Drawing.Point(394, 23);
      this.buttonAdd.Name = "buttonAdd";
      this.buttonAdd.Size = new System.Drawing.Size(75, 23);
      this.buttonAdd.TabIndex = 4;
      this.buttonAdd.Text = "Ajouter";
      this.buttonAdd.UseVisualStyleBackColor = true;
      this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
      // 
      // buttonMoveL2L1
      // 
      this.buttonMoveL2L1.Enabled = false;
      this.buttonMoveL2L1.Location = new System.Drawing.Point(239, 152);
      this.buttonMoveL2L1.Name = "buttonMoveL2L1";
      this.buttonMoveL2L1.Size = new System.Drawing.Size(75, 23);
      this.buttonMoveL2L1.TabIndex = 5;
      this.buttonMoveL2L1.Text = "<--";
      this.buttonMoveL2L1.UseVisualStyleBackColor = true;
      this.buttonMoveL2L1.Click += new System.EventHandler(this.buttonMove_Click);
      // 
      // buttonMoveL1L2
      // 
      this.buttonMoveL1L2.Enabled = false;
      this.buttonMoveL1L2.Location = new System.Drawing.Point(239, 114);
      this.buttonMoveL1L2.Name = "buttonMoveL1L2";
      this.buttonMoveL1L2.Size = new System.Drawing.Size(75, 23);
      this.buttonMoveL1L2.TabIndex = 6;
      this.buttonMoveL1L2.Text = "-->";
      this.buttonMoveL1L2.UseVisualStyleBackColor = true;
      this.buttonMoveL1L2.Click += new System.EventHandler(this.buttonMove_Click);
      // 
      // buttonClearList1
      // 
      this.buttonClearList1.Enabled = false;
      this.buttonClearList1.Location = new System.Drawing.Point(81, 319);
      this.buttonClearList1.Name = "buttonClearList1";
      this.buttonClearList1.Size = new System.Drawing.Size(75, 23);
      this.buttonClearList1.TabIndex = 7;
      this.buttonClearList1.Text = "Effacer";
      this.buttonClearList1.UseVisualStyleBackColor = true;
      this.buttonClearList1.Click += new System.EventHandler(this.buttonClearList_Click);
      // 
      // buttonClearList2
      // 
      this.buttonClearList2.Enabled = false;
      this.buttonClearList2.Location = new System.Drawing.Point(401, 319);
      this.buttonClearList2.Name = "buttonClearList2";
      this.buttonClearList2.Size = new System.Drawing.Size(75, 23);
      this.buttonClearList2.TabIndex = 8;
      this.buttonClearList2.Text = "Effacer";
      this.buttonClearList2.UseVisualStyleBackColor = true;
      this.buttonClearList2.Click += new System.EventHandler(this.buttonClearList_Click);
      // 
      // listBox1
      // 
      this.listBox1.FormattingEnabled = true;
      this.listBox1.Location = new System.Drawing.Point(30, 93);
      this.listBox1.Name = "listBox1";
      this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
      this.listBox1.Size = new System.Drawing.Size(176, 199);
      this.listBox1.TabIndex = 9;
      this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
      // 
      // listBox2
      // 
      this.listBox2.FormattingEnabled = true;
      this.listBox2.Location = new System.Drawing.Point(350, 93);
      this.listBox2.Name = "listBox2";
      this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
      this.listBox2.Size = new System.Drawing.Size(176, 199);
      this.listBox2.TabIndex = 10;
      this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(570, 373);
      this.Controls.Add(this.listBox2);
      this.Controls.Add(this.listBox1);
      this.Controls.Add(this.buttonClearList2);
      this.Controls.Add(this.buttonClearList1);
      this.Controls.Add(this.buttonMoveL1L2);
      this.Controls.Add(this.buttonMoveL2L1);
      this.Controls.Add(this.buttonAdd);
      this.Controls.Add(this.labelList1);
      this.Controls.Add(this.labelList2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBoxInput);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBoxInput;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label labelList2;
    private System.Windows.Forms.Label labelList1;
    private System.Windows.Forms.Button buttonAdd;
    private System.Windows.Forms.Button buttonMoveL2L1;
    private System.Windows.Forms.Button buttonMoveL1L2;
    private System.Windows.Forms.Button buttonClearList1;
    private System.Windows.Forms.Button buttonClearList2;
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.ListBox listBox2;
  }
}

