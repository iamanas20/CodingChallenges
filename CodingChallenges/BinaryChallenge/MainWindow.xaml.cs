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

namespace BinaryChallenge
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DisplayTextBlock.Text = String.Format("Binary: {0} \n\r Number of ones: {1}", BinaryNumberManipulator.GetBinary(int.Parse(NumberTextBox.Text)), BinaryNumberManipulator.GetNumberOfOnesInABinary(BinaryNumberManipulator.GetBinary(int.Parse(NumberTextBox.Text))));
        }
    }
}
