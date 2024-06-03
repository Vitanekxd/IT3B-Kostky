using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;

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

            UpdateDie(new Ellipse[] { Die1Dot1, Die1Dot2, Die1Dot3, Die1Dot4, Die1Dot5, Die1Dot6, Die1Dot7 }, die1);
            UpdateDie(new Ellipse[] { Die2Dot1, Die2Dot2, Die2Dot3, Die2Dot4, Die2Dot5, Die2Dot6, Die2Dot7 }, die2);
            UpdateDie(new Ellipse[] { Die3Dot1, Die3Dot2, Die3Dot3, Die3Dot4, Die3Dot5, Die3Dot6, Die3Dot7 }, die3);
            UpdateDie(new Ellipse[] { Die4Dot1, Die4Dot2, Die4Dot3, Die4Dot4, Die4Dot5, Die4Dot6, Die4Dot7 }, die4);
            UpdateDie(new Ellipse[] { Die5Dot1, Die5Dot2, Die5Dot3, Die5Dot4, Die5Dot5, Die5Dot6, Die5Dot7 }, die5);
            UpdateDie(new Ellipse[] { Die6Dot1, Die6Dot2, Die6Dot3, Die6Dot4, Die6Dot5, Die6Dot6, Die6Dot7 }, die6);

            LogDiceRoll(die1, die2, die3, die4, die5, die6);
        }

        private void UpdateDie(Ellipse[] dots, int number)
        {
            foreach (var dot in dots)
            {
                dot.Visibility = Visibility.Collapsed;
            }

            switch (number)
            {
                case 1:
                    dots[2].Visibility = Visibility.Visible;
                    break;
                case 2:
                    dots[0].Visibility = Visibility.Visible;
                    dots[4].Visibility = Visibility.Visible;
                    break;
                case 3:
                    dots[0].Visibility = Visibility.Visible;
                    dots[2].Visibility = Visibility.Visible;
                    dots[4].Visibility = Visibility.Visible;
                    break;
                case 4:
                    dots[0].Visibility = Visibility.Visible;
                    dots[1].Visibility = Visibility.Visible;
                    dots[3].Visibility = Visibility.Visible;
                    dots[4].Visibility = Visibility.Visible;
                    break;
                case 5:
                    dots[0].Visibility = Visibility.Visible;
                    dots[1].Visibility = Visibility.Visible;
                    dots[2].Visibility = Visibility.Visible;
                    dots[3].Visibility = Visibility.Visible;
                    dots[4].Visibility = Visibility.Visible;
                    break;
                case 6:
                    dots[0].Visibility = Visibility.Visible;
                    dots[1].Visibility = Visibility.Visible;
                    dots[3].Visibility = Visibility.Visible;
                    dots[4].Visibility = Visibility.Visible;
                    dots[5].Visibility = Visibility.Visible;
                    break;
            }
        }

        private void LogDiceRoll(int die1, int die2, int die3, int die4, int die5, int die6)
        {
            string logEntry = $"{DateTime.Now}: {die1}, {die2}, {die3}, {die4}, {die5}, {die6}";
            File.AppendAllText(logFilePath, logEntry + Environment.NewLine);
        }
    }
}