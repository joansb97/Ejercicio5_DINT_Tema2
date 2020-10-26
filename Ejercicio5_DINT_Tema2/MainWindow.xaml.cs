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

namespace Ejercicio5_DINT_Tema2
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
        private void entradaTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            salidaTextBlock.Text = entradaTextBox.Text;
        }
        private void azulRadioButton_Click(object sender, RoutedEventArgs e)
        {
            salidaTextBlock.Foreground = new SolidColorBrush(Colors.Blue);
        }
        private void rojoRadioButton_Click(object sender, RoutedEventArgs e)
        {
            salidaTextBlock.Foreground = new SolidColorBrush(Colors.Red);
        }
        private void verdeRadioButton_Click(object sender, RoutedEventArgs e)
        {
            salidaTextBlock.Foreground = new SolidColorBrush(Colors.Green);
        }
        private void negritaCheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (negritaCheckBox.IsChecked == false) salidaTextBlock.FontWeight = FontWeights.Normal;
            else salidaTextBlock.FontWeight = FontWeights.Bold;
        }
        private void cursivaCheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (cursivaCheckBox.IsChecked == false) salidaTextBlock.FontStyle = FontStyles.Normal;
            else salidaTextBlock.FontStyle = FontStyles.Italic;
        }
    }
}
