using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsHost_Test
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      this.InitializeComponent();

      var lvcContents = new List<string>();
      lvcContents.Add("rFactor 2");
      lvcContents.Add("RaceRoom");
      lvcContents.Add("iRacing");
      lvcContents.Add("rFactor");

      this.listViewControl.ListEntries = lvcContents;
      this.listViewControl.SelectedIndex = 1;

      System.Windows.Style style = new System.Windows.Style();
      style.TargetType = typeof(WpfControls.ListViewControl);
      style.Setters.Add(new System.Windows.Setter(WpfControls.ListViewControl.BackgroundProperty, System.Windows.Media.Brushes.Pink));
      style.Setters.Add(new System.Windows.Setter(WpfControls.ListViewControl.ForegroundProperty, System.Windows.Media.Brushes.Red));
      this.listViewControl.Style = style;

      //this.listViewControlHost.OnPropertyChanged("Style", style);


      //this.listViewControl.Background = System.Windows.Media.Brushes.Red;
      //this.listViewControl.SetValue(WpfControls.ListViewControl.BackgroundProperty, System.Windows.Media.Brushes.Red);
      //InvalidateProperty(WpfControls.ListViewControl.BackgroundProperty);
      //     this.listViewControl.Foreground = System.Windows.Media.Brushes.Green;
      //this.listViewControlHost.BackColor = Color.Indigo;
      //this.listViewControlHost.ForeColor = Color.Honeydew;

    }
  }
}
