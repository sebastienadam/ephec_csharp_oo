using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _037_list_box {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    private void textBoxInput_TextChanged(object sender, EventArgs e) {
      buttonAdd.Enabled = !textBoxInput.Text.Equals("");
    }

    private void buttonAdd_Click(object sender, EventArgs e) {
      listBox1.Items.Add(textBoxInput.Text);
      buttonClearList1.Enabled = true;
      textBoxInput.Text = "";
      textBoxInput.Focus();
    }

    private void buttonClearList_Click(object sender, EventArgs e) {
      ListBox targetList;
      Button buttonSender = (Button)sender;
      Button buttonMove;
      if (buttonSender == buttonClearList1) {
        targetList = listBox1;
        buttonMove = buttonMoveL1L2;
      } else {
        targetList = listBox2;
        buttonMove = buttonMoveL2L1;
      }
      targetList.Items.Clear();
      buttonSender.Enabled = false;
      buttonMove.Enabled = false;
    }

    private void listBox_SelectedIndexChanged(object sender, EventArgs e) {
      ListBox senderListBox = (ListBox)sender;
      Button buttonMove;
      int NbSelected = senderListBox.SelectedItems.Count;
      if (senderListBox == listBox1) {
        buttonMove = buttonMoveL1L2;
      } else {
        buttonMove = buttonMoveL2L1;
      }
      buttonMove.Enabled = NbSelected > 0;
    }

    private void buttonMove_Click(object sender, EventArgs e) {
      ListBox listBoxFrom;
      ListBox listBoxTo;
      Button buttonSender = (Button)sender;
      if (buttonSender == buttonMoveL1L2) {
        listBoxFrom = listBox1;
        listBoxTo = listBox2;
      } else {
        listBoxFrom = listBox2;
        listBoxTo = listBox1;
      }
      foreach (var item in listBoxFrom.SelectedItems) {
        listBoxTo.Items.Add(item);
      }
      for (int i = listBoxFrom.Items.Count - 1; i >= 0; i--) {
        if (listBoxFrom.SelectedIndices.Contains(i)) {
          listBoxFrom.Items.RemoveAt(i);
        }
      }
      buttonClearList1.Enabled = listBox1.Items.Count > 0;
      buttonClearList2.Enabled = listBox2.Items.Count > 0;
    }

  }
}
