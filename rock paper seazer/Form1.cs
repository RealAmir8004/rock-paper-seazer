using System;
using System.Windows.Forms;

namespace RockPaperScissorsGame
{
    public partial class Form1 : Form
    {
        private readonly string[] choices = { "Rock", "Paper", "Scissors" };
        private readonly Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnChoice_Click(object sender, EventArgs e)
        {
            // Get user choice from the button text:
            Button clickedButton = sender as Button;
            string userChoice = clickedButton.Text;

            // Get computer choice:
            string computerChoice = choices[random.Next(choices.Length)];

            // Display computer choice:
            lblComputerChoice.Text = $"Computer chose: {computerChoice}";

            // result:
            string result;
            if (userChoice == computerChoice)
            {
                result = "moasvi shod ke !";
            }
            else if ((userChoice == "Rock" && computerChoice == "Scissors") ||
                     (userChoice == "Paper" && computerChoice == "Rock") ||
                     (userChoice == "Scissors" && computerChoice == "Paper"))
            {
                result = "Bordiii vali maghror nasho!";
            }
            else
            {
                result = "ishala dafe baad!";
            }

            // Display  result :
            lblResult.Text = result;
        }
    }
}
