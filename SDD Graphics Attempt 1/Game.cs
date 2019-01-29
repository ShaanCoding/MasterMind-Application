using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace SDD_Graphics_Attempt_1
{
    public partial class Game : Form
    {
        public static int winstate;
        int gamestate;
        int colorButtonArrayCounter = 0;
        int i = 0;
        public static int score;
        int counter = 0;
        int killswitch = 0;
        int[] whitePegs = new int[4];
        string[] secretCode2 = new string[4];
        string[] radioCommands = new string[4];
        public static string[] SecretCode = new string[4];
        Random randomGenerator = new Random();
        string[,] GraphicStore = new string[4, 10];
        string[,] RadioStore = new string[4, 10];
        SolidBrush BlackBrush = new SolidBrush(Color.Black);
        SolidBrush OutputBrush = new SolidBrush(Color.Black);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
        SolidBrush blueBrush = new SolidBrush(Color.Blue);
        SolidBrush orangeBrush = new SolidBrush(Color.Orange);
        SolidBrush greenBrush = new SolidBrush(Color.Green);
        SolidBrush purpleBrush = new SolidBrush(Color.Purple);
        SolidBrush blackBrush = new SolidBrush(Color.Black);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush clearBrush = new SolidBrush(Color.FromArgb(114, 137, 218));


        string[] userCodeArray2 = new string[4];
        string[] userCodeArray = new string[4];

        public Game()
        {
            score = 10000;
            //Random Number Generator
            for (int i = 0; i < 4; i++)
            {
                SecretCode[i] = Convert.ToString(randomGenerator.Next(1, 7));
            }
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //Buttons
        private void button1_Click(object sender, EventArgs e)
        {
            if (colorButtonArrayCounter < 4)
            {
                userCodeArray[colorButtonArrayCounter] = "1";
                userCodeArray2[colorButtonArrayCounter] = "1";
                colorButtonArrayCounter++;
                Invalidate();
                Refresh();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (colorButtonArrayCounter < 4)
            {
                userCodeArray[colorButtonArrayCounter] = "2";
                userCodeArray2[colorButtonArrayCounter] = "2";
                colorButtonArrayCounter++;
                Invalidate();
                Refresh();
            }
        }

        private void BlueButton_Click(object sender, EventArgs e)
        {
            if (colorButtonArrayCounter < 4)
            {
                userCodeArray[colorButtonArrayCounter] = "3";
                userCodeArray2[colorButtonArrayCounter] = "3";
                colorButtonArrayCounter++;
                Invalidate();
                Refresh();
            }
        }

        private void OrangeButton_Click(object sender, EventArgs e)
        {
            if (colorButtonArrayCounter < 4)
            {
                userCodeArray[colorButtonArrayCounter] = "4";
                userCodeArray2[colorButtonArrayCounter] = "4";
                colorButtonArrayCounter++;
                Invalidate();
                Refresh();
            }
        }

        private void GreenButton_Click(object sender, EventArgs e)
        {
            if (colorButtonArrayCounter < 4)
            {
                userCodeArray[colorButtonArrayCounter] = "5";
                userCodeArray2[colorButtonArrayCounter] = "5";
                colorButtonArrayCounter++;
                Invalidate();
                Refresh();
            }
        }

        private void PurpleButton_Click(object sender, EventArgs e)
        {
            if (colorButtonArrayCounter < 4)
            {
                userCodeArray[colorButtonArrayCounter] = "6";
                userCodeArray2[colorButtonArrayCounter] = "6";
                colorButtonArrayCounter++;
                Invalidate();
                Refresh();
            }
        }

        private void ScoreBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if (colorButtonArrayCounter == 4)
            {
            colorButtonArrayCounter = 0;
            gamestate = 1;
            game();
            Invalidate();
            Refresh();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            colorButtonArrayCounter = 0;
            for (i = 0; i < 4; i++)
            {
                userCodeArray2[i] = "NULL";
            }
            Refresh();
            Invalidate();
        }
        //End Of Buttons
        //Game Runs When Confirm Button Is Pressed Only Runs When GameState =1
        private void game()
        {
            //Sets UserCodeArray To Null Drawing Black, Storing Graphics Previous Trys In UI & Resetting Pegs
            if (gamestate == 1) { 
                for (i = 0; i < 4; i++)
                {
                    userCodeArray2[i] = "NULL";
                    GraphicStore[i, counter] = userCodeArray[i];
                    radioCommands[i] = "0";
                }

                //Black & White Pegs
                for (int i = 0; i < 4; i++)
                {
                    if (userCodeArray[i] == SecretCode[i])
                    {
                        whitePegs[i] = 1;
                        radioCommands[i] = "+";
                        secretCode2[i] = "NA";
                    }
                    else
                    {
                        whitePegs[i] = 0;
                        secretCode2[i] = Convert.ToString(SecretCode[i]);
                    }
                }
                for (int i = 0; i < 4; i++)
                {
                    for (int x = 0; x < 4; x++)
                    {
                        if (whitePegs[i] == 0)
                        {
                            if (userCodeArray[i] == secretCode2[x])
                            {
                                radioCommands[i] = "-";
                                secretCode2[x] = "NA";
                            }
                        }
                    }
                }

                var shuffledRadio = radioCommands.OrderBy(a => Guid.NewGuid()).ToList();
                for (int i = 0; i < 4; i++)
                {
                    RadioStore[i, counter] = shuffledRadio[i];
                }
                //Killswitch counter if true will end loop
                for (int i = 0; i < 4; i++)
                {
                    killswitch = killswitch + whitePegs[i];
                }
                if (killswitch == 4)
                {
                    winstate = 1;
                    this.Hide();
                    EndGame endGame = new EndGame();
                    endGame.Show();
                }
                else 
                {
                    killswitch = 0;
                    counter++;
                    score = score - 1000;
                }
                if (score == 0)
                {
                    winstate = 0;
                    this.Hide();
                    EndGame endGame = new EndGame();
                    endGame.Show();
                }
                gamestate = 0;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
   
        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            //Draws The Peg Graphics
            Graphics radioCommandGraphics = e.Graphics;
            int x = 35;
            int y = 30;
            Pen blackpen = new Pen(Color.Black);
            radioCommandGraphics.DrawRectangle(blackpen, 30, 20, 30, 320);
            for (int l = 0; l < 10; l++)
            {
                for (i = 0; i < 2; i++)
                {
                    if (RadioStore[i, l] == "0")
                    {
                        radioCommandGraphics.FillEllipse(orangeBrush, x, y, 10, 10);
                    }
                    else if (RadioStore[i, l] == "+")
                    {
                        radioCommandGraphics.FillEllipse(blackBrush, x, y, 10, 10);
                    }
                    else if (RadioStore[i, l] == "-")
                    {
                        radioCommandGraphics.FillEllipse(whiteBrush, x, y, 10, 10);
                    }
                    else
                    {
                        radioCommandGraphics.FillEllipse(orangeBrush, x, y, 10, 10);
                    }
                    x = x + 10;
                }
                y = y + 10;
                x = 35;
                for (i = 2; i < 4; i++)
                {
                    if (RadioStore[i, l] == "0")
                    {
                        radioCommandGraphics.FillEllipse(orangeBrush, x, y, 10, 10);
                    }
                    else if (RadioStore[i, l] == "+")
                    {
                        radioCommandGraphics.FillEllipse(blackBrush, x, y, 10, 10);
                    }
                    else if (RadioStore[i, l] == "-")
                    {
                        radioCommandGraphics.FillEllipse(whiteBrush, x, y, 10, 10);
                    }
                    else
                    {
                        radioCommandGraphics.FillEllipse(orangeBrush, x, y, 10, 10);
                    }
                    x = x + 10;
                }
                x = 35;
                y = y + 21;
            }
            gamestate = 0;

            //Draws The Current User Inputs
            Graphics UserGuessGUI = e.Graphics;
            y = 30;
            x = 75;
                    for (int a = 0; a < 10; a++)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            if (GraphicStore[i, a] == "1")
                            {
                                OutputBrush = redBrush;
                            }
                            if (GraphicStore[i, a] == "2")
                            {
                                OutputBrush = yellowBrush;
                            }
                            if (GraphicStore[i, a] == "3")
                            {
                                OutputBrush = blueBrush;
                            }
                            if (GraphicStore[i, a] == "4")
                            {
                                OutputBrush = orangeBrush;
                            }
                            if (GraphicStore[i, a] == "5")
                            {
                                OutputBrush = greenBrush;
                            }
                            if (GraphicStore[i, a] == "6")
                            {
                                OutputBrush = purpleBrush;
                            }
                    
                    UserGuessGUI.FillEllipse(OutputBrush, x, y, 30, 30);
                    OutputBrush = BlackBrush;
                    this.Invalidate();
                    x = x + 50;
                        }
                x = 75;
                y = y + 30;
                    }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //Draws The Previous UserInputs In A History
            ScoreBox.Text = Convert.ToString(score);
            Graphics userInputGraphics = e.Graphics;
            int xcoords = 10;
            for (i = 0; i < 4; i++)
            {
                if (userCodeArray2[i] == "1")
                {
                    OutputBrush = redBrush;
                }
                if (userCodeArray2[i] == "2")
                {
                    OutputBrush = yellowBrush;
                }
                if (userCodeArray2[i] == "3")
                {
                    OutputBrush = blueBrush;
                }
                if (userCodeArray2[i] == "4")
                {
                    OutputBrush = orangeBrush;
                }
                if (userCodeArray2[i] == "5")
                {
                    OutputBrush = greenBrush;
                }
                if (userCodeArray2[i] == "6")
                {
                    OutputBrush = purpleBrush;
                }
                if (userCodeArray2[i] == "NULL")
                {
                    OutputBrush = blackBrush;
                }
                userInputGraphics.FillEllipse(OutputBrush, xcoords, 300, 25, 25);
                OutputBrush = blackBrush;
                xcoords = xcoords + 40;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Invalidate();
            Refresh();
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }
    }
}
