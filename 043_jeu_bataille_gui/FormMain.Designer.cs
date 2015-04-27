namespace _043_jeu_bataille_gui {
  partial class FormMain {
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
      this.PanelButtons = new System.Windows.Forms.Panel();
      this.buttonStartGame = new System.Windows.Forms.Button();
      this.buttonNewPlayer = new System.Windows.Forms.Button();
      this.buttonQuit = new System.Windows.Forms.Button();
      this.PanelPlayers = new System.Windows.Forms.FlowLayoutPanel();
      this.PanelButtons.SuspendLayout();
      this.SuspendLayout();
      // 
      // PanelButtons
      // 
      this.PanelButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.PanelButtons.Controls.Add(this.buttonStartGame);
      this.PanelButtons.Controls.Add(this.buttonNewPlayer);
      this.PanelButtons.Controls.Add(this.buttonQuit);
      this.PanelButtons.Dock = System.Windows.Forms.DockStyle.Right;
      this.PanelButtons.Location = new System.Drawing.Point(761, 0);
      this.PanelButtons.Name = "PanelButtons";
      this.PanelButtons.Size = new System.Drawing.Size(175, 492);
      this.PanelButtons.TabIndex = 0;
      // 
      // buttonStartGame
      // 
      this.buttonStartGame.AutoSize = true;
      this.buttonStartGame.Dock = System.Windows.Forms.DockStyle.Top;
      this.buttonStartGame.Enabled = false;
      this.buttonStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonStartGame.Location = new System.Drawing.Point(0, 30);
      this.buttonStartGame.Name = "buttonStartGame";
      this.buttonStartGame.Size = new System.Drawing.Size(173, 30);
      this.buttonStartGame.TabIndex = 4;
      this.buttonStartGame.Text = "Démarrer";
      this.buttonStartGame.UseVisualStyleBackColor = true;
      this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
      // 
      // buttonNewPlayer
      // 
      this.buttonNewPlayer.AutoSize = true;
      this.buttonNewPlayer.Dock = System.Windows.Forms.DockStyle.Top;
      this.buttonNewPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonNewPlayer.Location = new System.Drawing.Point(0, 0);
      this.buttonNewPlayer.Name = "buttonNewPlayer";
      this.buttonNewPlayer.Size = new System.Drawing.Size(173, 30);
      this.buttonNewPlayer.TabIndex = 3;
      this.buttonNewPlayer.Text = "Nouveau joueur";
      this.buttonNewPlayer.UseVisualStyleBackColor = true;
      this.buttonNewPlayer.Click += new System.EventHandler(this.buttonNewPlayer_Click);
      // 
      // buttonQuit
      // 
      this.buttonQuit.AutoSize = true;
      this.buttonQuit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.buttonQuit.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.buttonQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonQuit.Location = new System.Drawing.Point(0, 460);
      this.buttonQuit.Margin = new System.Windows.Forms.Padding(8);
      this.buttonQuit.Name = "buttonQuit";
      this.buttonQuit.Size = new System.Drawing.Size(173, 30);
      this.buttonQuit.TabIndex = 2;
      this.buttonQuit.Text = "Quitter";
      this.buttonQuit.UseVisualStyleBackColor = true;
      this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
      // 
      // PanelPlayers
      // 
      this.PanelPlayers.AutoSize = true;
      this.PanelPlayers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.PanelPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
      this.PanelPlayers.Location = new System.Drawing.Point(0, 0);
      this.PanelPlayers.Name = "PanelPlayers";
      this.PanelPlayers.Size = new System.Drawing.Size(761, 492);
      this.PanelPlayers.TabIndex = 1;
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(936, 492);
      this.Controls.Add(this.PanelPlayers);
      this.Controls.Add(this.PanelButtons);
      this.Name = "FormMain";
      this.Text = "Jeu de bataille";
      this.PanelButtons.ResumeLayout(false);
      this.PanelButtons.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel PanelButtons;
    private System.Windows.Forms.FlowLayoutPanel PanelPlayers;
    private System.Windows.Forms.Button buttonStartGame;
    private System.Windows.Forms.Button buttonNewPlayer;
    private System.Windows.Forms.Button buttonQuit;
  }
}

