using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureGame
{
    public partial class frm3 : Form
    {
        public frm3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "A cage falls on top of you.";
            label2.Text = "Behind the bars are two buttons, one blue, one red.";
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            btnRed.Visible = true;
            btnBlue.Visible = true;
            btnPull.Visible = false;

        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            label1.Text = "The cage rises into the ceilling,";
            label2.Text = "And the door opens to a room with a small chest.";
            btnOpen.Visible = true;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            label1.Text = "SUDDEN GAME OVER, GAME OVER MAN";
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            btnStartOver.Visible = true;
            btnGiveUp.Visible = true;

        }

        private void btnStartOver_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new frmStart()).Show();
        }

        private void btnGiveUp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new frm4()).Show();
        }
    }
}
