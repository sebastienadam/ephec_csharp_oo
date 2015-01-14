using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _036_search_box {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    private void buttonConfirm_Click(object sender, EventArgs e) {
      comboBoxSearch.Items.Add(comboBoxSearch.Text);
    }
  }
}
