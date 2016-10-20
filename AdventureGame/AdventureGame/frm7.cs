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
    public partial class frm7 : Form
    {
        public frm7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "A hand shoots out of the door and chokes you to death.";
            label2.Text = "You are very dead now.";
            label3.Visible = false;
            label4.Visible = false;
            btnGiveUp.Visible = true;
            btnStartOver.Visible = false;
            btnStatue.Visible = false;
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

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "You trip over your shoelaces and hit your head on the floor.";
            label2.Text = "You die near instantly of a concussion.";
            label3.Text = "I'm sorry.";
            label4.Visible = false;
            btnGiveUp.Visible = true;
            btnStartOver.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "A loud clanking sound can be heard.";
            label2.Text = "As a huge wall slams down in front of the door you entered through.";
            label3.Text = "Held by a huge chain.";
            label4.Text = "The floor begins to shake.";
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            NEXT.Visible = true;
            btnStatue.Visible = false;
            btnSideDoor.Visible = false;
            
        }

        private void NEXT_Click(object sender, EventArgs e)
        {
                label1.Text = "You look around for some kind of object to defend yourself with.";
                label2.Text = "And on the floor, soaked in water-";
                label3.Text = "Is a sword just perfect for fighting with!";
                label4.Text = "You point your weapon at the sentinel cowardly!";
                label5.Text = "Will you fight, fool?";
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                button3.Visible = true;
                button4.Visible = true;
                NEXT.Visible = false;
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new frm8()).Show();
        }
    }
}
