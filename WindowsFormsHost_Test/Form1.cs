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

      // Apply color scheme to the ListView.
      // Important: get to the ListView from the ListViewControl user control.
      var style = new System.Windows.Style();
      style.TargetType = typeof(System.Windows.Controls.ListView);
      style.Setters.Add(new System.Windows.Setter(WpfControls.ListViewControl.BackgroundProperty, System.Windows.Media.Brushes.Pink));
      style.Setters.Add(new System.Windows.Setter(WpfControls.ListViewControl.ForegroundProperty, System.Windows.Media.Brushes.Red));

      var listView = listViewControl.FindName("listView") as System.Windows.Controls.ListView;

      if (listView != null)
        listView.Style = style;

      // TODO: change brushes.  Needs to be dynamic resource.

      /*var st = listViewControl.Resources["CustomScrollBar"] as System.Windows.Style;
      st.TargetType = typeof(System.Windows.Controls.Primitives.ScrollBar);
      
      if (listView != null)
        listView.Style = st;*/

    }
  }
}
