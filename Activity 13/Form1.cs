using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_13
{
    public partial class Form1 : Form
    {
        //initialize variables
        public int whosTurn;
        public int[,] grid = new int[3, 3];

        private void Form1_Load(object sender, EventArgs e)
        {
            //set player to 1 turn when the form loads
            whosTurn = 1;
        }

        public Form1()
        {
            InitializeComponent();
        }

        //Exit program when the exit button is clicked
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //reset values to null when the reset button is clicked
        private void restart_Click(object sender, EventArgs e)
        {
            //blank out values
            a1.Text = null;
            a2.Text = null;
            a3.Text = null;
            b1.Text = null;
            b2.Text = null;
            b3.Text = null;
            c1.Text = null;
            c2.Text = null;
            c3.Text = null;

            //re-enable buttons
            a1.Enabled = true;
            a2.Enabled = true;
            a3.Enabled = true;
            b1.Enabled = true;
            b2.Enabled = true;
            b3.Enabled = true;
            c1.Enabled = true;
            c2.Enabled = true;
            c3.Enabled = true;

            //reset grid values to 0
            for (int i = 0; i < 3; i++)
            {
                for (int x = 0; x < 3; x++)
                {
                    grid[i, x] = 0;
                }
            }
        }

        private void a1_Click(object sender, EventArgs e)
        {

            //disable button after it has been selected
            a1.Enabled = false;

            //update grid with which player selected which button
            if (whosTurn == 1)
            {
                grid[0, 0] = 1;
                a1.Text = "X";
                whosTurn = 2;
            }
            else
            {
                grid[0, 0] = 2;
                a1.Text = "O";
                whosTurn = 1;
            }
            //run functions to check for a winner 
            CheckRows();
            CheckColumns();
            CheckDiagonals();
        }

        private void a2_Click(object sender, EventArgs e)
        {
            //disable button after it has been selected
            a2.Enabled = false;

            //update grid with which player selected which button
            if (whosTurn == 1)
            {
                grid[0, 1] = 1;
                a2.Text = "X";
                whosTurn = 2;
            }
            else
            {
                grid[0, 1] = 2;
                a2.Text = "O";
                whosTurn = 1;
            }

            //run functions to check for a winner
            CheckRows();
            CheckColumns();
            CheckDiagonals();
        }

        private void a3_Click(object sender, EventArgs e)
        {
            //disable button after it has been selected
            a3.Enabled = false;

            //update grid with which player selected which button
            if (whosTurn == 1)
            {
                grid[0, 2] = 1;
                a3.Text = "X";
                whosTurn = 2;
            }
            else
            {
                grid[0, 2] = 2;
                a3.Text = "O";
                whosTurn = 1;
            }
            //run functions to check for a winner
            CheckRows();
            CheckColumns();
            CheckDiagonals();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            //disable button after it has been selected
            b1.Enabled = false;

            //update grid with which player selected which button
            if (whosTurn == 1)
            {
                grid[1, 0] = 1;
                b1.Text = "X";
                whosTurn = 2;
            }
            else
            {
                grid[1, 0] = 2;
                b1.Text = "O";
                whosTurn = 1;
            }
            //run functions to check for a winner
            CheckRows();
            CheckColumns();
            CheckDiagonals();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            //disable button after it has been selected
            b2.Enabled = false;

            //update grid with which player selected which button
            if (whosTurn == 1)
            {
                grid[1, 1] = 1;
                b2.Text = "X";
                whosTurn = 2;
            }
            else
            {
                grid[1, 1] = 2;
                b2.Text = "O";
                whosTurn = 1;
            }
            //run functions to check for a winner
            CheckRows();
            CheckColumns();
            CheckDiagonals();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            //disable button after it has been selected
            b3.Enabled = false;

            //update grid with which player selected which button
            if (whosTurn == 1)
            {
                grid[1, 2] = 1;
                b3.Text = "X";
                whosTurn = 2;
            }
            else
            {
                grid[1, 2] = 2;
                b3.Text = "O";
                whosTurn = 1;
            }
            //run functions to check for a winner
            CheckRows();
            CheckColumns();
            CheckDiagonals();
        }

        private void c1_Click(object sender, EventArgs e)
        {
            //disable button after it has been selected
            c1.Enabled = false;

            //update grid with which player selected which button
            if (whosTurn == 1)
            {
                grid[2, 0] = 1;
                c1.Text = "X";
                whosTurn = 2;
            }
            else
            {
                grid[2, 0] = 2;
                c1.Text = "O";
                whosTurn = 1;
            }
            //run functions to check for a winner
            CheckRows();
            CheckColumns();
            CheckDiagonals();
        }

        private void c2_Click(object sender, EventArgs e)
        {
            //disable button after it has been selected
            c2.Enabled = false;

            //update grid with which player selected which button
            if (whosTurn == 1)
            {
                grid[2, 1] = 1;
                c2.Text = "X";
                whosTurn = 2;
            }
            else
            {
                grid[2, 1] = 2;
                c2.Text = "O";
                whosTurn = 1;
            }
            //run functions to check for a winner
            CheckRows();
            CheckColumns();
            CheckDiagonals();
        }

        private void c3_Click(object sender, EventArgs e)
        {
            //disable button after it has been selected
            c3.Enabled = false;

            //update grid with which player selected which button     
            if (whosTurn == 1)
            {
                grid[2, 2] = 1;
                c3.Text = "X";
                whosTurn = 2;
            }
            else
            {
                grid[2, 2] = 2;
                c3.Text = "O";
                whosTurn = 1;
            }
            //run functions to check for a winner
            CheckRows();
            CheckColumns();
            CheckDiagonals();

        }

        //checks for 3 matches in each column
        private void CheckColumns()
        {
            int P1Count = 0;
            int P2Count = 0;

            for (int i = 0; i < 3; i++)
            {
                //reset count to 0 after each iteration of the loop
                P1Count = 0;
                P2Count = 0;

                //check columns for 3 matches
                for (int x = 0; x < 3; x++)
                {
                    if (grid[x, i] == 1)
                    {
                        P1Count++;
                    }
                    if (grid[x, i] == 2)
                    {
                        P2Count++;
                    }

                    //if count equals 3 display the winning player
                    if (P1Count == 3)
                    {
                        MessageBox.Show("Player 1 Wins!");
                        break;
                    }
                    if (P2Count == 3)
                    {
                        MessageBox.Show("Player 2 wins!");
                        break;
                    }
                }
            }
        }

        //checks for 3 matches in each diagonal
        private void CheckDiagonals()
        {
            int P1Count = 0;
            int P2Count = 0;
            
            for (int i = 0; i < 3; i++)
            {
                //reset count to 0 after each iteration of the loop
                P1Count = 0;
                P2Count = 0;

                //check diagonals for 3 matches
                for (int x = 0; x < 3; x++)
                {
                    if (i == x && grid[x, i] == 1)
                    {
                        P1Count++;
                    }
                    if (i == x && grid[x, i] == 2)
                    {
                        P2Count++;
                    }

                    //if count equals 3 display the winning player
                    if (P1Count == 3)
                    {
                        MessageBox.Show("Player 1 wins!");
                        break;
                    }

                    if (P2Count == 3)
                    {
                        MessageBox.Show("Player 2 wins!");
                        break;
                    }
                }
            }
        }

        //checks for 3 matches in each diagonal
        private void CheckRows()
        {
            int P1Count = 0;
            int P2Count = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int x = 0; x < 3; x++)
                {
                    if (i == x && grid[x, i] == 1)
                    {
                        P1Count++;
                    }

                    if (i == x && grid[x, i] == 2)
                    {
                        P2Count++;
                    }

                    //if count equals 3 display the winning player
                    if (P1Count == 3)
                    {
                        MessageBox.Show("Player 1 wins!");
                        break;
                    }
                    if (P2Count == 3)
                    {
                        MessageBox.Show("Player 2 wins!");
                    }
                }
            }
        }
    }
}