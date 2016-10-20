namespace AdventureGame
{
    partial class frm8
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEnemyHP = new System.Windows.Forms.Label();
            this.lblYourHP = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelEnemy = new System.Windows.Forms.Label();
            this.btnSafe = new System.Windows.Forms.Button();
            this.btnRisky = new System.Windows.Forms.Button();
            this.btnMagic = new System.Windows.Forms.Button();
            this.labelYou = new System.Windows.Forms.Label();
            this.btnEnemyTurn = new System.Windows.Forms.Button();
            this.btnStartOver = new System.Windows.Forms.Button();
            this.btnGiveUp = new System.Windows.Forms.Button();
            this.btnRest = new System.Windows.Forms.Button();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btnNEXT = new System.Windows.Forms.Button();
            this.btnPlayMusic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(223, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "FIGHT!!!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(61, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "YOUR HP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "OPPONENT\'S HP:";
            // 
            // lblEnemyHP
            // 
            this.lblEnemyHP.AutoSize = true;
            this.lblEnemyHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyHP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEnemyHP.Location = new System.Drawing.Point(139, 77);
            this.lblEnemyHP.Name = "lblEnemyHP";
            this.lblEnemyHP.Size = new System.Drawing.Size(22, 16);
            this.lblEnemyHP.TabIndex = 3;
            this.lblEnemyHP.Text = "20";
            // 
            // lblYourHP
            // 
            this.lblYourHP.AutoSize = true;
            this.lblYourHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourHP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblYourHP.Location = new System.Drawing.Point(139, 112);
            this.lblYourHP.Name = "lblYourHP";
            this.lblYourHP.Size = new System.Drawing.Size(22, 16);
            this.lblYourHP.TabIndex = 4;
            this.lblYourHP.Text = "20";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(167, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "/20";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(167, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "/20";
            // 
            // labelEnemy
            // 
            this.labelEnemy.AutoSize = true;
            this.labelEnemy.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEnemy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnemy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelEnemy.Location = new System.Drawing.Point(12, 146);
            this.labelEnemy.Name = "labelEnemy";
            this.labelEnemy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelEnemy.Size = new System.Drawing.Size(400, 16);
            this.labelEnemy.TabIndex = 7;
            this.labelEnemy.Text = "The sentinel stands in front of you, looming! WHAT WILL YOU DO?";
            // 
            // btnSafe
            // 
            this.btnSafe.Location = new System.Drawing.Point(73, 257);
            this.btnSafe.Name = "btnSafe";
            this.btnSafe.Size = new System.Drawing.Size(91, 23);
            this.btnSafe.TabIndex = 8;
            this.btnSafe.Text = "SAFE ATTACK";
            this.btnSafe.UseVisualStyleBackColor = true;
            this.btnSafe.Click += new System.EventHandler(this.btnSafe_Click);
            // 
            // btnRisky
            // 
            this.btnRisky.Location = new System.Drawing.Point(170, 257);
            this.btnRisky.Name = "btnRisky";
            this.btnRisky.Size = new System.Drawing.Size(101, 23);
            this.btnRisky.TabIndex = 9;
            this.btnRisky.Text = "RISKY ATTACK";
            this.btnRisky.UseVisualStyleBackColor = true;
            this.btnRisky.Click += new System.EventHandler(this.btnRisky_Click_1);
            // 
            // btnMagic
            // 
            this.btnMagic.Location = new System.Drawing.Point(278, 257);
            this.btnMagic.Name = "btnMagic";
            this.btnMagic.Size = new System.Drawing.Size(75, 23);
            this.btnMagic.TabIndex = 11;
            this.btnMagic.Text = "USE MAGIC";
            this.btnMagic.UseVisualStyleBackColor = true;
            this.btnMagic.Click += new System.EventHandler(this.button4_Click);
            // 
            // labelYou
            // 
            this.labelYou.AutoSize = true;
            this.labelYou.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelYou.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYou.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelYou.Location = new System.Drawing.Point(12, 173);
            this.labelYou.Name = "labelYou";
            this.labelYou.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelYou.Size = new System.Drawing.Size(0, 16);
            this.labelYou.TabIndex = 12;
            // 
            // btnEnemyTurn
            // 
            this.btnEnemyTurn.Location = new System.Drawing.Point(226, 226);
            this.btnEnemyTurn.Name = "btnEnemyTurn";
            this.btnEnemyTurn.Size = new System.Drawing.Size(106, 23);
            this.btnEnemyTurn.TabIndex = 13;
            this.btnEnemyTurn.Text = "ENEMY TURN";
            this.btnEnemyTurn.UseVisualStyleBackColor = true;
            this.btnEnemyTurn.Visible = false;
            this.btnEnemyTurn.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStartOver
            // 
            this.btnStartOver.Location = new System.Drawing.Point(170, 294);
            this.btnStartOver.Name = "btnStartOver";
            this.btnStartOver.Size = new System.Drawing.Size(110, 23);
            this.btnStartOver.TabIndex = 14;
            this.btnStartOver.Text = "START OVER?";
            this.btnStartOver.UseVisualStyleBackColor = true;
            this.btnStartOver.Visible = false;
            this.btnStartOver.Click += new System.EventHandler(this.btnStartOver_Click_1);
            // 
            // btnGiveUp
            // 
            this.btnGiveUp.Location = new System.Drawing.Point(293, 294);
            this.btnGiveUp.Name = "btnGiveUp";
            this.btnGiveUp.Size = new System.Drawing.Size(110, 23);
            this.btnGiveUp.TabIndex = 15;
            this.btnGiveUp.Text = "GIVE UP?";
            this.btnGiveUp.UseVisualStyleBackColor = true;
            this.btnGiveUp.Visible = false;
            // 
            // btnRest
            // 
            this.btnRest.Location = new System.Drawing.Point(359, 257);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(91, 23);
            this.btnRest.TabIndex = 16;
            this.btnRest.Text = "REST";
            this.btnRest.UseVisualStyleBackColor = true;
            this.btnRest.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnNEXT
            // 
            this.btnNEXT.Location = new System.Drawing.Point(433, 294);
            this.btnNEXT.Name = "btnNEXT";
            this.btnNEXT.Size = new System.Drawing.Size(75, 23);
            this.btnNEXT.TabIndex = 17;
            this.btnNEXT.Text = "NEXT";
            this.btnNEXT.UseVisualStyleBackColor = true;
            this.btnNEXT.Visible = false;
            this.btnNEXT.Click += new System.EventHandler(this.btnNEXT_Click);
            // 
            // btnPlayMusic
            // 
            this.btnPlayMusic.Location = new System.Drawing.Point(399, 12);
            this.btnPlayMusic.Name = "btnPlayMusic";
            this.btnPlayMusic.Size = new System.Drawing.Size(92, 23);
            this.btnPlayMusic.TabIndex = 18;
            this.btnPlayMusic.Text = "NEW MUSIC?";
            this.btnPlayMusic.UseVisualStyleBackColor = true;
            this.btnPlayMusic.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // frm8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(520, 329);
            this.Controls.Add(this.btnPlayMusic);
            this.Controls.Add(this.btnNEXT);
            this.Controls.Add(this.btnRest);
            this.Controls.Add(this.btnGiveUp);
            this.Controls.Add(this.btnStartOver);
            this.Controls.Add(this.btnEnemyTurn);
            this.Controls.Add(this.labelYou);
            this.Controls.Add(this.btnMagic);
            this.Controls.Add(this.btnRisky);
            this.Controls.Add(this.btnSafe);
            this.Controls.Add(this.labelEnemy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblYourHP);
            this.Controls.Add(this.lblEnemyHP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm8";
            this.Text = "frm8";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEnemyHP;
        private System.Windows.Forms.Label lblYourHP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelEnemy;
        private System.Windows.Forms.Button btnSafe;
        private System.Windows.Forms.Button btnRisky;
        private System.Windows.Forms.Button btnMagic;
        private System.Windows.Forms.Label labelYou;
        private System.Windows.Forms.Button btnEnemyTurn;
        private System.Windows.Forms.Button btnStartOver;
        private System.Windows.Forms.Button btnGiveUp;
        private System.Windows.Forms.Button btnRest;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.Button btnNEXT;
        private System.Windows.Forms.Button btnPlayMusic;
    }
}