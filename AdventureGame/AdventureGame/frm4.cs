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
    public partial class frm4 : Form
    {
        public frm4()
        {
            InitializeComponent();
        }
        
        private void frm4_Load(object sender, EventArgs e)
        {

        }

  

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "You grow!";
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
          
        }

        private void btnVial_Click(object sender, EventArgs e)
        {
            label1.Text = "You shrink to the size of a mouse!";
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;

            btnDoor.Visible = true; 
        }

      
        
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button2.Visible = true;

            

            
                

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new frm5()).Show();
        }

        private void btnMusic_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    SoundPlayer sndplayr = new
                    SoundPlayer(AdventureGame.Properties.Resources.kingdomheartz);
                    if (btnMusic.Text == "Play Music")
                    {
                        sndplayr.PlayLooping();
                        btnMusic.Text = "STOP";
                    }
                    else
                    {
                        sndplayr.Stop();
                        btnMusic.Text = "Play Music";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ": " + ex.StackTrace.ToString(), "Error");
                }
            }
        }
    }
}
