using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

using System.Media;

namespace AdventureGame
{
    public partial class frm2 : Form
    {
        public frm2()
        {
            InitializeComponent();
        }
        String correct;
        int failure;

        private void btnEnter_Click(object sender, EventArgs e)
        {
            String correct = txtEnter.Text;
            failure = failure + 1; 

            if (correct == "BLUE, RED, YELLOW, PURPLE, GREEN")
            {
                lbl1.Text = "You did it! Press NEXT to continue!";
                lbl2.Visible = false;
                lbl3.Visible = false;
                lbl4.Visible = false;
                lbl5.Visible = false;
                label1.Visible = false;

                btNext.Visible = true;                
            }
                if (correct == "This is stupid.")
                {
                    lbl1.Text = "I agree! Please press next to continue.";
                    lbl2.Visible = false;
                    lbl3.Visible = false;
                    lbl4.Visible = false;
                    lbl5.Visible = false;
                    label1.Visible = false;
                    btNext.Visible = true;  
                }
            else
            {
                lbl1.Text = "Now why would that make any sense?";
                lbl2.Visible = false;
                lbl3.Visible = false;
                lbl4.Visible = false;
                lbl5.Visible = false;
                label1.Visible = false;

                btnRetry.Visible = true;
            }
            if (failure == 5)
            {
                lbl1.Text = "You have taken too long and spotaneously combust. ";
                lbl2.Visible = true;
                lbl3.Visible = true;
                lbl2.Text = "This task is an impossible one, but I believe in you.";
                lbl3.Text = "If you are more honest with your feelings, perhaps you'll get it.";
                lbl4.Visible = false;
                lbl5.Visible = false;
                button1.Visible = true;
                button2.Visible = true;
                btnRetry.Visible = false;
                btnEnter.Visible = false; 

            }
        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            lbl1.Text = "You awake in a room on a bed.";
            lbl2.Visible = true;
            lbl3.Visible = true;
            lbl4.Visible = true;
            lbl5.Visible = true;
            label1.Visible = true;
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new frm3()).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new frm2()).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        }
    }

