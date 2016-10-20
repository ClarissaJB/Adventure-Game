namespace AdventureGame
{
    partial class frmStart
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnPlayMusic = new System.Windows.Forms.Button();
            this.btnNext1 = new System.Windows.Forms.Button();
            this.pictureforbrosius = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureforbrosius)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(106, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENTER A NAME TO BEGIN";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(250, 170);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 1;
            this.btnEnter.Text = "ENTER";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(223, 135);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(208, 20);
            this.txtName.TabIndex = 2;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOutput.Location = new System.Drawing.Point(220, 91);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 16);
            this.lblOutput.TabIndex = 3;
            // 
            // btnPlayMusic
            // 
            this.btnPlayMusic.BackColor = System.Drawing.Color.Green;
            this.btnPlayMusic.Location = new System.Drawing.Point(451, 132);
            this.btnPlayMusic.Name = "btnPlayMusic";
            this.btnPlayMusic.Size = new System.Drawing.Size(75, 23);
            this.btnPlayMusic.TabIndex = 5;
            this.btnPlayMusic.Text = "Play Music";
            this.btnPlayMusic.UseVisualStyleBackColor = false;
            this.btnPlayMusic.Click += new System.EventHandler(this.btnPlayMusic_Click);
            // 
            // btnNext1
            // 
            this.btnNext1.Location = new System.Drawing.Point(331, 170);
            this.btnNext1.Name = "btnNext1";
            this.btnNext1.Size = new System.Drawing.Size(75, 23);
            this.btnNext1.TabIndex = 7;
            this.btnNext1.Text = "NEXT";
            this.btnNext1.UseVisualStyleBackColor = true;
            this.btnNext1.Visible = false;
            this.btnNext1.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pictureforbrosius
            // 
            this.pictureforbrosius.Image = global::AdventureGame.Properties.Resources.aPictureForBrosius;
            this.pictureforbrosius.Location = new System.Drawing.Point(191, 199);
            this.pictureforbrosius.Name = "pictureforbrosius";
            this.pictureforbrosius.Size = new System.Drawing.Size(300, 335);
            this.pictureforbrosius.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureforbrosius.TabIndex = 8;
            this.pictureforbrosius.TabStop = false;
            this.pictureforbrosius.Visible = false;
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(587, 379);
            this.Controls.Add(this.pictureforbrosius);
            this.Controls.Add(this.btnNext1);
            this.Controls.Add(this.btnPlayMusic);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.label1);
            this.Name = "frmStart";
            this.Text = "Adventure Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureforbrosius)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnPlayMusic;
        private System.Windows.Forms.Button btnNext1;
        private System.Windows.Forms.PictureBox pictureforbrosius;
    }
}

