namespace FindANumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Finder finder = new();
        PrepareGamePlay gamePlay = new();

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckedNumberTextBox.Text == "")
                return;

            try
            {
                finder.InputNumber = Convert.ToInt32(CheckedNumberTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Wpisz poprawną liczbę!");
            }

            finder.GuessNumber();
            SummaryLabel.Visible = true;
            SummaryLabel.Text = finder.GuessNumber();

            if (finder.GuessNumber() == "correct")
            {
                SummaryLabel.Text = "Poprawnie";
                SummaryLabel.ForeColor = Color.Green;
                CheckButton.Enabled = false;
            }
            else if (finder.GuessNumber() == "bigger")
            {
                SummaryLabel.Text = "Poprawna liczba jest większa";
                SummaryLabel.ForeColor = Color.Red;
                gamePlay.WrongAnswer();
            }
            else
            {
                SummaryLabel.Text = "Poprawna liczba jest mniejsza";
                SummaryLabel.ForeColor = Color.Red;
                gamePlay.WrongAnswer();
            }
            LifeNumberLabel.Text = Convert.ToString(gamePlay.GetLifes());

            if(gamePlay.GetLifes() == 0)
            {
                MessageBox.Show("Nie udało się odnaleźć, spróbuj ponownie!");
                CheckButton.Enabled = false;
            }
            CheckedNumberTextBox.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            finder.RandomNumber = gamePlay.ReturnRandomNumber;
            gamePlay.SetLifes(5);
            LifeNumberLabel.Text = Convert.ToString(gamePlay.GetLifes());
            panel2.Visible = true;
            CheckButton.Enabled = true;  
        }        
    }
}