using Paper_Rock_Scissors.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.Versioning;
using System.Windows.Forms;
using static Paper_Rock_Scissors.Form3;


namespace Paper_Rock_Scissors
{
    public partial class ScreenHeader : Form
    {

        protected System.Media.SoundPlayer playerSound;
        public ScreenHeader() 
        {
            InitializeComponent();
            playerSound = new System.Media.SoundPlayer(audioPath);
        }

        int countTimer = 0;

        int choosenTime = 0;

        stGameResult gameResult;

        int roundLimit = 0;

        int round = 0;

        static string projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;

        string audioPath = Path.Combine(projectDirectory, "Paper_Rock_Scissors", "Audio", "Counter.wav");

    
        int playCounter = 0;
        protected void increaseRound() 
        {
            
            round++;

            lblRound.Text = $"Round : {round}";

            if (roundLimit <= 0) 
            {
                return;
            } 

            if (round > roundLimit)
            {
                Form2.exitGame();
            }
        }


        private void getRoundsLimits(string choice) 
        {
            choice = choice.ToLower();
            switch (choice)
            {
                case "unlimited":
                    lblRound.Text = "∞";
                    roundLimit = -1;
                    break;

                case "5 rounds":
                    roundLimit = 5;
                    break;

                case "10 rounds":
                    roundLimit = 10;
                    break;

                case "15 rounds":
                    roundLimit = 15;
                    break;
            }

            increaseRound();  
        }
        

        public void setRoundLimit(string limit) 
        {
            getRoundsLimits(limit);
        }
        
        

        private void getTimeLimits(string choice) 
        {
            choice = choice.ToLower(); 
            switch (choice) 
            {
                case "unlimited":
                    countTimer = 0;
                    timer1.Enabled = false;
                    lblTimer.Show();
                    break;


                case "2 minutes":
                    countTimer = 2 * 60;
                    //countTimer = 65;//For test purposes.
                    timer1.Enabled = true;
                    break;

                case "5 minutes":
                    countTimer = 5 * 60;
                    timer1.Enabled = true;
                    break;

                case "10 minutes":
                    countTimer = 10 * 60;
                    timer1.Enabled = true;
                    break;

                case "15 minutes":
                    countTimer = 15 * 60;
                    timer1.Enabled = true;
                    break;

                default: 
                    resume(choice);
                    break;
            }

            choosenTime = countTimer;
        }

        public  void start(string choice) 
        {
            getTimeLimits(choice);
        }


        private void resume(string time) 
        {
            string []times = time.Split(':');

            countTimer = int.Parse(times[0]) * 60 + int.Parse(times[1]);
            timer1.Enabled = true;
        }

        
        protected void timer1_Tick(object sender, EventArgs e)
        {

         
            int minutes = countTimer / 60;
            int seconds = countTimer % 60;

            if (countTimer == 0) 
            {
                lblTimer.Text = "00:00";
                timer1.Enabled = false;


                gameResult = Form2.getResult();
                Form2.exitGame();

                return;
            }


            if (countTimer == choosenTime * 0.75)
            {
                lblTimer.ForeColor = Color.GreenYellow;
            }

            if (countTimer == choosenTime * 0.50) 
            {
                lblTimer.ForeColor = Color.Yellow;
            }

            if (countTimer == choosenTime * 0.25) 
            {
                lblTimer.ForeColor = Color.Orange;
            }


            if (countTimer >= 60)
            {

                lblTimer.Text = minutes.ToString("D2") + ":" + seconds.ToString("D2");
            }

            else 
            {


                if (playCounter == 0)
                {
                    playerSound.Play();
                    playCounter++;
                }
           
                
                lblTimer.ForeColor = Color.Red;
                lblTimer.Text = minutes.ToString("D2") + ":" + seconds.ToString("D2");
            }

            lblTimer.Visible = true;

            countTimer--;
        }

 
    }
}
