/*Project 3 - Matching Game 
*CIS 3309 - Component-Based Software Design
*Created by Sam Mikulski and Bianca Tuliao
* 
* This project is an interactive and visual implementation
* of the popular game 'Memory,' in which players pick up
* two cards. If they match, the cards dissappear from the board,
* and the current player gets 2 points, and gets to go again.
* If the  cards are not a match, the other player takes their turn.
* This implementation keeps track of 2 player objects, the number 
* of points each player has per game. It also generates the board
* dynamically.
* 
* 
*/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;

namespace Memory
{
    public partial class frmMemory : Form
    {
        PlayerModel currentPlayer; // iterationCounter player object of game
        PlayerModel firstPlayer; // first player object of game
        PlayerModel secondPlayer; // second player object of game
        String firstPlayerName; // stores name of first player 
        String secondPlayerName; // stores name of second player

        private InternalBoard board = new InternalBoard(); // internal board object of game
        private static int maxRows = 4; // stores max imgNum of rows on board
        private static int maxCols = 4; // stores max imgNum of columns on board
        private int[] cardRow = new int[2]; // represents indexes of rows of selected cards 
        private int[] cardCol = new int[2]; // represents indexes of columns of selected cards
        private PictureBox[,] backOfCard = new PictureBox[maxRows, maxCols]; // stores the backside of cards on board
        private PictureBox[,] imageOfCard = new PictureBox[maxRows, maxCols]; // stores image side of cards on board

        /* represents event handler for the timer after the second card has been flipped so that both card images get displayed
         * with enough time to visually see if they're a match
        */
        public delegate void MyClickHandler(object sender, string myValue);
        public event MyClickHandler Click = delegate { };

        public frmMemory()
        {
            InitializeComponent();
        }

        /* checks to ensure first player entered a valid name that is not blank.
         * enables subsequent game controls after first player enters a valid name
        */
        private void btnFirstPlayerOK_Click(object sender, EventArgs e)
        {
            Boolean validName; // stores boolean value to determine if first player name is valid
            validName = this.ValidateName(txtFirstPlayerName.Text);

            if (validName == false) // executes if first player name is blank
            {
                txtFirstPlayerName.Clear();
                txtFirstPlayerName.Focus();
            }
            else // executes if first player name is not blank
            {
                //lblFirstPlayerInstr.Visible = false;
                btnFirstPlayerOK.Visible = false;
                txtFirstPlayerName.Enabled = false;
                lblSecondPlayerName.Visible = true;
                txtSecondPlayerName.Visible = true;
                btnSecondPlayerOK.Visible = true;

                //after first player name is validated, second player will begin to type in their name
                txtSecondPlayerName.Focus();
                txtSecondPlayerName.Select();

                firstPlayer = new PlayerModel(txtFirstPlayerName.Text); // creates PlayerModel object for first player
                firstPlayerName = txtFirstPlayerName.Text; // stores first player name
                
            }
        }

        // returns true if the name passed in the argument is not blank, otherwise false
        private Boolean ValidateName(String nameArg)
        {
            Boolean isValid = false;

            // checks if name in argument is empty
            if (String.IsNullOrEmpty(nameArg) || String.IsNullOrWhiteSpace(nameArg))
            {
                MessageBox.Show("Please enter your name");
            }
            else
            {
                isValid = true;
            }

            return isValid;
        }

        /* checks to ensure second player entered a valid name that is not blank.
         * enables subsequent game controls after second player enters a valid name
        */
        private void btnSecondPlayerOK_Click(object sender, EventArgs e)
        {
            Boolean validName; // stores boolean value to determine if second player name is valid
            validName = this.ValidateName(txtSecondPlayerName.Text);

            if (validName == false) // executes if second player name is blank
            {
                txtSecondPlayerName.Clear();
                txtSecondPlayerName.Focus();
            }
            else // executes if second player name is not blank
            {
                txtSecondPlayerName.Enabled = false;
                lblInstrTransition.Visible = true;
                lblInstructions.Visible = true;
                btnSecondPlayerOK.Visible = false;

                secondPlayer = new PlayerModel(txtSecondPlayerName.Text); // creates PlayerModel object for second player
                secondPlayerName = txtSecondPlayerName.Text; // stores first player name

                this.StartGame(); // calls StartGame() method, which will create the board and progress the game
            }
        }

