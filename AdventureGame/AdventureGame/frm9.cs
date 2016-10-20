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
    public partial class frm9 : Form
    {
        public frm9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "You escaped the story.";
            label2.Text = "There's an anticlimatic ending for ya.";
            label3.Text = "BAD END.";
            btnQuit.Visible = true;
            btnTitle.Visible = true;
            btnGrand.Visible = false;
            btnLeave.Visible = false;
            btnInvestigate.Visible = false;
            btnLotusFlower.Visible = false;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            (new frmStart()).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm9_Load(object sender, EventArgs e)
        {

        }

        private void btnGrand_Click(object sender, EventArgs e)
        {
            label1.Text = "The room is dark, all you see is a path to large pressure plate on a round platform.";
            label2.Text = "You proceed. As you step on the plate, a huge glowing circular ring followed by other rings,";
            label3.Text = "Each different colors, surround you and the platform. And then, they all circle in on your right finger.";
            label4.Text = "As you watch in amazement they create a ring of which you can see all the different colors on the world in.";
            label5.Text = "As you are marveling at what hapened, the entire temple begins to shake.";
            label6.Text = "You run out of the temple and turn around and watch as it sinks into the lake.";
            label7.Text = "And then, all you can see is stars...";
            label8.Text = "GOOD END.";
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;

            btnQuit.Visible = true;
            btnTitle.Visible = true;
            btnGrand.Visible = false;
            btnLeave.Visible = false;
            btnInvestigate.Visible = false;
            btnLotusFlower.Visible = false;
        }

        private void btnInvestigate_Click(object sender, EventArgs e)
        {
            label1.Text = "Nothing remains expect the engraving is now more distinguishble.";
            label2.Text = "It appears to be a lotus flower.";
                btnInvestigate.Visible = false;
                btnLotusFlower.Visible = true;
        }

        private void btnLotusFlower_Click(object sender, EventArgs e)
        {
            label1.Text = "A hand shoots out of the floor and chokes you to death.";
                label2.Text = "People die when they are killed. You have been killed. You are now dead.";
                    label3.Text = "And on the last screen of the game too. Impressive.";
                    btnQuit.Visible = true;
                    btnTitle.Visible = true;
                    btnGrand.Visible = false;
                    btnLeave.Visible = false;
                    btnLotusFlower.Visible = false;
        }

        private void btnPlayMusic_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    SoundPlayer sndplayr = new
                    SoundPlayer(AdventureGame.Properties.Resources.finalfan);
                    if (btnPlayMusic.Text == "Play Music")
                    {
                        sndplayr.PlayLooping();
                        btnPlayMusic.Text = "STOP";
                    }
                    else
                    {
                        sndplayr.Stop();
                        btnPlayMusic.Text = "Play Music";
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
