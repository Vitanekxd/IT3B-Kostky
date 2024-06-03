using System;
using System.IO;
using System.Windows;

namespace DiceRoller
{
    public partial class MainWindow : Window
    {
        private Random random = new Random();
        private string logFilePath = "DiceRollLog.txt";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void RollDice_Click(object sender, RoutedEventArgs e)
        {
            int die1 = random.Next(1, 7);
            int die2 = random.Next(1, 7);
            int die3 = random.Next(1, 7);
            int die4 = random.Next(1, 7);
            int die5 = random.Next(1, 7);
            int die6 = random.Next(1, 7);

            Die1.Content = die1.ToString();
            Die2.Content = die2.ToString();
            Die3.Content = die3.ToString();
            Die4.Content = die4.ToString();
            Die5.Content = die5.ToString();
            Die6.Content = die6.ToString();

            LogDiceRoll(die1, die2, die3, die4, die5, die6);
        }

        private void LogDiceRoll(int die1, int die2, int die3, int die4, int die5, int die6)
        {
            string logEntry = $"{DateTime.Now}: {die1}, {die2}, {die3}, {die4}, {die5}, {die6}";
            File.AppendAllText(logFilePath, logEntry + Environment.NewLine);
        }
    }
}