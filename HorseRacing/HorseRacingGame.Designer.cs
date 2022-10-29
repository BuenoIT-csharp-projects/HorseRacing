namespace HorseRacing
{
    partial class HorseRacingGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HorseRacingGame));
            this.picBackground = new System.Windows.Forms.PictureBox();
            this.pic_horse1 = new System.Windows.Forms.PictureBox();
            this.pic_horse2 = new System.Windows.Forms.PictureBox();
            this.pic_horse3 = new System.Windows.Forms.PictureBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_restart = new System.Windows.Forms.Button();
            this.lbl_winner = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_winnerName = new System.Windows.Forms.Label();
            this.lbl_timingWinner = new System.Windows.Forms.Label();
            this.lbl_timing = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_speedWinner = new System.Windows.Forms.Label();
            this.lbl_speed = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lbl_HorseRacing = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_timing1 = new System.Windows.Forms.Label();
            this.lbl_speed1 = new System.Windows.Forms.Label();
            this.lbl_speed2 = new System.Windows.Forms.Label();
            this.lbl_timing2 = new System.Windows.Forms.Label();
            this.lbl_timing3 = new System.Windows.Forms.Label();
            this.lbl_speed3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_horse1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_horse2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_horse3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // picBackground
            // 
            this.picBackground.Image = ((System.Drawing.Image)(resources.GetObject("picBackground.Image")));
            this.picBackground.Location = new System.Drawing.Point(35, 50);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(678, 614);
            this.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBackground.TabIndex = 0;
            this.picBackground.TabStop = false;
            // 
            // pic_horse1
            // 
            this.pic_horse1.BackColor = System.Drawing.Color.Transparent;
            this.pic_horse1.Image = ((System.Drawing.Image)(resources.GetObject("pic_horse1.Image")));
            this.pic_horse1.Location = new System.Drawing.Point(66, 332);
            this.pic_horse1.Name = "pic_horse1";
            this.pic_horse1.Size = new System.Drawing.Size(45, 36);
            this.pic_horse1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_horse1.TabIndex = 1;
            this.pic_horse1.TabStop = false;
            // 
            // pic_horse2
            // 
            this.pic_horse2.BackColor = System.Drawing.Color.Transparent;
            this.pic_horse2.Image = ((System.Drawing.Image)(resources.GetObject("pic_horse2.Image")));
            this.pic_horse2.Location = new System.Drawing.Point(117, 332);
            this.pic_horse2.Name = "pic_horse2";
            this.pic_horse2.Size = new System.Drawing.Size(46, 36);
            this.pic_horse2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_horse2.TabIndex = 2;
            this.pic_horse2.TabStop = false;
            // 
            // pic_horse3
            // 
            this.pic_horse3.BackColor = System.Drawing.Color.Transparent;
            this.pic_horse3.Image = ((System.Drawing.Image)(resources.GetObject("pic_horse3.Image")));
            this.pic_horse3.Location = new System.Drawing.Point(169, 332);
            this.pic_horse3.Name = "pic_horse3";
            this.pic_horse3.Size = new System.Drawing.Size(49, 36);
            this.pic_horse3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_horse3.TabIndex = 3;
            this.pic_horse3.TabStop = false;
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_start.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_start.ForeColor = System.Drawing.Color.White;
            this.btn_start.Location = new System.Drawing.Point(739, 586);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(95, 40);
            this.btn_start.TabIndex = 4;
            this.btn_start.Text = "START";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_restart
            // 
            this.btn_restart.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_restart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_restart.ForeColor = System.Drawing.Color.White;
            this.btn_restart.Location = new System.Drawing.Point(852, 586);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(95, 40);
            this.btn_restart.TabIndex = 5;
            this.btn_restart.Text = "RESTART";
            this.btn_restart.UseVisualStyleBackColor = false;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // lbl_winner
            // 
            this.lbl_winner.AutoSize = true;
            this.lbl_winner.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_winner.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_winner.ForeColor = System.Drawing.Color.White;
            this.lbl_winner.Location = new System.Drawing.Point(840, 103);
            this.lbl_winner.Name = "lbl_winner";
            this.lbl_winner.Size = new System.Drawing.Size(88, 25);
            this.lbl_winner.TabIndex = 7;
            this.lbl_winner.Text = "Winner :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pictureBox2.Location = new System.Drawing.Point(823, 98);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(291, 36);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_winnerName
            // 
            this.lbl_winnerName.AutoSize = true;
            this.lbl_winnerName.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_winnerName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_winnerName.ForeColor = System.Drawing.Color.White;
            this.lbl_winnerName.Location = new System.Drawing.Point(929, 103);
            this.lbl_winnerName.Name = "lbl_winnerName";
            this.lbl_winnerName.Size = new System.Drawing.Size(0, 25);
            this.lbl_winnerName.TabIndex = 9;
            // 
            // lbl_timingWinner
            // 
            this.lbl_timingWinner.AutoSize = true;
            this.lbl_timingWinner.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_timingWinner.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_timingWinner.ForeColor = System.Drawing.Color.White;
            this.lbl_timingWinner.Location = new System.Drawing.Point(929, 163);
            this.lbl_timingWinner.Name = "lbl_timingWinner";
            this.lbl_timingWinner.Size = new System.Drawing.Size(0, 25);
            this.lbl_timingWinner.TabIndex = 12;
            // 
            // lbl_timing
            // 
            this.lbl_timing.AutoSize = true;
            this.lbl_timing.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_timing.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_timing.ForeColor = System.Drawing.Color.White;
            this.lbl_timing.Location = new System.Drawing.Point(840, 163);
            this.lbl_timing.Name = "lbl_timing";
            this.lbl_timing.Size = new System.Drawing.Size(84, 25);
            this.lbl_timing.TabIndex = 10;
            this.lbl_timing.Text = "Timing :";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pictureBox3.Location = new System.Drawing.Point(823, 158);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(291, 36);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // lbl_speedWinner
            // 
            this.lbl_speedWinner.AutoSize = true;
            this.lbl_speedWinner.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_speedWinner.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_speedWinner.ForeColor = System.Drawing.Color.White;
            this.lbl_speedWinner.Location = new System.Drawing.Point(929, 225);
            this.lbl_speedWinner.Name = "lbl_speedWinner";
            this.lbl_speedWinner.Size = new System.Drawing.Size(0, 25);
            this.lbl_speedWinner.TabIndex = 15;
            // 
            // lbl_speed
            // 
            this.lbl_speed.AutoSize = true;
            this.lbl_speed.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_speed.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_speed.ForeColor = System.Drawing.Color.White;
            this.lbl_speed.Location = new System.Drawing.Point(840, 225);
            this.lbl_speed.Name = "lbl_speed";
            this.lbl_speed.Size = new System.Drawing.Size(77, 25);
            this.lbl_speed.TabIndex = 13;
            this.lbl_speed.Text = "Speed :";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pictureBox4.Location = new System.Drawing.Point(823, 220);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(291, 36);
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // lbl_HorseRacing
            // 
            this.lbl_HorseRacing.AutoSize = true;
            this.lbl_HorseRacing.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_HorseRacing.Location = new System.Drawing.Point(303, 320);
            this.lbl_HorseRacing.Name = "lbl_HorseRacing";
            this.lbl_HorseRacing.Size = new System.Drawing.Size(136, 30);
            this.lbl_HorseRacing.TabIndex = 16;
            this.lbl_HorseRacing.Text = "Horse Racing";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(832, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Horse #";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(943, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Timing";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1052, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Speed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(842, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(842, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(842, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "3";
            // 
            // lbl_timing1
            // 
            this.lbl_timing1.AutoSize = true;
            this.lbl_timing1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_timing1.Location = new System.Drawing.Point(949, 363);
            this.lbl_timing1.Name = "lbl_timing1";
            this.lbl_timing1.Size = new System.Drawing.Size(0, 15);
            this.lbl_timing1.TabIndex = 23;
            this.lbl_timing1.UseMnemonic = false;
            // 
            // lbl_speed1
            // 
            this.lbl_speed1.AutoSize = true;
            this.lbl_speed1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_speed1.Location = new System.Drawing.Point(1052, 363);
            this.lbl_speed1.Name = "lbl_speed1";
            this.lbl_speed1.Size = new System.Drawing.Size(0, 15);
            this.lbl_speed1.TabIndex = 24;
            this.lbl_speed1.UseMnemonic = false;
            // 
            // lbl_speed2
            // 
            this.lbl_speed2.AutoSize = true;
            this.lbl_speed2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_speed2.Location = new System.Drawing.Point(1052, 398);
            this.lbl_speed2.Name = "lbl_speed2";
            this.lbl_speed2.Size = new System.Drawing.Size(0, 15);
            this.lbl_speed2.TabIndex = 25;
            this.lbl_speed2.UseMnemonic = false;
            // 
            // lbl_timing2
            // 
            this.lbl_timing2.AutoSize = true;
            this.lbl_timing2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_timing2.Location = new System.Drawing.Point(949, 398);
            this.lbl_timing2.Name = "lbl_timing2";
            this.lbl_timing2.Size = new System.Drawing.Size(0, 15);
            this.lbl_timing2.TabIndex = 26;
            this.lbl_timing2.UseMnemonic = false;
            // 
            // lbl_timing3
            // 
            this.lbl_timing3.AutoSize = true;
            this.lbl_timing3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_timing3.Location = new System.Drawing.Point(949, 437);
            this.lbl_timing3.Name = "lbl_timing3";
            this.lbl_timing3.Size = new System.Drawing.Size(0, 15);
            this.lbl_timing3.TabIndex = 27;
            this.lbl_timing3.UseMnemonic = false;
            // 
            // lbl_speed3
            // 
            this.lbl_speed3.AutoSize = true;
            this.lbl_speed3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_speed3.Location = new System.Drawing.Point(1052, 437);
            this.lbl_speed3.Name = "lbl_speed3";
            this.lbl_speed3.Size = new System.Drawing.Size(0, 15);
            this.lbl_speed3.TabIndex = 28;
            this.lbl_speed3.UseMnemonic = false;
            // 
            // HorseRacingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1254, 651);
            this.Controls.Add(this.lbl_speed3);
            this.Controls.Add(this.lbl_timing3);
            this.Controls.Add(this.lbl_timing2);
            this.Controls.Add(this.lbl_speed2);
            this.Controls.Add(this.lbl_speed1);
            this.Controls.Add(this.lbl_timing1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_HorseRacing);
            this.Controls.Add(this.lbl_speedWinner);
            this.Controls.Add(this.lbl_speed);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lbl_timingWinner);
            this.Controls.Add(this.lbl_timing);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lbl_winnerName);
            this.Controls.Add(this.lbl_winner);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_restart);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.pic_horse3);
            this.Controls.Add(this.pic_horse2);
            this.Controls.Add(this.pic_horse1);
            this.Controls.Add(this.picBackground);
            this.Name = "HorseRacingGame";
            this.Text = "HorseRacingGame";
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_horse1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_horse2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_horse3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picBackground;
        private PictureBox pic_horse1;
        private PictureBox pic_horse2;
        private PictureBox pic_horse3;
        private Button btn_start;
        private Button btn_restart;
        private Label lbl_winner;
        private PictureBox pictureBox2;
        private Label lbl_winnerName;
        private Label lbl_timingWinner;
        private Label lbl_timing;
        private PictureBox pictureBox3;
        private Label lbl_speedWinner;
        private Label lbl_speed;
        private PictureBox pictureBox4;
        private Label lbl_HorseRacing;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lbl_timing1;
        private Label lbl_speed1;
        private Label lbl_speed2;
        private Label lbl_timing2;
        private Label lbl_timing3;
        private Label lbl_speed3;
    }
}