        // calls CreateBoard() method to set up the board on form
        private void StartGame()
        {
            currentPlayer = firstPlayer; // iterationCounter player becomes first player
            lblCurrentPlayer.Visible = true;
            txtCurrentPlayer.Visible = true;
            txtCurrentPlayer.Text = currentPlayer.GetName();

            //Program displays the number of points per player
            lblNumPoints.Visible = true;
            lblPlayer1Score.Visible = true;
            lblPlayer1Score.Text = firstPlayer.GetPoints().ToString();
            lblPlayer2Score.Visible = true;
            lblPlayer2Score.Text = secondPlayer.GetPoints().ToString();

            this.CreateBoard();
        }

        // creates the board, its controls, and properties with values
        private void CreateBoard()
        {
            pnlBoard.Visible = true;

            int imgNum; // stores a number from 1-30 inclusive, representing an img from collection of pics
            Random rand = new Random(); 
            List<int> chosenImages = new List<int>(); // int list that contains 8 unique numbers 1-30 inclusive

            // loop 8 times to retrieve 8 random numbers to select images to be displayed on board
            for (int i = 0; i < 8; i++)
            {
                do
                {
                    imgNum = rand.Next(1, 31); // assigns a random number from 1-30 and store it
                } while (chosenImages.Contains(imgNum)); // execute while randomized number already exists in list

                chosenImages.Add(imgNum); // adds the random number to the list
            }

            // for the location of PictureBox on board
            int yCoordinate = 0;
            int xCoordinate = 0;
            Size size = new Size(83, 91);
            Point loc = new Point(0, 0);

            int picNum; // stores the number of a picture numbered 1-30
            int iterationCounter = 0; // stores number to keep track of what number iteration we're on
            int indexSelector = rand.Next(0, 8); // stores a number 0-7 that will be the index of an element from chosenImage collection
            ArrayList allNumsOnBoard = new ArrayList(); // contains 16 numbers marked 0-7 that were added on board

            /* an array that contains 30 elements, each element corresponds to the num of an image.
             * increments element num of corresponding image each time that same image is added on board
            */
            int[] picNumCounter = new int[30];
            for (int j = 0; j < picNumCounter.Length; j++)
            {
                picNumCounter[j] = 0; // set the counts to 0 initially
            }

            for (int row = 0; row < maxRows; row++)
            {
                yCoordinate = 0;

                for (int col = 0; col < maxCols; col++)
                {
                    indexSelector = rand.Next(0, 8); // retrieve a random number 0-7 to use as index
                    allNumsOnBoard.Add(chosenImages[indexSelector]); // add number that corresponds to element of specified index
                    picNum = Convert.ToInt32(allNumsOnBoard[iterationCounter]); // stores number 1-30 corresponding to img

                    /* executes as long as the counter of the specified element is greater than or equal to 2, meaning
                     * it already exists on the board twice
                    */
                    while (picNumCounter[picNum - 1] >= 2)
                    {
                        allNumsOnBoard.RemoveAt(iterationCounter); // remove the overly repeated card

                        indexSelector = rand.Next(0, 8); // retrieve a new random number

                        allNumsOnBoard.Add(chosenImages[indexSelector]); // add number to array containing all nums on board

                        picNum = Convert.ToInt32(allNumsOnBoard[iterationCounter]);
                    }

                    // the following checks for the number of the pic and its corresponding counter and increments it
                    if (picNum == 1)
                    {
                        picNumCounter[0]++;
                    }
                    else if (picNum == 2)
                    {
                        picNumCounter[1]++;
                    }
                    else if (picNum == 3)
                    {
                        picNumCounter[2]++;
                    }
                    else if (picNum == 4)
                    {
                        picNumCounter[3]++;
                    }
                    else if (picNum == 5)
                    {
                        picNumCounter[4]++;
                    }
                    else if (picNum == 6)
                    {
                        picNumCounter[5]++;
                    }
                    else if (picNum == 7)
                    {
                        picNumCounter[6]++;
                    }
                    else if (picNum == 8)
                    {
                        picNumCounter[7]++;
                    }
                    else if (picNum == 9)
                    {
                        picNumCounter[8]++;
                    }
                    else if (picNum == 10)
                    {
                        picNumCounter[9]++;
                    }
                    else if (picNum == 11)
                    {
                        picNumCounter[10]++;
                    }
                    else if (picNum == 12)
                    {
                        picNumCounter[11]++;
                    }
                    else if (picNum == 13)
                    {
                        picNumCounter[12]++;
                    }
                    else if (picNum == 14)
                    {
                        picNumCounter[13]++;
                    }
                    else if (picNum == 15)
                    {
                        picNumCounter[14]++;
                    }
                    else if (picNum == 16)
                    {
                        picNumCounter[15]++;
                    }
                    else if (picNum == 17)
                    {
                        picNumCounter[16]++;
                    }
                    else if (picNum == 18)
                    {
                        picNumCounter[17]++;
                    }
                    else if (picNum == 19)
                    {
                        picNumCounter[18]++;
                    }
                    else if (picNum == 20)
                    {
                        picNumCounter[19]++;
                    }
                    else if (picNum == 21)
                    {
                        picNumCounter[20]++;
                    }
                    else if (picNum == 22)
                    {
                        picNumCounter[21]++;
                    }
                    else if (picNum == 23)
                    {
                        picNumCounter[22]++;
                    }
                    else if (picNum == 24)
                    {
                        picNumCounter[23]++;
                    }
                    else if (picNum == 25)
                    {
                        picNumCounter[24]++;
                    }
                    else if (picNum == 26)
                    {
                        picNumCounter[25]++;
                    }
                    else if (picNum == 27)
                    {
                        picNumCounter[26]++;
                    }
                    else if (picNum == 28)
                    {
                        picNumCounter[27]++;
                    }
                    else if (picNum == 29)
                    {
                        picNumCounter[28]++;
                    }
                    else if (picNum == 30)
                    {
                        picNumCounter[29]++;
                    }

                    // creates back of card PictureBox object
                    backOfCard[row, col] = new System.Windows.Forms.PictureBox();
                    backOfCard[row, col].Location = new Point(xCoordinate, yCoordinate);
                    backOfCard[row, col].Size = size;
                    backOfCard[row, col].Enabled = true;
                    backOfCard[row, col].Visible = true;
                    backOfCard[row, col].ImageLocation = "card.png";
                    backOfCard[row, col].Name = "pic " + row + " " + col;
                    backOfCard[row, col].SizeMode = PictureBoxSizeMode.StretchImage;
                    backOfCard[row, col].Click += new EventHandler(PictureBox_Click);
                    pnlBoard.Controls.Add(backOfCard[row, col]);

                    // creates PictureBox object for image of card
                    imageOfCard[row, col] = new System.Windows.Forms.PictureBox();
                    imageOfCard[row, col].Location = new Point(xCoordinate, yCoordinate);
                    imageOfCard[row, col].Size = size;
                    imageOfCard[row, col].Enabled = false;
                    imageOfCard[row, col].Visible = true;
                    imageOfCard[row, col].ImageLocation = allNumsOnBoard[iterationCounter] + ".png";
                    imageOfCard[row, col].Name = "actualPic " + row + " " + col;
                    imageOfCard[row, col].SizeMode = PictureBoxSizeMode.StretchImage;
                    pnlBoard.Controls.Add(imageOfCard[row, col]);

                    iterationCounter++; // increment iteration cardsAdded by 1 after each time the loop executes
                    yCoordinate += 100;
                }

                xCoordinate += 100;
            }
        }

