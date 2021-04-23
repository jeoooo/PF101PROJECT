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
        bool handlePlayerOTurn = true; //true = o false = x



        public Form1()
        {
            InitializeComponent();

            label_WinnerText.Visible = true;

            
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }



        private void button_grid0_Click(object sender, EventArgs e)
        {
            if (handlePlayerOTurn)
            {
                GameArrayGrid[0] = 1;
                button_grid0.Text = "O";
                button_grid0.Enabled = false;
                handlePlayerOTurn = false;
            }
            else
            {
                GameArrayGrid[0] = -1;
                button_grid0.Text = "X";
                button_grid0.Enabled = false;
                handlePlayerOTurn = true;
            }
            ConsoleCheckGrid();
        }

        private void button_grid1_Click(object sender, EventArgs e)
        {
            if (handlePlayerOTurn)
            {
                GameArrayGrid[1] = 1;
                button_grid1.Text = "O";
                button_grid1.Enabled = false;
                handlePlayerOTurn = false;
            }
            else
            {
                GameArrayGrid[1] = -1;
                button_grid1.Text = "X";
                button_grid1.Enabled = false;
                handlePlayerOTurn = true;
            }
            ConsoleCheckGrid();
        }

        private void button_grid2_Click(object sender, EventArgs e)
        {
            if (handlePlayerOTurn)
            {
                GameArrayGrid[2] = 1;
                button_grid2.Text = "O";
                button_grid2.Enabled = false;
                handlePlayerOTurn = false;
            }
            else
            {
                GameArrayGrid[2] = -1;
                button_grid2.Text = "X";
                button_grid2.Enabled = false;
                handlePlayerOTurn = true;
            }
            ConsoleCheckGrid();
        }

        private void button_grid3_Click(object sender, EventArgs e)
        {
            if (handlePlayerOTurn)
            {
                GameArrayGrid[3] = 1;
                button_grid3.Text = "O";
                button_grid3.Enabled = false;
                handlePlayerOTurn = false;
            }
            else
            {
                GameArrayGrid[3] = -1;
                button_grid3.Text = "X";
                button_grid3.Enabled = false;
                handlePlayerOTurn = true;
            }
            ConsoleCheckGrid();
        }

        private void button_grid4_Click(object sender, EventArgs e)
        {
            if (handlePlayerOTurn)
            {
                GameArrayGrid[4] = 1;
                button_grid4.Text = "O";
                button_grid4.Enabled = false;
                handlePlayerOTurn = false;
            }
            else
            {
                GameArrayGrid[4] = -1;
                button_grid4.Text = "X";
                button_grid4.Enabled = false;
                handlePlayerOTurn = true;
            }
            ConsoleCheckGrid();
        }

        private void button_grid5_Click(object sender, EventArgs e)
        {
            if (handlePlayerOTurn)
            {
                GameArrayGrid[5] = 1;
                button_grid5.Text = "O";
                button_grid5.Enabled = false;
                handlePlayerOTurn = false;
            }
            else
            {
                GameArrayGrid[5] = -1;
                button_grid5.Text = "X";
                button_grid5.Enabled = false;
                handlePlayerOTurn = true;
            }
            ConsoleCheckGrid();
        }

        private void button_grid6_Click(object sender, EventArgs e)
        {
            if (handlePlayerOTurn)
            {
                GameArrayGrid[6] = 1;
                button_grid6.Text = "O";
                button_grid6.Enabled = false;
                handlePlayerOTurn = false;
            }
            else
            {
                GameArrayGrid[6] = -1;
                button_grid6.Text = "X";
                button_grid6.Enabled = false;
                handlePlayerOTurn = true;
            }
            ConsoleCheckGrid();
        }

        private void button_grid7_Click(object sender, EventArgs e)
        {
            if (handlePlayerOTurn)
            {
                GameArrayGrid[7] = 1;
                button_grid7.Text = "O";
                button_grid7.Enabled = false;
                handlePlayerOTurn = false;
            }
            else
            {
                GameArrayGrid[7] = -1;
                button_grid7.Text = "X";
                button_grid7.Enabled = false;
                handlePlayerOTurn = true;
            }
            ConsoleCheckGrid();
        }

        private void button_grid8_Click(object sender, EventArgs e)
        {
            if (handlePlayerOTurn)
            {
                GameArrayGrid[8] = 1;
                button_grid8.Text = "O";
                button_grid8.Enabled = false;
                handlePlayerOTurn = false;
            }
            else
            {
                GameArrayGrid[8] = -1;
                button_grid8.Text = "X";
                button_grid8.Enabled = false;
                handlePlayerOTurn = true;
            }
            ConsoleCheckGrid();
        }


        private void button_StartO_Click(object sender, EventArgs e)
        {
            handlePlayerOTurn = true;
            setButtons();
            enableButtons();
        }

        private void enableButtons()
        {
            button_grid0.Enabled = true;
            button_grid1.Enabled = true;
            button_grid2.Enabled = true;
            button_grid3.Enabled = true;
            button_grid4.Enabled = true;
            button_grid5.Enabled = true;
            button_grid6.Enabled = true;
            button_grid7.Enabled = true;
            button_grid8.Enabled = true;
        }

        private void setButtons()
        {
            for(int i = 0; i < GameArrayGrid.Length; i++)
            {
                GameArrayGrid[i] = 0;
            }

            
            button_grid0.Text = "";
            button_grid1.Text = "";
            button_grid2.Text = "";
            button_grid3.Text = "";
            button_grid4.Text = "";
            button_grid5.Text = "";
            button_grid6.Text = "";
            button_grid7.Text = "";
            button_grid8.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            handlePlayerOTurn = false;
            setButtons();
            enableButtons();
        }

        private void ConsoleCheckGrid()
        {
            Console.WriteLine("[ " + GameArrayGrid[0] + ", " + GameArrayGrid[1] + ", " + GameArrayGrid[2] + "]\n" +
                              "[ " + GameArrayGrid[3] + ", " + GameArrayGrid[4] + ", " + GameArrayGrid[5] + "]\n" +
                              "[ " + GameArrayGrid[6] + ", " + GameArrayGrid[7] + ", " + GameArrayGrid[8] + "]\n");
        }
    }
}
