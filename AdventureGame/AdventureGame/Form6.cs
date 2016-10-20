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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new frm7()).Show();
        }

        private void btnGiveUp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStartOver_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new frmStart()).Show();
        }

        private void btnGrand_Click(object sender, EventArgs e)
        {
            label1.Text = "A hand shoots out of the door and chokes you to death.";
            label2.Text = "You are very dead now.";
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            btnGiveUp.Visible = true;
            btnStartOver.Visible = true;
            btnSide.Visible = false;

        }

        private void btnSide_Click(object sender, EventArgs e)
        {
            label1.Text = "The door opens to a round room.";
            label2.Text = "With a strange engraving on the floor.";
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            btnNext.Visible = true;
            btnGrand.Visible = true;
        }
    }
}
