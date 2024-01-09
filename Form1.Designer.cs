
namespace Chicken_Invaders
{
    partial class ChickenInvaders
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChickenInvaders));
            this.BossImage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RedChickenImage = new System.Windows.Forms.PictureBox();
            this.ChickenImage = new System.Windows.Forms.PictureBox();
            this.SpaceShipImage = new System.Windows.Forms.PictureBox();
            this.EggImage = new System.Windows.Forms.PictureBox();
            this.txtScore = new System.Windows.Forms.Label();
            this.bossHealth = new System.Windows.Forms.ProgressBar();
            this.playerHealth = new System.Windows.Forms.ProgressBar();
            this.LazerImage = new System.Windows.Forms.PictureBox();
            this.Cover = new System.Windows.Forms.PictureBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.hs = new System.Windows.Forms.Label();
            this.ResetHS = new System.Windows.Forms.Button();
            this.LoadHS = new System.Windows.Forms.Button();
            this.SaveHS = new System.Windows.Forms.Button();
            this.puas = new System.Windows.Forms.PictureBox();
            this.pufreeze = new System.Windows.Forms.PictureBox();
            this.puhp = new System.Windows.Forms.PictureBox();
            this.pu3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BossImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedChickenImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChickenImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpaceShipImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EggImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LazerImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pufreeze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puhp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pu3)).BeginInit();
            this.SuspendLayout();
            // 
            // BossImage
            // 
            this.BossImage.BackColor = System.Drawing.Color.Transparent;
            this.BossImage.Image = ((System.Drawing.Image)(resources.GetObject("BossImage.Image")));
            this.BossImage.Location = new System.Drawing.Point(350, 12);
            this.BossImage.Name = "BossImage";
            this.BossImage.Size = new System.Drawing.Size(180, 180);
            this.BossImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BossImage.TabIndex = 0;
            this.BossImage.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Location = new System.Drawing.Point(877, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 788);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // RedChickenImage
            // 
            this.RedChickenImage.BackColor = System.Drawing.Color.Transparent;
            this.RedChickenImage.Image = global::Chicken_Invaders.Properties.Resources.RedChicken;
            this.RedChickenImage.Location = new System.Drawing.Point(67, 282);
            this.RedChickenImage.Name = "RedChickenImage";
            this.RedChickenImage.Size = new System.Drawing.Size(100, 100);
            this.RedChickenImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.RedChickenImage.TabIndex = 2;
            this.RedChickenImage.TabStop = false;
            // 
            // ChickenImage
            // 
            this.ChickenImage.BackColor = System.Drawing.Color.Transparent;
            this.ChickenImage.Image = global::Chicken_Invaders.Properties.Resources.Chicken;
            this.ChickenImage.Location = new System.Drawing.Point(709, 282);
            this.ChickenImage.Name = "ChickenImage";
            this.ChickenImage.Size = new System.Drawing.Size(100, 100);
            this.ChickenImage.TabIndex = 3;
            this.ChickenImage.TabStop = false;
            // 
            // SpaceShipImage
            // 
            this.SpaceShipImage.BackColor = System.Drawing.Color.Transparent;
            this.SpaceShipImage.Image = global::Chicken_Invaders.Properties.Resources.Spaceship;
            this.SpaceShipImage.Location = new System.Drawing.Point(396, 632);
            this.SpaceShipImage.Name = "SpaceShipImage";
            this.SpaceShipImage.Size = new System.Drawing.Size(100, 100);
            this.SpaceShipImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.SpaceShipImage.TabIndex = 4;
            this.SpaceShipImage.TabStop = false;
            // 
            // EggImage
            // 
            this.EggImage.BackColor = System.Drawing.Color.Transparent;
            this.EggImage.Image = global::Chicken_Invaders.Properties.Resources.Egg;
            this.EggImage.Location = new System.Drawing.Point(420, 236);
            this.EggImage.Name = "EggImage";
            this.EggImage.Size = new System.Drawing.Size(50, 70);
            this.EggImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.EggImage.TabIndex = 5;
            this.EggImage.TabStop = false;
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.BackColor = System.Drawing.Color.Transparent;
            this.txtScore.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtScore.Location = new System.Drawing.Point(42, 700);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(28, 32);
            this.txtScore.TabIndex = 6;
            this.txtScore.Text = "0";
            // 
            // bossHealth
            // 
            this.bossHealth.Location = new System.Drawing.Point(771, 12);
            this.bossHealth.Name = "bossHealth";
            this.bossHealth.Size = new System.Drawing.Size(100, 23);
            this.bossHealth.TabIndex = 7;
            this.bossHealth.Value = 100;
            // 
            // playerHealth
            // 
            this.playerHealth.Location = new System.Drawing.Point(771, 709);
            this.playerHealth.Name = "playerHealth";
            this.playerHealth.Size = new System.Drawing.Size(100, 23);
            this.playerHealth.TabIndex = 8;
            this.playerHealth.Value = 100;
            // 
            // LazerImage
            // 
            this.LazerImage.BackColor = System.Drawing.Color.Transparent;
            this.LazerImage.Image = global::Chicken_Invaders.Properties.Resources.Laser;
            this.LazerImage.Location = new System.Drawing.Point(440, 581);
            this.LazerImage.Name = "LazerImage";
            this.LazerImage.Size = new System.Drawing.Size(10, 36);
            this.LazerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LazerImage.TabIndex = 9;
            this.LazerImage.TabStop = false;
            // 
            // Cover
            // 
            this.Cover.Image = global::Chicken_Invaders.Properties.Resources.Cover_img;
            this.Cover.Location = new System.Drawing.Point(-2, -16);
            this.Cover.Name = "Cover";
            this.Cover.Size = new System.Drawing.Size(883, 800);
            this.Cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Cover.TabIndex = 10;
            this.Cover.TabStop = false;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(899, 529);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(87, 37);
            this.StartButton.TabIndex = 11;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartGame);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 60;
            this.gameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // hs
            // 
            this.hs.AutoSize = true;
            this.hs.BackColor = System.Drawing.Color.Transparent;
            this.hs.Font = new System.Drawing.Font("Imprint MT Shadow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hs.ForeColor = System.Drawing.Color.Orange;
            this.hs.Location = new System.Drawing.Point(951, 57);
            this.hs.Name = "hs";
            this.hs.Size = new System.Drawing.Size(199, 34);
            this.hs.TabIndex = 12;
            this.hs.Text = "High Score: 0";
            // 
            // ResetHS
            // 
            this.ResetHS.Location = new System.Drawing.Point(1044, 529);
            this.ResetHS.Name = "ResetHS";
            this.ResetHS.Size = new System.Drawing.Size(137, 37);
            this.ResetHS.TabIndex = 11;
            this.ResetHS.Text = "Reset HighScore";
            this.ResetHS.UseVisualStyleBackColor = true;
            this.ResetHS.Click += new System.EventHandler(this.ResetHighScore);
            // 
            // LoadHS
            // 
            this.LoadHS.Location = new System.Drawing.Point(899, 123);
            this.LoadHS.Name = "LoadHS";
            this.LoadHS.Size = new System.Drawing.Size(137, 37);
            this.LoadHS.TabIndex = 11;
            this.LoadHS.Text = "Load HighScore";
            this.LoadHS.UseVisualStyleBackColor = true;
            this.LoadHS.Click += new System.EventHandler(this.LoadHS_Click);
            // 
            // SaveHS
            // 
            this.SaveHS.Location = new System.Drawing.Point(1064, 123);
            this.SaveHS.Name = "SaveHS";
            this.SaveHS.Size = new System.Drawing.Size(137, 37);
            this.SaveHS.TabIndex = 11;
            this.SaveHS.Text = "Save HighScore";
            this.SaveHS.UseVisualStyleBackColor = true;
            this.SaveHS.Click += new System.EventHandler(this.SaveHS_Click);
            // 
            // puas
            // 
            this.puas.BackColor = System.Drawing.Color.Transparent;
            this.puas.Image = global::Chicken_Invaders.Properties.Resources.puas;
            this.puas.Location = new System.Drawing.Point(283, 493);
            this.puas.Name = "puas";
            this.puas.Size = new System.Drawing.Size(50, 50);
            this.puas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.puas.TabIndex = 13;
            this.puas.TabStop = false;
            // 
            // pufreeze
            // 
            this.pufreeze.BackColor = System.Drawing.Color.Transparent;
            this.pufreeze.Image = global::Chicken_Invaders.Properties.Resources.pufreeze;
            this.pufreeze.Location = new System.Drawing.Point(377, 493);
            this.pufreeze.Name = "pufreeze";
            this.pufreeze.Size = new System.Drawing.Size(50, 50);
            this.pufreeze.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pufreeze.TabIndex = 13;
            this.pufreeze.TabStop = false;
            // 
            // puhp
            // 
            this.puhp.BackColor = System.Drawing.Color.Transparent;
            this.puhp.Image = global::Chicken_Invaders.Properties.Resources.puhp;
            this.puhp.Location = new System.Drawing.Point(470, 493);
            this.puhp.Name = "puhp";
            this.puhp.Size = new System.Drawing.Size(50, 50);
            this.puhp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.puhp.TabIndex = 13;
            this.puhp.TabStop = false;
            // 
            // pu3
            // 
            this.pu3.BackColor = System.Drawing.Color.Transparent;
            this.pu3.Image = global::Chicken_Invaders.Properties.Resources.pu3;
            this.pu3.Location = new System.Drawing.Point(566, 493);
            this.pu3.Name = "pu3";
            this.pu3.Size = new System.Drawing.Size(50, 50);
            this.pu3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pu3.TabIndex = 13;
            this.pu3.TabStop = false;
            // 
            // ChickenInvaders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = global::Chicken_Invaders.Properties.Resources.BG;
            this.ClientSize = new System.Drawing.Size(1224, 761);
            this.Controls.Add(this.hs);
            this.Controls.Add(this.SaveHS);
            this.Controls.Add(this.LoadHS);
            this.Controls.Add(this.ResetHS);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.Cover);
            this.Controls.Add(this.LazerImage);
            this.Controls.Add(this.playerHealth);
            this.Controls.Add(this.bossHealth);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.EggImage);
            this.Controls.Add(this.SpaceShipImage);
            this.Controls.Add(this.ChickenImage);
            this.Controls.Add(this.RedChickenImage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BossImage);
            this.Controls.Add(this.pu3);
            this.Controls.Add(this.puhp);
            this.Controls.Add(this.pufreeze);
            this.Controls.Add(this.puas);
            this.Name = "ChickenInvaders";
            this.ShowIcon = false;
            this.Text = "ChickenInvaders";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.BossImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedChickenImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChickenImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpaceShipImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EggImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LazerImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pufreeze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puhp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pu3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BossImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox RedChickenImage;
        private System.Windows.Forms.PictureBox ChickenImage;
        private System.Windows.Forms.PictureBox SpaceShipImage;
        private System.Windows.Forms.PictureBox EggImage;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.ProgressBar bossHealth;
        private System.Windows.Forms.ProgressBar playerHealth;
        private System.Windows.Forms.PictureBox LazerImage;
        private System.Windows.Forms.PictureBox Cover;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label hs;
        private System.Windows.Forms.Button ResetHS;
        private System.Windows.Forms.Button LoadHS;
        private System.Windows.Forms.Button SaveHS;
        private System.Windows.Forms.PictureBox puas;
        private System.Windows.Forms.PictureBox pufreeze;
        private System.Windows.Forms.PictureBox puhp;
        private System.Windows.Forms.PictureBox pu3;
    }
}

