using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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


        static string projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;

        string videoPath = Path.Combine(projectDirectory, "Paper_Rock_Scissors", "Videos", "You're Broke.mp4");
        private void decideWinner(stGameResult result) 
        {
            
            if (result.playerWonCounter > result.computerrWonCounter)
            {
                lblWinner.Text = "Winner : Player Won The Game With Final Result :" + result.playerWonCounter.ToString();
            }

            else if (result.playerWonCounter < result.computerrWonCounter)
            {
                lblWinner.Text = "Winner : Computer Won The Game With Final Result :" + result.computerrWonCounter.ToString();

                if (File.Exists(videoPath))
                {
                    axWindowsMediaPlayer1.Visible = true;

                    axWindowsMediaPlayer1.URL = videoPath;

                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }

                axWindowsMediaPlayer1.PlayStateChange += axWindowsMediaPlayer1_PlayStateChange;
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
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            axWindowsMediaPlayer1.close();

            Form2.exitGame("exit");
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {

            if (e.newState == (int)WMPLib.WMPPlayState.wmppsStopped) 
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }
    }
}
