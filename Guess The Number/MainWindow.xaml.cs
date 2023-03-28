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

namespace Guess_The_Number
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random r = new Random();
        int currentScore = 0;
        string guess = "";
        public MainWindow()
        {
            InitializeComponent();
            ScoreLabel.Content = "Score: " + currentScore.ToString();
            
        }

        private void GuessButton_Click(object sender, RoutedEventArgs e)
        {
            guess = guessNumber.Text;
            checkWinner(guess);
        }

        private void checkWinner (string userGuess)
        {
            try
            {


                int numToGuess = r.Next(1, 10);
                int guessedNum = int.Parse(guess);

                if (numToGuess == guessedNum)
                {
                    currentScore++;
                    Title.Content = "You have won the game! " + guessedNum;
                    guessNumber.Text = "";
                    ScoreLabel.Content = "Score: " + currentScore.ToString();
                }
                else
                {
                    Title.Content = "You have lost the game! " + guessedNum;
                    guessNumber.Text = "";
                }
            }
            catch (Exception e)
            {
                Title.Content = "Error!";
                guessNumber.Text = "";
            }
        }
    }
}
