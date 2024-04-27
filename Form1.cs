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

namespace RealTicTac
{
    public partial class Form1 : Form
    { 
        //empty array, variables and sound player
        string[] board = { "", "", "", "", "", "", "", "", "", };
        int turn = 0;
        bool slurpwin = false;
        bool crownwin = false;
        int pbPicked;
        SoundPlayer boogie = new SoundPlayer(Properties.Resources.Boogie_Down__Fortnite____QuickSounds_com);

        public Form1()
        {
            InitializeComponent();
        }
       
        
        private void pickedBox(object sender, EventArgs e)
        {
            //Identifying box clicked
            turn++;
            PictureBox picked = (PictureBox)sender;
            picked.Enabled = false;
            char[] pbpickedname = picked.Name.ToCharArray();
            pbPicked = int.Parse(pbpickedname[10].ToString());

            //turn distinguishment
            switch (turn % 2)
            {
                case 0:
                    picked.Image = Properties.Resources.slurp;
                    board[pbPicked] = "slurp";
                    whosethewinner();
                    break;
                case 1:
                    picked.Image = Properties.Resources.c2;
                    board[pbPicked] = "crown";
                    whosethewinner();
                    break;

            }
        }

        private void whosethewinner()
        {
            //checkin who makes 3 in a row
            //crown winner 
            if (board[0] == "crown" && board[1] == "crown" && board[2] == "crown")
            {
                MessageBox.Show("The Crowners take Tilted Towers!");
                BtnRetry.Visible = true;
            }
            if (board[3] == "crown" && board[4] == "crown" && board[5] == "crown")
            {
                MessageBox.Show("The Crowners take Tilted Towers!");
                BtnRetry.Visible = true;
            }
            if (board[6] == "crown" && board[7] == "crown" && board[8] == "crown")
            {
                MessageBox.Show("The Crowners take Tilted Towers!");
                BtnRetry.Visible = true;
            }
            if (board[0] == "crown" && board[3] == "crown" && board[6] == "crown")
            {
                MessageBox.Show("The Crowners take Tilted Towers!");
                BtnRetry.Visible = true;
            }
            if (board[1] == "crown" && board[4] == "crown" && board[7] == "crown")
            {
                MessageBox.Show("The Crowners take Tilted Towers!");
                BtnRetry.Visible = true;
            }
            if (board[2] == "crown" && board[5] == "crown" && board[8] == "crown")
            {
                MessageBox.Show("The Crowners take Tilted Towers!");
                BtnRetry.Visible = true;
            }
            if (board[0] == "crown" && board[4] == "crown" && board[8] == "crown")
            {
                MessageBox.Show("The Crowners take Tilted Towers!");
                BtnRetry.Visible = true;
            }
            if (board[2] == "crown" && board[4] == "crown" && board[6] == "crown")
            {
                MessageBox.Show("The Crowners take Tilted Towers!");
                BtnRetry.Visible = true;
            }
            //slurp winner
            if (board[0] == "slurp" && board[1] == "slurp" && board[2] == "slurp")
            {
                MessageBox.Show("The Slurpers take Tilted Towers!");
                BtnRetry.Visible = true;

            }
            if (board[3] == "slurp" && board[4] == "slurp" && board[5] == "slurp")
            {
                MessageBox.Show("The Slurpers take Tilted Towers!");
                BtnRetry.Visible = true;

            }
            if (board[6] == "slurp" && board[7] == "slurp" && board[8] == "slurp")
            {
                MessageBox.Show("The Slurpers take Tilted Towers!");
                BtnRetry.Visible = true;

            }
            if (board[0] == "slurp" && board[3] == "slurp" && board[6] == "slurp")
            {
                MessageBox.Show("The Slurpers take Tilted Towers!");
                BtnRetry.Visible = true;

            }
            if (board[1] == "slurp" && board[4] == "slurp" && board[7] == "slurp")
            {
                MessageBox.Show("The Slurpers take Tilted Towers!");
                BtnRetry.Visible = true;

            }
            if (board[2] == "slurp" && board[5] == "slurp" && board[8] == "slurp")
            {
                MessageBox.Show("The Slurpers take Tilted Towers!");
                BtnRetry.Visible = true;

            }
            if (board[0] == "slurp" && board[4] == "slurp" && board[8] == "slurp")
            {
                MessageBox.Show("The Slurpers take Tilted Towers!");
                BtnRetry.Visible = true;

            }
            if (board[2] == "slurp" && board[4] == "slurp" && board[6] == "slurp")
            {
                MessageBox.Show("The Slurpers take Tilted Towers!");
                BtnRetry.Visible = true;

            }
            if (turn > 9)
            {
                MessageBox.Show("Nobody wins! The battle rages on!");
                BtnRetry.Visible = true;

            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //hid play again button and background music
            BtnRetry.Visible = false;
            boogie.Play();
            
        }

        private void BtnRetry_Click(object sender, EventArgs e)
        {
            //replay ability
            Application.Restart();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //exit button
            Application.Exit();
        }
    }
}
