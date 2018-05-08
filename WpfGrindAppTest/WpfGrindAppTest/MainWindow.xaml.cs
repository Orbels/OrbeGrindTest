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

namespace WpfGrindAppTest
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnResultadoText_Click(object sender, RoutedEventArgs e)
        {
            tbResultadoText.Text = string.Empty;
            if (txtTexto.Text!=String.Empty)
            {
                tbResultadoText.Foreground = Brushes.DarkGreen;
                tbResultadoText.Text = txtTexto.Text;
            }
            else
            {
                tbResultadoText.Foreground = Brushes.DarkRed;
                tbResultadoText.Text = "You must enter any text";
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Type your Name in the TextBox");
        }

        private void txtTexto_GotFocus(object sender, RoutedEventArgs e)
        {
            txtTexto.Text = string.Empty;
            tbResultadoText.Text = string.Empty;
        }
    }
}
