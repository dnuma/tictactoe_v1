// Author: David Numa

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TicTacToe
{
    class VM : INotifyPropertyChanged
    {
        #region properties
        private string[] PC_IMAGES_ROUTE = new string[] { "Images/x.png", "Images/o.png" };
        private string[,] xorO = new string [3,3];
        private bool[,] pos = new bool[3, 3] { { true, true, true}, { true, true, true }, { true, true, true } };
        // 0 = nothing, 1 = X, 2 = O
        public int[,] positions = new int[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
        public string[] messages = new string[4] { "Start!", "You Won!", "You Lost", "Tie!"};
        public string message = "Start!";
        public int win, lose, tie, isBoardFull = 0;

        public int [,] Positions
        {
            get { return positions;  }
            set
            {
                for(int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        positions[i,j] = value[i,j];
                    }
                }
                notifyChange();
            }
        }
        public bool ImgPos00
        {
            get { return pos[0, 0]; }
            set
            {
                pos[0, 0] = value;
                notifyChange();
            }
        }
        public bool ImgPos01
        {
            get { return pos[0, 1]; }
            set
            {
                pos[0, 1] = value;
                notifyChange();
            }
        }
        public bool ImgPos02
        {
            get { return pos[0, 2]; }
            set
            {
                pos[0, 2] = value;
                notifyChange();
            }
        }
        public bool ImgPos10
        {
            get { return pos[1, 0]; }
            set
            {
                pos[1, 0] = value;
                notifyChange();
            }
        }
        public bool ImgPos11
        {
            get { return pos[1, 1]; }
            set
            {
                pos[1, 1] = value;
                notifyChange();
            }
        }
        public bool ImgPos12
        {
            get { return pos[1, 2]; }
            set
            {
                pos[1, 2] = value;
                notifyChange();
            }
        }
        public bool ImgPos20
        {
            get { return pos[2, 0]; }
            set
            {
                pos[2, 0] = value;
                notifyChange();
            }
        }
        public bool ImgPos21
        {
            get { return pos[2, 1]; }
            set
            {
                pos[2, 1] = value;
                notifyChange();
            }
        }
        public bool ImgPos22
        {
            get { return pos[2, 2]; }
            set
            {
                pos[2, 2] = value;
                notifyChange();
            }
        }
        public bool BtnPos00
        {
            get { return pos[0, 0]; }
            set
            {
                pos[0, 0] = value;
                notifyChange();
            }
        }
        public bool BtnPos01
        {
            get { return pos[0, 1]; }
            set
            {
                pos[0, 1] = value;
                notifyChange();
            }
        }
        public bool BtnPos02
        {
            get { return pos[0, 2]; }
            set
            {
                pos[0, 2] = value;
                notifyChange();
            }
        }
        public bool BtnPos10
        {
            get { return pos[1, 0]; }
            set
            {
                pos[1, 0] = value;
                notifyChange();
            }
        }
        public bool BtnPos11
        {
            get { return pos[1, 1]; }
            set
            {
                pos[1, 1] = value;
                notifyChange();
            }
        }
        public bool BtnPos12
        {
            get { return pos[1, 2]; }
            set
            {
                pos[1, 2] = value;
                notifyChange();
            }
        }
        public bool BtnPos20
        {
            get { return pos[2, 0]; }
            set
            {
                pos[2, 0] = value;
                notifyChange();
            }
        }
        public bool BtnPos21
        {
            get { return pos[2, 1]; }
            set
            {
                pos[2, 1] = value;
                notifyChange();
            }
        }
        public bool BtnPos22
        {
            get { return pos[2, 2]; }
            set
            {
                pos[2, 2] = value;
                notifyChange();
            }
        }
        public string XorO00
        {
            get { return xorO[0, 0]; }
            set
            {
                xorO[0, 0] = value;
                notifyChange();
            }
        }
        public string XorO01
        {
            get { return xorO[0, 1]; }
            set
            {
                xorO[0, 1] = value;
                notifyChange();
            }
        }
        public string XorO02
        {
            get { return xorO[0, 2]; }
            set
            {
                xorO[0, 2] = value;
                notifyChange();
            }
        }
        public string XorO10
        {
            get { return xorO[1, 0]; }
            set
            {
                xorO[1, 0] = value;
                notifyChange();
            }
        }
        public string XorO11
        {
            get { return xorO[1, 1]; }
            set
            {
                xorO[1, 1] = value;
                notifyChange();
            }
        }
        public string XorO12
        {
            get { return xorO[1, 2]; }
            set
            {
                xorO[1, 2] = value;
                notifyChange();
            }
        }
        public string XorO20
        {
            get { return xorO[2, 0]; }
            set
            {
                xorO[2, 0] = value;
                notifyChange();
            }
        }
        public string XorO21
        {
            get { return xorO[2, 1]; }
            set
            {
                xorO[2, 1] = value;
                notifyChange();
            }
        }
        public string XorO22
        {
            get { return xorO[2, 2]; }
            set
            {
                xorO[2, 2] = value;
                notifyChange();
            }
        }
        public int Win
        {
            get { return win; }
            set
            {
                win = value;
                notifyChange();
            }
        }
        public int Lose
        {
            get { return lose; }
            set
            {
                lose = value;
                notifyChange();
            }
        }
        public int Tie
        {
            get { return tie; }
            set
            {
                tie = value;
                notifyChange();
            }
        }
        public string Message
        {
            get { return message;  }
            set
            {
                message = value;
                notifyChange();
            }
        }
        #endregion

        /// <summary>
        ///  Display the image, hide the button, save the position in the array
        /// </summary>
        /// <param name="selectedElement"></param> string of the position
        /// <param name="player"></param> true = player, false= pc
        public void FlipButton(string selectedElement, bool player)
        {
            // Find the element selected, hide the button, display the image and select the corresponding image: X or O
            switch (selectedElement)
            {
                case "pos00":
                    // Set up the image route (x.png or o.png)
                    XorO00 = player ? PC_IMAGES_ROUTE[0] : PC_IMAGES_ROUTE[1];
                    // Save the position (player = 1, pc = 2, no position taken = 0)
                    Positions[0, 0] = player ? 1 : 2;
                    // Hide the selected button
                    BtnPos00 = false;
                    // Display the selected image
                    ImgPos00 = true;
                    break;
                case "pos01":
                    XorO01 = player ? PC_IMAGES_ROUTE[0] : PC_IMAGES_ROUTE[1];
                    Positions[0, 1] = player ? 1 : 2;
                    BtnPos01 = false;
                    ImgPos01 = true;
                    break;
                case "pos02":
                    XorO02 = player ? PC_IMAGES_ROUTE[0] : PC_IMAGES_ROUTE[1];
                    Positions[0, 2] = player ? 1 : 2;
                    BtnPos02 = false;
                    ImgPos02 = true;
                    break;
                case "pos10":
                    XorO10 = player ? PC_IMAGES_ROUTE[0] : PC_IMAGES_ROUTE[1];
                    Positions[1, 0] = player ? 1 : 2;
                    BtnPos10 = false;
                    ImgPos10 = true;
                    break;
                case "pos11":
                    XorO11 = player ? PC_IMAGES_ROUTE[0] : PC_IMAGES_ROUTE[1];
                    Positions[1, 1] = player ? 1 : 2;
                    BtnPos11 = false;
                    ImgPos11 = true;
                    break;
                case "pos12":
                    XorO12 = player ? PC_IMAGES_ROUTE[0] : PC_IMAGES_ROUTE[1];
                    Positions[1, 2] = player ? 1 : 2;
                    BtnPos12 = false;
                    ImgPos12 = true;
                    break;
                case "pos20":
                    XorO20 = player ? PC_IMAGES_ROUTE[0] : PC_IMAGES_ROUTE[1];
                    Positions[2, 0] = player ? 1 : 2;
                    BtnPos20 = false;
                    ImgPos20 = true;
                    break;
                case "pos21":
                    XorO21 = player ? PC_IMAGES_ROUTE[0] : PC_IMAGES_ROUTE[1];
                    Positions[2, 1] = player ? 1 : 2;
                    BtnPos21 = false;
                    ImgPos21 = true;
                    break;
                case "pos22":
                    XorO22 = player ? PC_IMAGES_ROUTE[0] : PC_IMAGES_ROUTE[1];
                    Positions[2, 2] = player ? 1 : 2;
                    BtnPos22 = false;
                    ImgPos22 = true;
                    break;
            }
        }

        /// <summary>
        ///  Calls flip button method, check if there's a winner and calls player2 method if it's possible
        /// </summary>
        /// <param name="selectedElement"></param> position of the selected element.
        public void Player1Turn (string selectedElement)
        {
            FlipButton(selectedElement, true);
            int winner = CheckWin();
            // Only execute if there's no winner yet
            if(winner < 0)
            {
                Player2Turn();
                _ = CheckWin(); // Discard the result received, not needed in this step
            }
            
            
        }

        /// <summary>
        /// Randomly selects a position for the computer
        /// </summary>
        public void Player2Turn()
        {
            int MAXBOARDSIZE = 3;
            int NOPOSITIONTAKEN = 0;
            Random r = new Random();
            int indexCol = r.Next(MAXBOARDSIZE);
            int indexRow = r.Next(MAXBOARDSIZE);
            string selectedElement;
            int exit = 0;

            // Find a position in the board
            do
            {
                if (Positions[indexRow, indexCol] > NOPOSITIONTAKEN)
                {
                    indexCol = r.Next(MAXBOARDSIZE);
                    indexRow = r.Next(MAXBOARDSIZE);
                    exit++;  // secure exit if the board is full (exit = 9)
                }
                else
                {
                    exit = MAXBOARDSIZE * MAXBOARDSIZE;
                }
            } while (exit < (MAXBOARDSIZE * MAXBOARDSIZE - 1));

            // Send the position to the board
            if(indexRow == 0)
            {
                switch(indexCol)
                {
                    case 0:
                        selectedElement = "pos00";
                        break;
                    case 1:
                        selectedElement = "pos01";
                        break;
                    default:
                        selectedElement = "pos02";
                        break;
                }
            } else if (indexRow == 1)
            {
                switch (indexCol)
                {
                    case 0:
                        selectedElement = "pos10";
                        break;
                    case 1:
                        selectedElement = "pos11";
                        break;
                    default:
                        selectedElement = "pos12";
                        break;
                }
            } else
            {
                switch (indexCol)
                {
                    case 0:
                        selectedElement = "pos20";
                        break;
                    case 1:
                        selectedElement = "pos21";
                        break;
                    default:
                        selectedElement = "pos22";
                        break;
                }
            } 

            // Sending false = computer
            FlipButton(selectedElement, false);

        }

        /// <summary>
        /// Check if there's a winner in the board
        /// </summary>
        /// <returns>1 = player, 2 = pc, -1 = no winner</returns>
        public int CheckWin()
        {
            int winner = -1;
            int MAXBOARDSIZE = 3;
            isBoardFull++;
            // Horizontal check
            for (int i = 0; i < MAXBOARDSIZE; i++)
            {
                if (Positions[i, 0] == Positions[i, 1] && Positions[i, 1] == Positions[i, 2])
                {
                    // Who won the match? 1 = player, 2 = PC
                    if (Positions[i, 0] == 1)
                    {
                        winner = 1;
                        Win++;
                        Message = messages[1];
                    }
                    else if (Positions[i, 0] == 2)
                    {
                        winner = 2;
                        Lose++;
                        Message = messages[2];
                    }
                }
            }

            // Vertical Check
            for (int i = 0; i < MAXBOARDSIZE; i++)
            {
                if (Positions[0, i] == Positions[1, i] && Positions[1, i] == Positions[2, i])
                {
                    if (Positions[0, i] == 1)
                    {
                        winner = 1;
                        Win++;
                        Message = messages[1];
                    }
                    else if (Positions[0, i] == 2)
                    {
                        winner = 2;
                        Lose++;
                        Message = messages[2];
                    }
                }
            }

            // Diagonal Check
            if (Positions[0,0] == Positions [1,1] && Positions [1,1] == Positions [2,2])
            {
                if (Positions[0, 0] == 1)
                {
                    winner = 1;
                    Win++;
                    Message = messages[1];
                }
                else if (Positions[0, 0] == 2)
                {
                    winner = 2;
                    Lose++;
                    Message = messages[2];
                }
            }
            if (Positions[0, 2] == Positions[1, 1] && Positions[1, 1] == Positions[2, 0])
            {
                if (Positions[0, 2] == 1)
                {
                    winner = 1;
                    Win++;
                    Message = messages[1];
                }
                else if (Positions[0, 2] == 2)
                {
                    winner = 2;
                    Lose++;
                    Message = messages[2];
                }
            }
            // Tie Check
            if (isBoardFull > (MAXBOARDSIZE * MAXBOARDSIZE))
            {
                winner = -1;
                Tie++;
                Message = messages[3];
            }

            // If there's a winner, hide the buttons to avoid more clicks
            if (winner > 0)
            {
                BtnPos00 = false;
                BtnPos01 = false;
                BtnPos02 = false;
                BtnPos10 = false;
                BtnPos11 = false;
                BtnPos12 = false;
                BtnPos20 = false;
                BtnPos21 = false;
                BtnPos22 = false;
            }

            return winner;
        }

        /// <summary>
        /// Display the buttons, hide the images and clear the board of 1s and 2s
        /// </summary>
        public void NewGame()
        {
            int MAXBOARDSIZE = 3;

            BtnPos00 = true;
            BtnPos01 = true;
            BtnPos02 = true;
            BtnPos10 = true;
            BtnPos11 = true;
            BtnPos12 = true;
            BtnPos20 = true;
            BtnPos21 = true;
            BtnPos22 = true;

            ImgPos00 = false;
            ImgPos01 = false;
            ImgPos02 = false;
            ImgPos10 = false;
            ImgPos11 = false;
            ImgPos12 = false;
            ImgPos20 = false;
            ImgPos21 = false;
            ImgPos22 = false;

            //Clean the board
            for (int i = 0; i < MAXBOARDSIZE; i++)
            {
                for (int j = 0; j < MAXBOARDSIZE; j++)
                {
                    Positions[i, j] = 0;
                }
            }
            // Change the message to START!
            Message = messages[0];
            // Clear the move counter
            isBoardFull = 0;
        }

        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        private void notifyChange([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }


}
