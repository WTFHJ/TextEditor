﻿using System;
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
    /// Interaction logic for CustomMenu.xaml
    /// </summary>
    public partial class CustomMenu : UserControl
    {
        public CustomMenu()
        {
            InitializeComponent();
        }

        private void MenuItem_Clicked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Cheese");
        }
    }
}
