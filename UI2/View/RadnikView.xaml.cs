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
using System.Windows.Shapes;

namespace UI2.View
{
    /// <summary>
    /// Interaction logic for RadnikView.xaml
    /// </summary>
    public partial class RadnikView : Window
    {
        public RadnikView()
        {
            InitializeComponent();
        }

        private void txt_Ime_TextChanged(object sender, TextChangedEventArgs e)
        {
            BindingOperations.GetBindingExpression(txt_Ime, TextBox.TextProperty).UpdateSource();

        }

        private void txt_Prezime_TextChanged(object sender, TextChangedEventArgs e)
        {
            BindingOperations.GetBindingExpression(txt_Prezime, TextBox.TextProperty).UpdateSource();

        }

        private void txt_Mbr_TextChanged(object sender, TextChangedEventArgs e)
        {
            BindingOperations.GetBindingExpression(txt_Mbr, TextBox.TextProperty).UpdateSource();

        }
    }
}
