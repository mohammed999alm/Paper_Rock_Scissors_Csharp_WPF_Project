using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Paper_Rock_Scissors.Form3;


namespace Paper_Rock_Scissors
{
    public partial class EndGameScreen : Form
    {
        public EndGameScreen()
        {
            InitializeComponent();
        }

        private void playerPoints_Click(object sender, EventArgs e)
        {

        }


        private void decideWinner(stGameResult result) 
        {
            if (result.playerWonCounter > result.computerrWonCounter)
            {
                lblWinner.Text = "Winner : Player Won The Game With Final Result :" + result.playerWonCounter.ToString();
            }

            else if (result.playerWonCounter < result.computerrWonCounter)
            {
                lblWinner.Text = "Winner : Computer Won The Game With Final Result :" + result.computerrWonCounter.ToString();
            }

            else 
            {
                lblWinner.Text = "Winner : No Winner Draw  Player Won : " + result.playerWonCounter.ToString()
                        + " Times And Computer Won : " + result.computerrWonCounter.ToString() + " Times.";
            }
        }

        public void setFinalResults(stGameResult result)
        {
            
            lblPlayerPoints.Text = result.playerWonCounter.ToString();
            lblComputerPoints.Text = result.computerrWonCounter.ToString();
            lblDrawPoints.Text = result.drawCounter.ToString();
             
            decideWinner(result);
        }

        private void EndGameScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2.exitGame("exit");
        }
    }
}