        // executes when a card/PictureBox has been clicked 
        private void PictureBox_Click(object sender, EventArgs e)
        {
            // affects backside of cards
            String[] rowCol = ((PictureBox)sender).Name.Split(' ');
            int row = Convert.ToInt32(rowCol[1]); // stores row of the card
            int col = Convert.ToInt32(rowCol[2]); // stores column of card

            // affects the image side of cards
            String[] arrayToGetNum = imageOfCard[row, col].ImageLocation.Split('.');
            int num = Convert.ToInt32(arrayToGetNum[0]); // stores the number of the image (1-30)

            board.AddCard(num); // add the image number/card that was just selected

            if (board.GetCardsAdded() <= 2) // executes of the number of cards added/selected don't exceed 2
            {
                if (board.GetCardsAdded() == 1) // executes when adding the first card selected
                {
                    // stores row and column of first card selected
                    cardCol[0] = col;
                    cardRow[0] = row;

                    backOfCard[cardRow[0], cardCol[0]].SendToBack();
                }
                else if (board.GetCardsAdded() == 2) // executes when adding the second card selected
                {
                    // stores row and column of second card selected
                    cardCol[1] = col;
                    cardRow[1] = row;

                    backOfCard[cardRow[1], cardCol[1]].SendToBack();

                    this.CardValidation(); // executes to check if cards are a match
                }
            }
            else // executes when user tries to select another card after selecting 2 cards already
            {
                for (int i = 0; i < maxRows; i++)
                {
                    for (int k = 0; k < maxCols; k++)
                    {
                        if ((i != cardRow[0] && k != cardCol[0]) && (i != cardRow[1] && k != cardCol[1]))
                        {
                            // disable all the other cards
                            backOfCard[i, k].Enabled = false;
                        }
                    }
                }
            }
        }

