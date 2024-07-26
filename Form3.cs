using Paper_Rock_Scissors.Properties;
using System;
using System.Runtime.Versioning;
using System.Windows.Forms;

namespace Paper_Rock_Scissors
{
    public partial class Form3 : ScreenHeader
    {

        public enum enGameChoice { Paper = 1, Rock, Sicssors }

        public enum enWinner { Player = 1, Computer, Draw }
        public struct stGameResult
        {

            public enGameChoice playerChoice;
            public enGameChoice computerChoice;
            public enWinner roundWinner;
            public enWinner gameWinner;
            public byte playerWonCounter;
            public byte computerrWonCounter;
            public byte drawCounter;
        }

        stGameResult gameRound;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        public void increaseRounds() 
        {
            increaseRound();
        }

        public enGameChoice getComputerChoice() 
        {
            
            Random random = new Random();

            return gameRound.computerChoice = (enGameChoice)random.Next(1, 4);
        }


        public new void start(string choice)
        {
            //getTimeLimits(choice);
            base.start(choice);
        }

        private void  exitForm3(string message) 
        {


            if (MessageBox.Show(message, "Winner : " + lblWinStatus.Text, MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Form2 frm2 = new Form2();

                Form2.loadRoundResult(gameRound);

                //frm2.resultsData();

                //frm2.Show();


                if (!frm2.IsAccessible)
                {
                    this.Hide();
                    frm2.Close();
                }
            }
        }
        public void setWinner(enWinner winner) 
        {
            switch (winner)
            {
               case enWinner.Player:
                    lblWinStatus.Text = "Player Won";
                    gameRound.playerWonCounter++;
                    exitForm3($"You Won : {gameRound.playerChoice} Beats {gameRound.computerChoice}");
                    break;

               case enWinner.Computer:
                    lblWinStatus.Text = "Computer Won";
                    gameRound.computerrWonCounter++;
                    exitForm3($"You Lost : {gameRound.playerChoice} Got Beaten By  {gameRound.computerChoice}");
                    break;

               case enWinner.Draw:
                    lblWinStatus.Text = "Draw No Winner";
                    gameRound.drawCounter++;
                    exitForm3($"Draw : {gameRound.playerChoice} =  {gameRound.computerChoice}");
                    break;
            }
        }

        public enWinner checkRoundResult() 
        {
            switch (gameRound.playerChoice) 
            {
               case enGameChoice.Paper:
                    {
                        if (gameRound.computerChoice == enGameChoice.Paper)
                        {
                            return gameRound.roundWinner = enWinner.Draw;
                        }
                        else if (gameRound.computerChoice == enGameChoice.Rock)
                        {
                            return gameRound.roundWinner = enWinner.Player;
                        }
                        else
                        {
                            return gameRound.roundWinner = enWinner.Computer;
                        }
                    }

                case enGameChoice.Sicssors:
                    {
                        if (gameRound.computerChoice == enGameChoice.Sicssors)
                        {
                            return gameRound.roundWinner = enWinner.Draw;
                        }
                        else if (gameRound.computerChoice == enGameChoice.Paper)
                        {
                            return gameRound.roundWinner = enWinner.Player;
                        }
                        else
                        {
                            return gameRound.roundWinner = enWinner.Computer;
                        }
                    }

                case enGameChoice.Rock:
                    {

                        if (gameRound.computerChoice == enGameChoice.Rock)
                        {
                            return gameRound.roundWinner = enWinner.Draw;
                        }
                        else if (gameRound.computerChoice == enGameChoice.Sicssors)
                        {
                            return gameRound.roundWinner = enWinner.Player;
                        }
                        else
                        {
                            return gameRound.roundWinner = enWinner.Computer;
                        }
                    }

                default:

                    return gameRound.roundWinner = enWinner.Draw;
            }
        }
        


        public  void setComputerRoundChoice(enGameChoice choice) 
        {
            switch (choice)
            {
                case enGameChoice.Paper:
                    computerChoice.Image = Resources.paperRight_;
       
                    break;

                case enGameChoice.Rock:
                    computerChoice.Image = Resources.rockRight_;
                    break;

                case enGameChoice.Sicssors:
                    computerChoice.Image = Resources.scissorsRight_;
                    break;

            }
        }

      public enGameChoice getPlayerChoice(enGameChoice choice)
      {
            switch (choice) 
            {
                case enGameChoice.Paper:
                    playerChoicePBox.Image = Resources.paperLeft_;
                    return gameRound.playerChoice = choice;

                case enGameChoice.Rock:
                    playerChoicePBox.Image = Resources.rockLeft_;
                    return gameRound.playerChoice = choice;

                case enGameChoice.Sicssors:
                    playerChoicePBox.Image = Resources.ScissorsLeft;
                    return gameRound.playerChoice = choice;

                default:
                    return gameRound.playerChoice = choice;
            }
      }


        public void play(enGameChoice choice)
        {

            getPlayerChoice(choice);

            setComputerRoundChoice(getComputerChoice());

            setWinner(checkRoundResult());
        }

    }
}
