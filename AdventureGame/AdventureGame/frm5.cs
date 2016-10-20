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
    public partial class frm5 : Form
    {
        public frm5()
        {
            InitializeComponent();
        }

        private void Proceedbtn_Click(object sender, EventArgs e)
        {
            label1.Text = "You remove the snow and dust off the statue.";
            label2.Text = "The Statue is of a young boy holding a ring.";
            label3.Text = "As your examining the remnants of an Old Architect, the bridge begins to crumble and you fall.";
            label4.Text = "Luckily, holding on to the bridge was a good idea, and it broke your fall.";
            label5.Text = "AND the lake is so frozen it can't even crack.";
            label6.Text = "Now, revealing itself to the world, is an old temple across the valley.";
            jumpOffbtn.Visible = false;
            approachBtn.Visible = true;
        }

        private void jumpOffbtn_Click(object sender, EventArgs e)
        {
            label1.Text = "I didn't say you could survive the fall did I? Wow, way to ruin the mood.";
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            startOverbtn.Visible = true;
        }


        private void startOverbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new frmStart()).Show();

        }

        private void btnLoser_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void approachBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Form6()).Show();
        }

        
    }
}
