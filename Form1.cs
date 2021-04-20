using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PF101PROJECT
{
    public partial class Form1 : Form
    {


        int[] GameArrayGrid = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        bool handlePlayerTurn = true; //true = o false = x

        Bitmap circle = Properties.Resources.o_symbol;
        Bitmap cross = Properties.Resources.x_symbol;

        public Form1()
        {
            InitializeComponent();

            InitializeGameState();

        }

        private void InitializeGameState()
        {
            int[] GameArrayGrid = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tictactoe_x00_Click(object sender, EventArgs e)
        {
            if (handlePlayerTurn)
            {
                if (GameArrayGrid[0] == 0)
                {
                    GameArrayGrid[0] = 1;
                    tictactoe_00.Image = circle;
                    handlePlayerTurn = false;
                }
            }
            else
            {
                if (GameArrayGrid[0] == 0)
                {
                    GameArrayGrid[0] = -1;
                    tictactoe_00.Image = cross;
                    handlePlayerTurn = true;
                }
            }
        }

        private void tictactoe_01_Click(object sender, EventArgs e)
        {
            if (handlePlayerTurn)
            {
                if (GameArrayGrid[1] == 0)
                {
                    GameArrayGrid[1] = 1;
                    tictactoe_01.Image = circle;
                    handlePlayerTurn = false;
                }
            }
            else
            {
                if (GameArrayGrid[1] == 0)
                {
                    GameArrayGrid[1] = -1;
                    tictactoe_01.Image = cross;
                    handlePlayerTurn = true;
                }
            }
        }

        private void tictactoe_02_Click(object sender, EventArgs e)
        {
            if (handlePlayerTurn)
            {
                if (GameArrayGrid[2] == 0)
                {
                    GameArrayGrid[2] = 1;
                    tictactoe_02.Image = circle;
                    handlePlayerTurn = false;
                }
            }
            else
            {
                if (GameArrayGrid[2] == 0)
                {
                    GameArrayGrid[2] = -1;
                    tictactoe_02.Image = cross;
                    handlePlayerTurn = true;
                }
            }
            
        }

        private void tictactoe_10_Click(object sender, EventArgs e)
        {
            if (handlePlayerTurn)
            {
                if (GameArrayGrid[3] == 0)
                {
                    GameArrayGrid[3] = 1;
                    tictactoe_10.Image = circle;
                    handlePlayerTurn = false;
                }
            }
            else
            {
                if (GameArrayGrid[3] == 0)
                {
                    GameArrayGrid[3] = -1;
                    tictactoe_10.Image = cross;
                    handlePlayerTurn = true;
                }
            }
        }

        private void tictactoe_11_Click(object sender, EventArgs e)
        {
            if (handlePlayerTurn)
            {
                if (GameArrayGrid[4] == 0)
                {
                    GameArrayGrid[4] = 1;
                    tictactoe_11.Image = circle;
                    handlePlayerTurn = false;
                }
            }
            else
            {
                if (GameArrayGrid[4] == 0)
                {
                    GameArrayGrid[4] = -1;
                    tictactoe_11.Image = cross;
                    handlePlayerTurn = true;
                }
            }
        }

        private void tictactoe_12_Click(object sender, EventArgs e)
        {
            if (handlePlayerTurn)
            {
                if (GameArrayGrid[5] == 0)
                {
                    GameArrayGrid[5] = 1;
                    tictactoe_12.Image = circle;
                    handlePlayerTurn = false;
                }
            }
            else
            {
                if (GameArrayGrid[5] == 0)
                {
                    GameArrayGrid[5] = -1;
                    tictactoe_12.Image = cross;
                    handlePlayerTurn = true;
                }
            }
        }

        private void tictactoe_20_Click(object sender, EventArgs e)
        {
            if (handlePlayerTurn)
            {
                if (GameArrayGrid[6] == 0)
                {
                    GameArrayGrid[6] = 1;
                    tictactoe_20.Image = circle;
                    handlePlayerTurn = false;
                }
            }
            else
            {
                if (GameArrayGrid[6] == 0)
                {
                    GameArrayGrid[6] = -1;
                    tictactoe_20.Image = cross;
                    handlePlayerTurn = true;
                }
            }
        }

        private void tictactoe_21_Click(object sender, EventArgs e)
        {
            if (handlePlayerTurn)
            {
                if (GameArrayGrid[7] == 0)
                {
                    GameArrayGrid[7] = 1;
                    tictactoe_21.Image = circle;
                    handlePlayerTurn = false;
                }
            }
            else
            {
                if (GameArrayGrid[7] == 0)
                {
                    GameArrayGrid[7] = -1;
                    tictactoe_21.Image = cross;
                    handlePlayerTurn = true;
                }
            }
        }

        private void tictactoe_22_Click(object sender, EventArgs e)
        {
            if (handlePlayerTurn)
            {
                if (GameArrayGrid[8] == 0)
                {
                    GameArrayGrid[8] = 1;
                    tictactoe_22.Image = circle;
                    handlePlayerTurn = false;
                }
            }
            else
            {
                if (GameArrayGrid[8] == 0)
                {
                    GameArrayGrid[8] = -1;
                    tictactoe_22.Image = cross;
                    handlePlayerTurn = true;
                }
            }
        }
    }
}
