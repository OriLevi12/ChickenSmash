using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Media;
namespace Chicken_Invaders
{
    public partial class ChickenInvaders : Form
    {

        PowerUps powerUpsArr = new PowerUps();
        Egg egg = new Egg();
        Chicken chicken = new Chicken();
        Player player = new Player();
        RedChicken redChicken = new RedChicken();
        BossChicken bossChicken = new BossChicken();
        PictureBox power = null;

        bool shooting = false;
        bool isGameOver;
        bool isRedalive = false;
        bool isBossAlive = false;
        bool bomberDirection = false;
        bool eggSpawned = false;
        bool eggActive = false;
        int score;
        int highscore = 0;
        Random random = new Random();

        public ChickenInvaders()
        {
            InitializeComponent();
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {


            txtScore.Text = score.ToString();
            if (player.GetLeft() && SpaceShipImage.Left > 50)
            {
                SpaceShipImage.Left -= player.GetSpeed();
            }
            if (player.GetRight() && SpaceShipImage.Left < 720)
            {
                SpaceShipImage.Left += player.GetSpeed();
            }
            if (shooting == true)
            {

                LazerImage.Top -= player.GetAttackSpeed();
            }
            else
            {
                LazerImage.Left = -300;
            }
            if (LazerImage.Top < -5)
            {
                shooting = false;
            }
            if (isBossAlive==false && eggActive==false) // chicken movement (stops at boss)
            {
                ChickenImage.Top += chicken.GetSpeed();
            }

            if (score % 5 == 0 && isRedalive == false && score > 0 && isBossAlive == false)  // condition for red
            {
                chicken.SetSpeed(chicken.GetSpeed() + 4);
                chicken.PauseChicken();
                isRedalive = true;
                RedChickenImage = redChicken.Spawn();
                Controls.Add(RedChickenImage);
                RedChickenImage.Top = -55;
                RedChickenImage.Left = random.Next(0, 720);

            }

            RedChickenImage.Top += redChicken.GetSpeed();


            if (LazerImage.Bounds.IntersectsWith(RedChickenImage.Bounds))    //hitting red
            {
                redChicken.SetHealthDown(player.GetDamage());
                if (redChicken.GetHealth() <= 0)
                {
                    score += 2;
                    Controls.Remove(RedChickenImage);
                    RedChickenImage.Dispose();
                    player.SetHealth(-30);                                  //negative int to heal player

                    PBU();

                    redChicken.ResetHealth();
                    isRedalive = false;
                    chicken.ResumeChicken();
                }
                shooting = false;
            }

            if (RedChickenImage.Bounds.IntersectsWith(SpaceShipImage.Bounds) && isRedalive == true)   //collision with red
            {
                Controls.Remove(RedChickenImage);
                isRedalive = false;
                RedChickenImage.Dispose();
                player.SetHealth(redChicken.GetDamage());
                PBU();
                chicken.ResumeChicken();
            }

            if (RedChickenImage.Top > 800 && isRedalive == true)               //red reaches bottom
            {
                isRedalive = false;
                player.SetHealth(redChicken.GetDamage());
                Controls.Remove(RedChickenImage);
                RedChickenImage.Dispose();
                PBU();
            }

            if (score % 13 == 0 && score > 0 && isBossAlive == false)                   //boss spawn every 13 
            {

                bossChicken.SetSpeed(bossChicken.GetSpeed() + 3);
                isBossAlive = true;
                BossImage = bossChicken.Spawn();
                Controls.Add(BossImage);
                bossChicken.ResetHealth();
                Controls.Add(bossHealth);
                BossPBU();
                BossImage.Top = 35;
                BossImage.Left = 700;
                bomberDirection = true;
            }
            if (isBossAlive == true)                                                //movement - boss
            {
                if (BossImage.Left >= 700) bomberDirection = true;
                if (BossImage.Left <= 35) bomberDirection = false;
                if (bomberDirection == true)
                {
                    BossImage.Left -= bossChicken.GetSpeed();
                }
                if (bomberDirection == false)
                {
                    BossImage.Left += bossChicken.GetSpeed();
                }


            }

            if (isBossAlive == true && LazerImage.Bounds.IntersectsWith(BossImage.Bounds))           //hitting boss
            {
                bossChicken.SetHealthDown(player.GetDamage());
                BossPBU();

                if (bossChicken.GetHealth() <= 0)
                {
                    score += 5;
                    isBossAlive = false;
                    Controls.Remove(BossImage);
                    BossImage.Dispose();
                    Controls.Remove(bossHealth);

                }
                shooting = false;
            }

            if (isBossAlive == true)                        //egg
            {
                eggActive = true;
            }

            if (eggActive == true && eggSpawned == false)              //no egg - condition to spawn
            {
                eggSpawned = true;
                EggImage = egg.Spawn();
                Controls.Add(EggImage);

                EggImage.Left = BossImage.Left + (BossImage.Width / 2);
                EggImage.Top = BossImage.Bottom + 10;

            }

            if (eggActive == true && eggSpawned == true)              //egg movement
            {
                EggImage.Top += egg.GetSpeed();
            }


            if (eggSpawned == true && eggActive == true && LazerImage.Bounds.IntersectsWith(EggImage.Bounds))   //lazer hit egg
            {
                egg.SetHealthDown(player.GetDamage());
                if (egg.GetHealth() <= 0)
                {
                    eggActive = false;
                    Controls.Remove(EggImage);
                    egg.ResetHealth();
                    eggSpawned = false;
                }
                shooting = false;

            }
            if (eggActive && eggSpawned && EggImage.Bounds.IntersectsWith(SpaceShipImage.Bounds))        //egg hits player  
            {
                player.SetHealth(egg.GetDamage());
                PBU();
                Controls.Remove(EggImage);
                EggImage.Dispose();
                eggSpawned = false;
                eggActive = false;
            }
            if (eggActive && eggSpawned && EggImage.Top >= 800)          // egg hits bottom
            {
                this.Controls.Remove(EggImage);
                this.EggImage.Dispose();
                eggActive = false;
                player.SetHealth(egg.GetDamage());
                PBU();
            }



            if (LazerImage.Bounds.IntersectsWith(ChickenImage.Bounds) && isRedalive == false)    //lazer hits chicken
            {
                chicken.SetHealthDown(player.GetDamage());
                if (chicken.GetHealth() <= 0)
                {
                    score += 1;
                    Controls.Remove(ChickenImage);
                    ChickenImage.Dispose();
                    ChickenImage = chicken.Spawn();
                    Controls.Add(ChickenImage);
                    chicken.ResetHealth();

                    if (random.Next(0, 100) > 60 && power == null)                 // powerUpsArr condition   
                    {
                        power = powerUpsArr.Spawn();
                        Controls.Add(power);

                        power.Top = -55;
                        power.Left = random.Next(0, 720);
                    }
                }

                shooting = false;
            }
            if (power != null)
            {
                power.Top += 15;
                if (power.Top >= 800)          // powerup hits bottom
                {
                    Controls.Remove(power);


                    power = null;
                }
            }

            if (power != null && power.Bounds.IntersectsWith(SpaceShipImage.Bounds))        //player gets powerup  
            {

                if (power.Tag.ToString() == "PU_FREEZE")
                {
                    chicken.SetSpeed((int)chicken.GetSpeed() * 0.8);
                }

                if (power.Tag.ToString() == "PU_SPEED")
                    player.SetAttackSpeed(player.GetAttackSpeed() * 1.5);

                if (power.Tag.ToString() == "PU_BONUS3")
                    score += 3;

                if (power.Tag.ToString() == "PU_HEALTH")
                    player.SetHealth(-100);

                Controls.Remove(power);

                power = null;
                PBU();
            }

            if (ChickenImage.Bounds.IntersectsWith(SpaceShipImage.Bounds) || ChickenImage.Top >= 800)  //chicken hits or crosses bottom
            {
                Controls.Remove(ChickenImage);
                ChickenImage.Dispose();
                ChickenImage = chicken.Spawn();
                Controls.Add(ChickenImage);
                player.SetHealth(40);
                PBU();
            }

            if (player.GetHealth() <= 0)               //game-over
            {
                isGameOver = true;
            }
            if (isGameOver == true)
            {
                isGameOver = false;
                GameOver();
            }
        }



        private void StartGame(object sender, EventArgs e)                //start
        {
            ResetGame();
        }




        private void PBU()                                            //progress bar
        {
            playerHealth.Value = player.GetHealth();
        }



        private void BossPBU()                                            //boss progress bar
        {
            bossHealth.Value = bossChicken.GetHealth() / 10;
        }



        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && shooting == false)
            {
                shooting = true;
                e.SuppressKeyPress = true;
                e.Handled = true;


                LazerImage.Top = SpaceShipImage.Top - 30;
                LazerImage.Left = SpaceShipImage.Left + (SpaceShipImage.Width / 2);
            }
            if (e.KeyCode == Keys.Left)
            {
                player.SetLeft(false);
            }
            if (e.KeyCode == Keys.Right)
            {
                player.SetRight(false);
            }

            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                ResetGame();
            }
        }


        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                player.SetLeft(true);
            }
            if (e.KeyCode == Keys.Right)
            {
                player.SetRight(true);
            }
            if (e.KeyCode == Keys.Escape)
            {
                ExitGame();
            }
            if (e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void ResetGame()
        {
            gameTimer.Stop();


            Controls.Remove(ChickenImage);   //remove chickens
            ChickenImage.Dispose();
            Cover.Hide();



            int initialPlayerPositionX = (ClientSize.Width - SpaceShipImage.Width) / 2;          // Reset player
            int initialPlayerPositionY = ClientSize.Height - SpaceShipImage.Height - 50;
            SpaceShipImage.Location = new Point(initialPlayerPositionX, initialPlayerPositionY);


            LazerImage.Location = new Point(-300, -300);                   //reset lazer


            eggActive = false;
            isBossAlive = false;


            isGameOver = false;
            score = 0;
            shooting = false;
            chicken.ResetSpeed();
            Controls.Remove(bossHealth);
            SpaceShipImage.Show();
            txtScore.Show();


            Controls.Remove(EggImage);
            EggImage.Dispose();

            gameTimer.Start();
            Cover.Hide();

            pufreeze.Dispose();
            pu3.Dispose();
            puas.Dispose();
            puhp.Dispose();


            // Spawn a new regular enemy
            ChickenImage = chicken.Spawn();
            Controls.Add(ChickenImage);

            //resetting player's and enemies' health
            chicken.ResetHealth();
            player.ResetHealth();
            PBU();
            bossChicken.ResetHealth();
            bossChicken.ResetSpeed();
            redChicken.ResetHealth();
            Controls.Remove(RedChickenImage);
            RedChickenImage.Dispose();
            Controls.Remove(EggImage);
            BossImage.Dispose();
            Controls.Remove(BossImage);
            Controls.Remove(EggImage);

            StartButton.Enabled = false;
            ResetHS.Enabled = false;
            SaveHS.Enabled = false;
            LoadHS.Enabled = false;

        }


        private void GameOver()
        {
            if (score > highscore)
            {
                highscore = score;
            }
            hs.Text = "High Score: " + highscore.ToString();
            isGameOver = true;
            gameTimer.Stop();
            Cover.Show();
            txtScore.Hide();
            SpaceShipImage.Hide();
            MessageBox.Show("GAME OVER! \n THANKS FOR PLAYING! \n YOUR SCORE IS:" + score, "PLAYER HAS DIED");
            StartButton.Enabled = true;
            ResetHS.Enabled = true;
            SaveHS.Enabled = true;
            LoadHS.Enabled = true;

        }


        private void ExitGame()
        {
            isGameOver = true;
            gameTimer.Stop();
            DialogResult diag_res = MessageBox.Show("Are you sure you want to exit the game?", "Game ended by user", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diag_res == DialogResult.Yes)
            {
                MessageBox.Show("Thank you for playing!");
                this.Close();
            }
            if (diag_res == DialogResult.No)
            {
                diag_res = MessageBox.Show("Reset game?", "Reset game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (diag_res == DialogResult.Yes)
                    ResetGame();
                else
                {
                    isGameOver = false;
                    gameTimer.Start();
                }
            }
        }

        private void ResetHighScore(object sender, EventArgs e)
        {
            highscore = 0;
            hs.Text = "High Score: " + highscore.ToString();
        }

        private void SaveHS_Click(object sender, EventArgs e)
        {
            if (score >= highscore && score != 0)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
                saveFileDialog1.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    IFormatter formatter = new BinaryFormatter();
                    using (Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.ReadWrite, FileShare.None))
                    {
                        formatter.Serialize(stream, highscore);
                    }
                }

            }
            else
                MessageBox.Show("Score in not high enough", "LOW SCORE", MessageBoxButtons.OK);

        }

        private void LoadHS_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                int temp = (int)binaryFormatter.Deserialize(stream);
                if (temp > highscore) highscore = temp;
            }
            hs.Text = "High Score: " + highscore.ToString();
        }


    }

}