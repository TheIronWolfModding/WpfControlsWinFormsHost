using System;
using System.Collections.Generic;
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

namespace WpfControls
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class ListViewControl : UserControl
    {
        public List<string> ListEntries { get; set; }

        public ListViewControl()
        {
            this.InitializeComponent();
            this.DataContext = this;

            this.SelectedIndex = 0;
        }

        public int SelectedIndex
        {
            get
            {
                return this.listView.SelectedIndex;
            }

            set
            {
                this.listView.SelectedIndex = value;
            }
        }
    }
}
