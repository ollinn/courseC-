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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void testButton_Click(object sender, RoutedEventArgs e)
        {
            // Copy the contents of the TextBox into a string
            string line = testInput.Text;
            // Format the data in the string
            line = line.Replace(",", " y:");
            line = "x:" + line;
            // Store the results in the TextBlock
            formattedText.Text = line;
        }

       
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string line;
            while((line = Console.ReadLine()) != null)
            {
                line = line.Replace(",", "y:");
                line = "x:" + line + "\n";
                formattedText.Text += line;
            }
        }
    }
}
