
namespace RabbitRace_Game
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.jugraj_bettor = new System.Windows.Forms.RadioButton();
            this.simon_bettor = new System.Windows.Forms.RadioButton();
            this.Harmen_bettor = new System.Windows.Forms.RadioButton();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.rabbit1_selec = new System.Windows.Forms.RadioButton();
            this.rabbit2_selc = new System.Windows.Forms.RadioButton();
            this.rabbit3_selec = new System.Windows.Forms.RadioButton();
            this.rabbit4_selec = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.simon_label = new System.Windows.Forms.Label();
            this.label_harmen = new System.Windows.Forms.Label();
            this.btnRce = new System.Windows.Forms.Button();
            this.Jugraj_label = new System.Windows.Forms.Label();
            this.btnLockBet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAAmount = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.groupBox1.Controls.Add(this.groupBox9);
            this.groupBox1.Controls.Add(this.groupBox8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.simon_label);
            this.groupBox1.Controls.Add(this.label_harmen);
            this.groupBox1.Controls.Add(this.btnRce);
            this.groupBox1.Controls.Add(this.Jugraj_label);
            this.groupBox1.Controls.Add(this.btnLockBet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbAAmount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 508);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Race Betting Area";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.jugraj_bettor);
            this.groupBox9.Controls.Add(this.simon_bettor);
            this.groupBox9.Controls.Add(this.Harmen_bettor);
            this.groupBox9.Location = new System.Drawing.Point(6, 58);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(140, 145);
            this.groupBox9.TabIndex = 65;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Player Selector";
            // 
            // jugraj_bettor
            // 
            this.jugraj_bettor.AutoSize = true;
            this.jugraj_bettor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.jugraj_bettor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jugraj_bettor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.jugraj_bettor.Location = new System.Drawing.Point(23, 19);
            this.jugraj_bettor.Name = "jugraj_bettor";
            this.jugraj_bettor.Size = new System.Drawing.Size(84, 28);
            this.jugraj_bettor.TabIndex = 47;
            this.jugraj_bettor.TabStop = true;
            this.jugraj_bettor.Text = "Jugraj ";
            this.jugraj_bettor.UseVisualStyleBackColor = false;
            this.jugraj_bettor.CheckedChanged += new System.EventHandler(this.jugraj_bettor_CheckedChanged);
            // 
            // simon_bettor
            // 
            this.simon_bettor.AutoSize = true;
            this.simon_bettor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.simon_bettor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simon_bettor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.simon_bettor.Location = new System.Drawing.Point(23, 56);
            this.simon_bettor.Name = "simon_bettor";
            this.simon_bettor.Size = new System.Drawing.Size(82, 28);
            this.simon_bettor.TabIndex = 48;
            this.simon_bettor.TabStop = true;
            this.simon_bettor.Text = "Simon";
            this.simon_bettor.UseVisualStyleBackColor = false;
            this.simon_bettor.CheckedChanged += new System.EventHandler(this.simon_bettor_CheckedChanged);
            // 
            // Harmen_bettor
            // 
            this.Harmen_bettor.AutoSize = true;
            this.Harmen_bettor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Harmen_bettor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Harmen_bettor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Harmen_bettor.Location = new System.Drawing.Point(23, 92);
            this.Harmen_bettor.Name = "Harmen_bettor";
            this.Harmen_bettor.Size = new System.Drawing.Size(96, 28);
            this.Harmen_bettor.TabIndex = 49;
            this.Harmen_bettor.TabStop = true;
            this.Harmen_bettor.Text = "Harmen";
            this.Harmen_bettor.UseVisualStyleBackColor = false;
            this.Harmen_bettor.CheckedChanged += new System.EventHandler(this.Harmen_bettor_CheckedChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.rabbit1_selec);
            this.groupBox8.Controls.Add(this.rabbit2_selc);
            this.groupBox8.Controls.Add(this.rabbit3_selec);
            this.groupBox8.Controls.Add(this.rabbit4_selec);
            this.groupBox8.Location = new System.Drawing.Point(198, 50);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(146, 157);
            this.groupBox8.TabIndex = 64;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Rabbit Select";
            // 
            // rabbit1_selec
            // 
            this.rabbit1_selec.AutoSize = true;
            this.rabbit1_selec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rabbit1_selec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rabbit1_selec.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rabbit1_selec.Location = new System.Drawing.Point(19, 19);
            this.rabbit1_selec.Name = "rabbit1_selec";
            this.rabbit1_selec.Size = new System.Drawing.Size(96, 28);
            this.rabbit1_selec.TabIndex = 50;
            this.rabbit1_selec.TabStop = true;
            this.rabbit1_selec.Text = "Rabbit 1";
            this.rabbit1_selec.UseVisualStyleBackColor = false;
            this.rabbit1_selec.CheckedChanged += new System.EventHandler(this.rabbit1_selec_CheckedChanged);
            // 
            // rabbit2_selc
            // 
            this.rabbit2_selc.AutoSize = true;
            this.rabbit2_selc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rabbit2_selc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rabbit2_selc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rabbit2_selc.Location = new System.Drawing.Point(19, 53);
            this.rabbit2_selc.Name = "rabbit2_selc";
            this.rabbit2_selc.Size = new System.Drawing.Size(96, 28);
            this.rabbit2_selc.TabIndex = 52;
            this.rabbit2_selc.TabStop = true;
            this.rabbit2_selc.Text = "Rabbit 2";
            this.rabbit2_selc.UseVisualStyleBackColor = false;
            this.rabbit2_selc.CheckedChanged += new System.EventHandler(this.rabbit2_selc_CheckedChanged);
            // 
            // rabbit3_selec
            // 
            this.rabbit3_selec.AutoSize = true;
            this.rabbit3_selec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rabbit3_selec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rabbit3_selec.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rabbit3_selec.Location = new System.Drawing.Point(19, 87);
            this.rabbit3_selec.Name = "rabbit3_selec";
            this.rabbit3_selec.Size = new System.Drawing.Size(96, 28);
            this.rabbit3_selec.TabIndex = 51;
            this.rabbit3_selec.TabStop = true;
            this.rabbit3_selec.Text = "Rabbit 3";
            this.rabbit3_selec.UseVisualStyleBackColor = false;
            this.rabbit3_selec.CheckedChanged += new System.EventHandler(this.rabbit3_selec_CheckedChanged);
            // 
            // rabbit4_selec
            // 
            this.rabbit4_selec.AutoSize = true;
            this.rabbit4_selec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rabbit4_selec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rabbit4_selec.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rabbit4_selec.Location = new System.Drawing.Point(19, 121);
            this.rabbit4_selec.Name = "rabbit4_selec";
            this.rabbit4_selec.Size = new System.Drawing.Size(96, 28);
            this.rabbit4_selec.TabIndex = 60;
            this.rabbit4_selec.TabStop = true;
            this.rabbit4_selec.Text = "Rabbit 4";
            this.rabbit4_selec.UseVisualStyleBackColor = false;
            this.rabbit4_selec.CheckedChanged += new System.EventHandler(this.rabbit4_selec_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LemonChiffon;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(108, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 24);
            this.label7.TabIndex = 63;
            this.label7.Text = "Score Screen";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // simon_label
            // 
            this.simon_label.AutoSize = true;
            this.simon_label.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simon_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.simon_label.Location = new System.Drawing.Point(19, 343);
            this.simon_label.Name = "simon_label";
            this.simon_label.Size = new System.Drawing.Size(303, 24);
            this.simon_label.TabIndex = 62;
            this.simon_label.Text = "Simon has $50 for betting Now";
            // 
            // label_harmen
            // 
            this.label_harmen.AutoSize = true;
            this.label_harmen.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_harmen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_harmen.Location = new System.Drawing.Point(19, 382);
            this.label_harmen.Name = "label_harmen";
            this.label_harmen.Size = new System.Drawing.Size(320, 24);
            this.label_harmen.TabIndex = 61;
            this.label_harmen.Text = "Harmen has $50 for betting Now";
            // 
            // btnRce
            // 
            this.btnRce.BackColor = System.Drawing.Color.Yellow;
            this.btnRce.Enabled = false;
            this.btnRce.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRce.Location = new System.Drawing.Point(112, 465);
            this.btnRce.Name = "btnRce";
            this.btnRce.Size = new System.Drawing.Size(123, 34);
            this.btnRce.TabIndex = 56;
            this.btnRce.Text = "Run ";
            this.btnRce.UseVisualStyleBackColor = false;
            this.btnRce.Click += new System.EventHandler(this.btnRce_Click);
            // 
            // Jugraj_label
            // 
            this.Jugraj_label.AutoSize = true;
            this.Jugraj_label.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jugraj_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Jugraj_label.Location = new System.Drawing.Point(19, 304);
            this.Jugraj_label.Name = "Jugraj_label";
            this.Jugraj_label.Size = new System.Drawing.Size(305, 24);
            this.Jugraj_label.TabIndex = 59;
            this.Jugraj_label.Text = "Jugraj has $50 for betting Now";
            // 
            // btnLockBet
            // 
            this.btnLockBet.BackColor = System.Drawing.Color.Yellow;
            this.btnLockBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLockBet.Location = new System.Drawing.Point(112, 425);
            this.btnLockBet.Name = "btnLockBet";
            this.btnLockBet.Size = new System.Drawing.Size(123, 34);
            this.btnLockBet.TabIndex = 55;
            this.btnLockBet.Text = "Lock Bet";
            this.btnLockBet.UseVisualStyleBackColor = false;
            this.btnLockBet.Click += new System.EventHandler(this.btnLockBet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 53;
            this.label1.Text = "Betters";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(58, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 24);
            this.label3.TabIndex = 58;
            this.label3.Text = "Select Amount";
            // 
            // cbAAmount
            // 
            this.cbAAmount.FormattingEnabled = true;
            this.cbAAmount.Location = new System.Drawing.Point(122, 233);
            this.cbAAmount.Name = "cbAAmount";
            this.cbAAmount.Size = new System.Drawing.Size(121, 21);
            this.cbAAmount.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(200, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 24);
            this.label2.TabIndex = 54;
            this.label2.Text = "Select Rabbit";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(383, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(695, 16);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Racing Stripes";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(383, 261);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(695, 16);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Racing Stripes";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Location = new System.Drawing.Point(395, 394);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(695, 16);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Racing Stripes";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox5.Location = new System.Drawing.Point(395, 516);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(695, 16);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Racing Stripes";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox6.Location = new System.Drawing.Point(383, 10);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(695, 16);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Racing Stripes";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.ForestGreen;
            this.groupBox7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox7.Location = new System.Drawing.Point(1049, 39);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(63, 481);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Finished";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(1049, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(63, 36);
            this.btnExit.TabIndex = 64;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::RabbitRace_Game.Properties.Resources.rabbit_4;
            this.pictureBox4.Location = new System.Drawing.Point(395, 417);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(143, 81);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::RabbitRace_Game.Properties.Resources.rabbit_3;
            this.pictureBox3.Location = new System.Drawing.Point(395, 298);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(143, 81);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RabbitRace_Game.Properties.Resources.rabbit_2;
            this.pictureBox2.Location = new System.Drawing.Point(395, 161);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(143, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RabbitRace_Game.Properties.Resources.rabbit_1;
            this.pictureBox1.Location = new System.Drawing.Point(395, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(1113, 544);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnRce;
        private System.Windows.Forms.Label Jugraj_label;
        private System.Windows.Forms.Button btnLockBet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbAAmount;
        private System.Windows.Forms.RadioButton jugraj_bettor;
        private System.Windows.Forms.RadioButton simon_bettor;
        private System.Windows.Forms.RadioButton Harmen_bettor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rabbit3_selec;
        private System.Windows.Forms.RadioButton rabbit2_selc;
        private System.Windows.Forms.RadioButton rabbit1_selec;
        private System.Windows.Forms.RadioButton rabbit4_selec;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label simon_label;
        private System.Windows.Forms.Label label_harmen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Timer timer1;
    }
}

