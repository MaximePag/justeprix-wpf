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

namespace JustePrix
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int number = 0;
        public int trys = 0;
        public MainWindow()
        {
            InitializeComponent(); 
            Random rnd = new Random();
            number = rnd.Next(0, 50);
            trysLabel.Content = number;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ( number < int.Parse(guess.Text))
            {
                answer.Content = "C'est plus petit.";
                trys++;
                trysLabel.Content = trys;
            }
            else if (number > int.Parse(guess.Text))
            {
                answer.Content = "C'est plus grand.";
                trys++;
                trysLabel.Content = trys + "tentatives";
            }
            else
            {
                trys++;
                answer.Content = "Bravo ! Tu as réussi au bout de " + trys + " tentatives.";
            }
        }
    }
}
