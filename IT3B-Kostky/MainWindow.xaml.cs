using System;
using System.Windows;

namespace DiceRoller
{
    public partial class MainWindow : Window
    {
        private Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void RollDice_Click(object sender, RoutedEventArgs e)
        {
            Die1.Content = random.Next(1, 7).ToString();
            Die2.Content = random.Next(1, 7).ToString();
            Die3.Content = random.Next(1, 7).ToString();
            Die4.Content = random.Next(1, 7).ToString();
            Die5.Content = random.Next(1, 7).ToString();
            Die6.Content = random.Next(1, 7).ToString();
        }
    }
}