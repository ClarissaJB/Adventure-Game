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
    public partial class frmStart : Form
    {


        public frmStart()
        {
            InitializeComponent();
        }
        echo "# AdventureGame" >> README.md
git init
git add README.md
git commit -m "first commit"
git remote add origin https://github.com/ClarissaJB/AdventureGame.git
git push -u origin master
        public static string name;
        
        private void btnEnter_Click(object sender, EventArgs e)
        {
            txtName.Text = name;
            pictureforbrosius.Visible = true;


            lblOutput.Text = "Welcome to the game!";
                 
                btnEnter.Visible = false;
         
     
            btnNext1.Visible = true;
            //yells at the player if he picks a bad word for the name
          
        }

     

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new frm2()).Show();
            string realName = name;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            (new frm9()).Show();
        }

        private void btnPlayMusic_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                SoundPlayer sndplayr = new
                SoundPlayer(AdventureGame.Properties.Resources.stardewmines);
                sndplayr.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ": " + ex.StackTrace.ToString(), "Error");
            }
             * */
           
{
    try
    {
        SoundPlayer sndplayr = new
        SoundPlayer(AdventureGame.Properties.Resources.stardewmines); 
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
