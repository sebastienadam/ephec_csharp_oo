using System;
using System.Collections.Generic;
using System.Windows.Controls.Primitives;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _041_radio_check_wpf {
  /// <summary>
  /// Logique d'interaction pour MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window {
    public MainWindow() {
      InitializeComponent();
    }

    private void setChoice() {
      string menu = "";
      if (groupBoxRadio != null) {
        foreach (RadioButton item in groupBoxRadio.Children) {
          if (item.IsChecked == true) {
            menu = item.Content.ToString();
            break;
          }
        }
      }
      if (groupBoxCheck != null) {
        foreach (CheckBox item in groupBoxCheck.Children) {
          if (item.IsChecked == true) {
            menu += ", " + item.Content.ToString();
          }
        }
      }
      textBoxChoice.Text = menu;
    }

    private void control_CheckedChanged(object sender, RoutedEventArgs e) {
      ToggleButton toggleButtonSender = (ToggleButton)sender;
      string log = toggleButtonSender.Content.ToString();
      if (toggleButtonSender.IsChecked == true) {
        log += " sélectionné";
      } else {
        log += " désélectionné";
      }
      textBoxLog.AppendText(log + Environment.NewLine);
      setChoice();
    }
  }
}
