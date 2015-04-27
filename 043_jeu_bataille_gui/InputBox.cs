using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _043_jeu_bataille_gui {
  public partial class InputBox : Form {
    private string _reply;

    public string Reply { get { return _reply; } protected set { _reply = value; } }

    public InputBox(string Title) : this(Title, "Votre réponse") { }

    public InputBox(string Title, string Caption) : this(Title, Caption, "") { }

    public InputBox(string Title, string Caption, string Default) {
      InitializeComponent();
      Text = Title;
      labelPrompt.Text = Caption + " :";
      textBoxInput.Text = Default;
      Reply = "";
    }

    private void buttonOK_Click(object sender, EventArgs e) {
      if(textBoxInput.Text.Equals("")) {
        MessageBox.Show("Vous devez donner un nom au nouveau joueur", "Nouveau joueur", MessageBoxButtons.OK);
      } else {
        Reply = textBoxInput.Text;
        DialogResult = DialogResult.OK;
      }
    }
  }
}
