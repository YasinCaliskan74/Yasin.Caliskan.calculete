using System;
using System.Collections.Generic;
using System.Data;
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

namespace Yasin.Caliskan.calculete
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private int number1 = 0;
        private int number2 = 0;
        private char operation = ' ';
        private int result = 0;
     

        private void BTN_Number_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button; // Cast sender to Button
            if (button != null)
            {
                TB_display.Text += button.Content.ToString(); // Append the button's content to TB_display
            }
        }

        private void BTN_PLUS_Click(object sender, RoutedEventArgs e)
        {
            number1 = int.Parse(TB_display.Text);
            operation = '+';
            TB_display.Text = ""; // Add '+' to the display
        }

        private void BTN_MOINS_Click(object sender, RoutedEventArgs e)
        {
            number1 = int.Parse(TB_display.Text);
            operation = '-';
            TB_display.Text = ""; // Add '-' to the display
        }

        private void BTN_FOIS_Click(object sender, RoutedEventArgs e)
        {
            number1 = int.Parse(TB_display.Text);
            operation = '*';
            TB_display.Text = ""; // Add '*' to the display
        }

        private void BTN_division_Click(object sender, RoutedEventArgs e)
        {

            number1 = int.Parse(TB_display.Text);
            operation = '/';
            TB_display.Text = ""; // Add '/' to the display
        }

        private void BTN_CLR_Click(object sender, RoutedEventArgs e)
        {
            TB_display.Text = ""; // Clear the display
        }

        private void BTN_EGAL_Click(object sender, RoutedEventArgs e)
        {
                try
                {
                    number2 = int.Parse(TB_display.Text); // Lire la deuxième valeur
                    switch (operation)
                    {
                        case '+':
                            result = number1 + number2;
                            break;
                        case '-':
                            result = number1 - number2;
                            break;
                        case '*':
                            result = number1 * number2;
                            break;
                        case '/':
                            if (number2 != 0)
                            {
                                result = number1 / number2;
                            }
                            else
                            {
                                TB_display.Text = "Erreur"; // Division par zéro
                                return;
                            }
                            break;
                    }

                    TB_display.Text = result.ToString(); // Afficher le résultat
                }
                catch
                {
                    TB_display.Text = "Erreur"; // Afficher un message d'erreur en cas de problème
                }
            }



    }
}
