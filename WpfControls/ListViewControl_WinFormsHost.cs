using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms.Integration;
using System.Windows.Forms;
using System.ComponentModel;
using System.Windows.Forms.Design;
using System.Windows;
using System.ComponentModel.Design.Serialization;
using System.Windows.Markup;

namespace WpfControls
{
  [Designer("System.Windows.Forms.Design.ControlDesigner, System.Design")]
  [DesignerSerializer("System.ComponentModel.Design.Serialization.TypeCodeDomSerializer , System.Design", "System.ComponentModel.Design.Serialization.CodeDomSerializer, System.Design")]
  public class ListViewControl_WinformsHost : System.Windows.Forms.Integration.ElementHost
  {
    protected ListViewControl wpfListViewControl = new ListViewControl();

    public ListViewControl_WinformsHost()
    {
      base.Child = this.wpfListViewControl;
    }

    public int SelectedIndex
    {
      get
      {
        return this.wpfListViewControl.SelectedIndex;
      }

      set
      {
        this.wpfListViewControl.SelectedIndex = value;
      }
    }

    public List<string> ListEntries
    {
      get
      {
        return this.wpfListViewControl.ListEntries;
      }

      set
      {
        this.wpfListViewControl.ListEntries = value;
      }
    }
  }
}
