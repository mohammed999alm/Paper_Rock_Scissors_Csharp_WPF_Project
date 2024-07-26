using System;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static Paper_Rock_Scissors.Form3;

namespace Paper_Rock_Scissors
{

    public partial class Form2 : ScreenHeader
    {


        static stGameResult result;

        public static stGameResult getResult()
        {
            return result;
        }
        public Form2()
        {
            InitializeComponent();
        }

        static EndGameScreen endScreen = new EndGameScreen();

        static Form3 form3 = new Form3();

        static Form2 form2;
        
        private void Form2_Load(object sender, EventArgs e)
        {

            this.Dock = DockStyle.Fill;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            form3.Close();
            
            Form1 frm = new Form1();

            frm.Show();
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            btnClicked((Button)sender, enGameChoice.Rock);
        }

        

        public static void loadRoundResult(stGameResult round)
        {
            result = round;
        }

        private void btnClicked(Button pressedButton, enGameChoice choice)
        {
    
            if (!form3.IsAccessible)
            {
                this.Hide();
            }

            form3.Show();


            //frm3.getPlayerChoice(choice);

            //frm3.setComputerRoundChoice(frm3.getComputerChoice());

            //frm3.setWinner(frm3.checkRoundResult());

            //More Abstraction Than The First Version.
            //frm3.play(choice);
            form3.play(choice);

            resultsData();

           

            if (!form3.IsDisposed)
                 form3.increaseRounds();

            this.Show();

            increaseRound();
        }


        public static void copyObject(Form2 frm2) 
        {
            form2 = frm2;
        }

        public new void start(string choice)
        {
            if (form3.IsDisposed)
            {
                form3 = new Form3();
            }

            base.start(choice);

            form3.start(choice);
        }

        public new void setRoundLimit(string choice)
        {
            if (form3.IsDisposed)
            {
                form3 = new Form3();
            }

            base.setRoundLimit(choice);

            form3.setRoundLimit(choice);
        }

        public void resultsData()
        {
            lblWon.Text = "Won : " + result.playerWonCounter.ToString();
            lblLose.Text = "Lost : " + result.computerrWonCounter.ToString();
            lblDraw.Text = "Draw : " + result.drawCounter.ToString();
        }
        private void btnScissors_Click(object sender, EventArgs e)
        {
            btnClicked((Button)sender, enGameChoice.Sicssors);
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            btnClicked((Button)sender, enGameChoice.Paper);
        }

        private void hideGameScreen() 
        {
            this.Hide();
        }


        
        public static void exitGame(string command = "") 
        {

            if (command == "exit") 
            {
                form2.Close();
            }

            if (form3 != null) 
            {
                form3.Close();
            }

            if (!endScreen.IsAccessible) 
            {
                form2.Hide();
            }

            if (endScreen.IsDisposed) 
            {
                endScreen = new EndGameScreen();
            }

            endScreen.Show();
            endScreen.setFinalResults(result);
           
        }

        private void btnEndGameSession_Click(object sender, EventArgs e)
        {
            exitGame();
        }
    }
}