        // checks to see if the selected cards match and performs proper actions based on the outcome
        private async void CardValidation()
        {
            String previousPlayerName = currentPlayer.GetName(); // stores current player's name, which becomes previous player at end

            await Task.Delay(800); // pauses any action so that both images of the cards can be viewed at the same time

            // checks if number of cards added is 2 only
            if (board.GetCardsAdded() == 2)
            {
                Boolean answer = board.IsMatch(); // stores a boolean, true if the cards match, otherwise false

                if (answer == true) // if cards match
                {
                    // hide the matching cards
                    imageOfCard[cardRow[0], cardCol[0]].Visible = false;
                    imageOfCard[cardRow[1], cardCol[1]].Visible = false;
                    backOfCard[cardRow[0], cardCol[0]].Visible = false;
                    backOfCard[cardRow[1], cardCol[1]].Visible = false;

                    board.ResetCardsAdded();
                    board.RemoveCards();

                    currentPlayer.IncrementScore();

                    lblPlayer1Score.Text = firstPlayer.GetPoints().ToString();
                    lblPlayer2Score.Text = secondPlayer.GetPoints().ToString();
                }
                else // cards don't match
                {
                    // display backside of cards
                    backOfCard[cardRow[0], cardCol[0]].BringToFront();
                    backOfCard[cardRow[1], cardCol[1]].BringToFront();

                    board.ResetCardsAdded();

                    lblPlayer1Score.Text = firstPlayer.GetPoints().ToString();
                    lblPlayer2Score.Text = secondPlayer.GetPoints().ToString();

                    // switch current player with next player
                    if (previousPlayerName == firstPlayerName)
                    {
                        currentPlayer = secondPlayer;
                        txtCurrentPlayer.Text = secondPlayerName;
                    }
                    else
                    {
                        currentPlayer = firstPlayer;
                        txtCurrentPlayer.Text = firstPlayerName;
                    }
                }
            }

            // check if the total number of cards is 0
            if (board.GetTotalCards() == 0)
            {
                btnAgain.Visible = true;
                btnExit.Visible = true;

                
                String getWinner = this.DetermineWinner();
                //if it is a tie:
                if (getWinner == "tie")
                {
                    MessageBox.Show("Tie Score!");
                }
                //if it is not a tie, then either player1 or player 2 is the winner
                else
                {
                    MessageBox.Show("Congratulations! " + getWinner + " is the winner!");
                }
                
            }
        }

        // returns the name of the player with the most amount of points/is the winner of the game
        // if it is a tie, "tie" will be returned
        private String DetermineWinner()
        {
            String winner = ""; // stores the name of the winner

            // checks which player has the most points

            if (firstPlayer.GetPoints() > secondPlayer.GetPoints())
            {
                winner = firstPlayer.GetName();
            }
            else if (secondPlayer.GetPoints() > firstPlayer.GetPoints())
            {
                winner = secondPlayer.GetName();
            }
            else if (secondPlayer.GetPoints() == firstPlayer.GetPoints())
            {
                winner = "tie";
            }

            return winner;
        }

        private void frmMemory_Load(object sender, EventArgs e)
        {

        }

        //this function executes when the user clicks 'exit'
        //the program exits and closes the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgain_Click(object sender, EventArgs e)
        {
            btnAgain.Visible = false;

            board.ResetBoard();
            firstPlayer.ResetStats();
            secondPlayer.ResetStats();

            this.StartGame();
        }
    }
}
