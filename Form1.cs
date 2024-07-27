using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Paper_Rock_Scissors
{
    public partial class Form1 : Form
    {

        byte choiceNumberTimeLimits = 0;
        string[] choicesTimeLimits = { "Unlimited", "2 Minutes", "5 Minutes", "10 Minutes", "15 Minutes" };

        byte choiceNumberRounds = 0;

        string[] roundsChoices = { "Unlimited", "5 Rounds", "15 Rounds", "25 Rounds"};

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {

            ScreenHeader screen = new ScreenHeader();

            //screen.getTimeLimits(lblTimeLimit.Text);

            Form2 frm2 = new Form2();

            frm2.start(lblTimeLimit.Text);
            frm2.setRoundLimit(lblRoundChoice.Text);
            //frm2.Owner = this;

            Form2.copyObject(frm2);

            frm2.Show();

            

            //frm2.setTimeLimits(lblTimeLimit.Text);


            if (!frm2.IsAccessible) 
            {
                this.Hide(); 
            }
          
        }


        protected void showStartButton()
        {
            btnStartGame.Show();
        }

        protected void hideStartButton()
        {

            btnStartGame.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnRightChoice_Click(object sender, EventArgs e)
        {

            if ((choiceNumberTimeLimits + 1) == choicesTimeLimits.Length - 1) 
            {
                btnRightChoice.Enabled = false;
            }

            choiceNumberTimeLimits++;

            lblTimeLimit.Text = choicesTimeLimits[choiceNumberTimeLimits];


            btnLeftChoice.Enabled = true;
        }

        private void btnLeftChoice_Click(object sender, EventArgs e)
        {
            if (choiceNumberTimeLimits == 0) 
            {
                btnLeftChoice.Enabled = false;
                return;
            }

            choiceNumberTimeLimits--;

            lblTimeLimit.Text = choicesTimeLimits[choiceNumberTimeLimits];


            btnRightChoice.Enabled = true;
        }

        private void btnRoundRightArrow_Click(object sender, EventArgs e)
        {
            if ((choiceNumberRounds + 1) == roundsChoices.Length - 1)
            {
                btnRoundRightArrow.Enabled = false;
            }

            choiceNumberRounds++;

            lblRoundChoice.Text = roundsChoices[choiceNumberRounds];


            btnRoundLeftArrow.Enabled = true;
        }

        private void btnRoundLeftArrow_Click(object sender, EventArgs e)
        {
            if (choiceNumberRounds == 0)
            {
                btnRoundLeftArrow.Enabled = false;
                return;
            }

            choiceNumberRounds--;

            lblRoundChoice.Text = roundsChoices[choiceNumberRounds];


            btnRoundRightArrow.Enabled = true;
        }
    }
}
