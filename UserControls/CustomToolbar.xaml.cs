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

namespace TextEditor.UserControls
{
    /// <summary>
    /// Interaction logic for CustomToolbar.xaml
    /// </summary>
    public partial class CustomToolbar : UserControl
    {
        public CustomToolbar()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 8; i < 48; i+=2)
            {
                fontSize.Items.Add(i);
            }
        }
    }
}
