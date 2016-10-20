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
    public partial class frm8 : Form
    {
        public frm8()
        {
            InitializeComponent();
        }
      

       int enemyHP = 20;
       int yourHP = 20;
 
       
        private void button4_Click(object sender, EventArgs e)
        {
            labelYou.Text = "You don't know magic, you twit! Nothing happens.";
            labelEnemy.Text = " ";
            btnSafe.Visible = false;
            btnRisky.Visible = false;
            btnRest.Visible = false;
            btnMagic.Visible = false;
            btnEnemyTurn.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random ranNumberGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(1, 10);

            if (randomNumber == 1)
            {
                labelEnemy.Text = "The enemy swings the sword right on your head, killing you instantly.";
                labelYou.Text = "People die when they are killed. You are now dead.";
                lblYourHP.Text = " " + yourHP;
                btnStartOver.Visible = true;
                btnGiveUp.Visible = true;
                btnSafe.Visible = false;
                btnRisky.Visible = false;
                btnMagic.Visible = false;
                btnRest.Visible = false;
                yourHP = 0;
                lblYourHP.Text = " " + yourHP;
            }
            if (randomNumber == 2)
            {
                labelEnemy.Text = "He taps you lightly with with the sword.";
                labelYou.Text = "Lose one health!";
                yourHP = yourHP - 1;
                lblYourHP.Text = " " + yourHP;
            }
            if (randomNumber == 3)
            {
                labelEnemy.Text = "He taps you lightly with with the sword.";
                labelYou.Text = "Lose one health!";
                yourHP = yourHP - 1;
                lblYourHP.Text = " " + yourHP;
            }
            if (randomNumber == 4)
            {
                labelEnemy.Text = "He taps you lightly with with the sword.";
                labelYou.Text = "Lose one health!";
                yourHP = yourHP - 1;
                lblYourHP.Text = " " + yourHP;
            }
            if (randomNumber == 5)
            {
                labelEnemy.Text = "He taps you lightly with with the sword.";
                labelYou.Text = "Lose one health!";
                yourHP = yourHP - 1;
                lblYourHP.Text = " " + yourHP;
            }
            if (randomNumber == 6)
            {
                labelEnemy.Text = "He swings the sword widely, hitting you quite hard.";
                labelYou.Text = "Lose two health!";

                yourHP = yourHP - 2;
                lblYourHP.Text = " " + yourHP;
            }
            if (randomNumber == 7)
            {
                labelEnemy.Text = "He swings the sword widely, hitting you quite hard.";
                labelYou.Text = "Lose two health!";
                yourHP = yourHP - 2;
                lblYourHP.Text = " " + yourHP;
            }
            if (randomNumber == 8)
            {
                labelEnemy.Text = "He swings the sword widely, hitting you quite hard.";
                labelYou.Text = "Lose two health!";
                yourHP = yourHP - 2;
                lblYourHP.Text = " " + yourHP;
            }
            if (randomNumber == 9)
            {
                labelEnemy.Text = "He swings the sword widely, hitting you quite hard.";
                labelYou.Text = "Lose two health!";
                yourHP = yourHP - 2;
                lblYourHP.Text = " " + yourHP;
            }
            if (randomNumber == 10)
            {
                labelEnemy.Text = "He swings too hard and stumbles on his feet! Miss!";
                labelYou.Text = "Lose no health!";
                yourHP = yourHP - 2;
                lblYourHP.Text = " " + yourHP;
            }
            if (yourHP >= 0)
            {
                btnSafe.Visible = true;
                btnRisky.Visible = true;
                btnMagic.Visible = true;
                btnRest.Visible = true;
                btnEnemyTurn.Visible = false;
            }
            if (yourHP <= 0)
            {
                labelYou.Text = "You have no health. The sentinel has killed you. You are now dead.";
                btnSafe.Visible = false;
                btnRisky.Visible = false;
                btnMagic.Visible = false;
                btnRest.Visible = false;
                btnEnemyTurn.Visible = false;

                btnStartOver.Visible = true;
                btnGiveUp.Visible = true;

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            yourHP = yourHP + 2;
            lblYourHP.Text = " " + yourHP;
            labelEnemy.Text = "You sit down and take a rest. The enemy ignores you for some reason.";
                labelYou.Text = "You gain two health!";
            btnSafe.Visible = false;
            btnRisky.Visible = false;
            btnMagic.Visible = false;
            btnRest.Visible = false;
            btnEnemyTurn.Visible = true;
            
        }


        private void btnSafe_Click(object sender, EventArgs e)
        {

            Random ranNumberGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(1, 10);

            if (randomNumber == 1)
            {
                labelEnemy.Text = "You swing your sword at the enemy, tapping him lightly.";
                labelYou.Text = "One damage has been done!";
                enemyHP = enemyHP - 1;
                lblEnemyHP.Text = " " + enemyHP;
            }
            if (randomNumber == 2)
            {
                labelEnemy.Text = "You swing your sword at the enemy, tapping him lightly.";
                labelYou.Text = "One damage has been done!";
                enemyHP = enemyHP - 1;
                lblEnemyHP.Text = " " + enemyHP;
            }
            if (randomNumber == 3)
            {
                labelEnemy.Text = "You swing your sword at the enemy, tapping him lightly.";
                labelYou.Text = "One damage has been done!";
                enemyHP = enemyHP - 1;
                lblEnemyHP.Text = " " + enemyHP;
            }
            if (randomNumber == 4)
            {
                labelEnemy.Text = "You swing your sword at the enemy, tapping him lightly.";
                labelYou.Text = "One damage has been done!";
                enemyHP = enemyHP - 1;
                lblEnemyHP.Text = " " + enemyHP;
            }
            if (randomNumber == 5)
            {
                labelEnemy.Text = "You swing your sword at the enemy, tapping him lightly.";
                labelYou.Text = "One damage has been done!";
                enemyHP = enemyHP - 1;
                lblEnemyHP.Text = " " + enemyHP;
            }
            if (randomNumber == 6)
            {
                labelEnemy.Text = "You swing your sword at the enemy, tapping him lightly.";
                labelYou.Text = "One damage has been done!";
                enemyHP = enemyHP - 1;
                lblEnemyHP.Text = " " + enemyHP;
            }
            if (randomNumber == 7)
            {
                labelEnemy.Text = "You swing your sword at the enemy, tapping him lightly.";
                labelYou.Text = "One damage has been done!";
                enemyHP = enemyHP - 1;
                lblEnemyHP.Text = " " + enemyHP;
            }
            if (randomNumber == 8)
            {
                labelEnemy.Text = "You swing your sword at the enemy, tapping him lightly.";
                labelYou.Text = "One damage has been done!";
                enemyHP = enemyHP - 1;
                lblEnemyHP.Text = " " + enemyHP;
            }
            if (randomNumber == 9)
            {
                labelEnemy.Text = "You swing your sword at the enemy, and hit him right in the funny bone.";
                labelYou.Text = "Critical hit! Two damage has been done!";
                enemyHP = enemyHP - 2;
                lblEnemyHP.Text = " " + enemyHP;
            }
            if (randomNumber == 10)
            {
                labelEnemy.Text = "You swing your sword at the enemy, and fall on your feet.";
                labelYou.Text = "MISS!";

            }
            if (enemyHP <= 0)
            {
                labelYou.Text = "The enemy falls to the ground! HE HAS BEEN KILLED! CONGRAGULATIONS!";
                btnEnemyTurn.Visible = false;
                btnSafe.Visible = false;
                btnRisky.Visible = false;
                btnMagic.Visible = false;
                btnRest.Visible = false;
                btnNEXT.Visible = true;

            }
            if (yourHP >= 0)
            {
                btnEnemyTurn.Visible = true;
                btnSafe.Visible = false;
                btnRisky.Visible = false;
                btnMagic.Visible = false;
                btnRest.Visible = false;
            }
            if (yourHP <= 0)
            {
                labelYou.Text = "You have no health. The sentinel has killed you. You are now dead.";
                btnStartOver.Visible = true;
                btnGiveUp.Visible = true;

            }

        }

        private void btnRisky_Click(object sender, EventArgs e)
        {
           
        }

     

        private void btnGiveUp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRisky_Click_1(object sender, EventArgs e)
        {
         
            Random ranNumberGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(1, 7);

            if (randomNumber == 1)
            {
                labelEnemy.Text = "You swing the sword at the enemy and hit him right in the funny bone!";
                labelYou.Text = "Critical hit! Two damage has been done!";
                enemyHP = enemyHP - 2;
                lblEnemyHP.Text = " " + enemyHP;
            }
            if (randomNumber == 2)
            {
                labelEnemy.Text = "You swing the sword at the enemy and hit him right in the funny bone!";
                labelYou.Text = "Critical hit! Two damage has been done!";
                enemyHP = enemyHP - 2;
                lblEnemyHP.Text = " " + enemyHP;
            }
            if (randomNumber == 3)
            {
                labelEnemy.Text = "You swing your sword at the enemy, drop it, and it slices your knee!";
                labelYou.Text = "One damage has been done- TO YOU!!";
                enemyHP = enemyHP - 1;
                lblEnemyHP.Text = " " + enemyHP;
            }
            if (randomNumber == 7)
            {
                labelEnemy.Text = "You swing your sword at the enemy, drop it, and it slices your knee!";
                labelYou.Text = "One damage has been done- TO YOU!!";
                enemyHP = enemyHP - 1;
                lblEnemyHP.Text = " " + enemyHP;
            }
            if (randomNumber == 4)
            {
                labelEnemy.Text = "You swing your sword at the enemy- AND MISS!";
                labelYou.Text = "No damage was done!";

            }
            if (randomNumber == 5)
            {
                labelEnemy.Text = "You swing your sword at the enemy, tapping him lightly.";
                labelYou.Text = "SUPER CRITICAL HIT! Four damage has been done!";
                enemyHP = enemyHP - 4;
                lblEnemyHP.Text = " " + enemyHP;
            }
            if (randomNumber == 6)
            {
                labelEnemy.Text = "You swing your sword at the enemy, tapping him lightly.";
                labelYou.Text = "SUPER CRITICAL HIT! Four damage has been done!";
                enemyHP = enemyHP - 4;
                lblEnemyHP.Text = " " + enemyHP;
            }
            if (enemyHP <= 0)
            {
                labelYou.Text = "The enemy falls to the ground! HE HAS BEEN KILLED! CONGRAGULATIONS!";
                btnEnemyTurn.Visible = false;
                btnSafe.Visible = false;
                btnRisky.Visible = false;
                btnMagic.Visible = false;
                btnRest.Visible = false;
                btnNEXT.Visible = true;

            }
            if (yourHP >= 0)
            {
                btnEnemyTurn.Visible = true;
                btnSafe.Visible = false;
                btnRisky.Visible = false;
                btnMagic.Visible = false;
                btnRest.Visible = false;
            }
            if (yourHP <= 0)
            {
                labelYou.Text = "You have no health. The sentinel has killed you. You are now dead.";
                btnStartOver.Visible = true;
                btnGiveUp.Visible = true;

            }
        }

        private void btnStartOver_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            (new frmStart()).Show();
        }

        private void btnNEXT_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new frm9()).Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            {
                try
                {
                    SoundPlayer sndplayr = new
                    SoundPlayer(AdventureGame.Properties.Resources.pokmon);
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
