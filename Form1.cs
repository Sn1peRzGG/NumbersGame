using System;
using System.Windows.Forms;

namespace NumbersGame
{
    public partial class NumbersGameForm : Form
    {
        private int number;
        private int attempts;

        public NumbersGameForm()
        {
            InitializeComponent();
            inputTextBox.KeyDown += new KeyEventHandler(inputTextBox_KeyDown);  // Оновлено на inputTextBox
            restartButton.Click += new EventHandler(restartButton_Click);
            StartNewGame();
        }

        private void StartNewGame()
        {
            Random random = new Random();
            number = random.Next(1, 101);
            attempts = 0;
            inputTextBox.Text = string.Empty;  // Оновлено на inputTextBox
            resultLabel.Text = string.Empty;
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            try
            {
                int inputNumber = int.Parse(inputTextBox.Text);  // Оновлено на inputTextBox
                attempts++;

                if (inputNumber == number)
                {
                    MessageBox.Show($"Correct! You guessed the number in {attempts} attempts.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (inputNumber < number)
                {
                    resultLabel.Text = "Higher";
                }
                else
                {
                    resultLabel.Text = "Lower";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void inputTextBox_KeyDown(object sender, KeyEventArgs e)  // Оновлено на inputTextBox
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkButton_Click(this, new EventArgs());
                e.SuppressKeyPress = true;
            }
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }
    }
}
