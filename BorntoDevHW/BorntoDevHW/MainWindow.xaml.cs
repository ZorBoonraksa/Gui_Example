using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace BorntoDevHW
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

        private void IsNumber(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(IncomeInput.Text) || string.IsNullOrEmpty(OutcomeInput.Text) || string.IsNullOrEmpty(PriceInput.Text))
            {
                MessageBox.Show("Invalid Input");
            }
            else
            {
                float income = float.Parse(IncomeInput.Text);
                float outcome = float.Parse(OutcomeInput.Text);
                float price = float.Parse(PriceInput.Text);
                if (income <= outcome)
                {
                    MessageBox.Show("Fine sidejob(s) or check you input");
                }
                else
                {
                    Result.Text = Math.Ceiling(price / (income - outcome)).ToString() + " วัน";
                }
            }
        }
    }
}
