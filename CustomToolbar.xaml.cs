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
            for (double i = 8; i < 48; i+=2)
            {
                fontSize.Items.Add(i);
            }
        }

        //public void SynchronizeWith(TextSelection selection)
        //{
        //    object size = selection.GetPropertyValue(TextBlock.FontSizeProperty);
        //    if (size != DependencyProperty.UnsetValue)
        //    {
        //        fontSize.SelectedValue = (double)size;
        //    }

        //    object weight = selection.GetPropertyValue(TextBlock.FontWeightProperty);
        //    if (weight != DependencyProperty.UnsetValue)
        //    {
        //        boldBtn.IsChecked = ((FontWeight)weight== FontWeights.Bold);
        //    }
        //}

        private void Synchronize<T>(TextSelection selection, DependencyProperty property, Action<T> methodToCall)
        {
            object value = selection.GetPropertyValue(property);
            if (value != DependencyProperty.UnsetValue) methodToCall((T)value);
        }

        private void SetFontSize(double size)
        {
            fontSize.SelectedValue=size;
        }
        private void setFontWeight(FontWeight weight)
        {
            boldBtn.IsChecked=weight== FontWeights.Bold;
        }

        private void setFontStyle(FontStyle style)
        {
            italicBtn.IsChecked = style == FontStyles.Italic;
        }

        private void setTextDecoration(TextDecorationCollection decoration)
        {
            underlineBtn.IsChecked = decoration == TextDecorations.Underline;
        }

        private void setFontFamily(FontFamily family)
        {
            fonts.SelectedItem = family;
        }

        public bool IsSynchronizing { get; private set; }

        public void SynchronizeWith(TextSelection selection)
        {
            IsSynchronizing = true;
            Synchronize<double>(selection, TextBlock.FontSizeProperty, SetFontSize);
            Synchronize<FontWeight>(selection, TextBlock.FontWeightProperty, setFontWeight);
            IsSynchronizing = false;
        }

       
    }
}
