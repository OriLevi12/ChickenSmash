using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chicken_Invaders
{

    class Chicken : Base
    {
        int temp;

        Random random = new Random();
        public Chicken()
        {
            health = 100;
            speed = 20;
            attackDamage = 20;
        }
        public virtual PictureBox Spawn()
        {
            PictureBox chicken = new PictureBox
            {
                Image = Properties.Resources.Chicken,
                Left = random.Next(0, 720),
                Top = random.Next(-450, -200),
                SizeMode = PictureBoxSizeMode.AutoSize,
                BackColor = Color.Transparent
            };
            return chicken;
        }

        public virtual void SetSpeed(double x)
        {
            speed = (int)x;
        }
        public void SetHealthUp(int h)
        {
            health += h;
        }
        public void SetHealthDown(int h)
        {
            health -= h;
        }


        public virtual void ResetSpeed()
        {
            speed = 20;
        }

        public override void ResetHealth()
        {
            health = 100;
        }
        public void ResumeChicken()
        {
            speed = temp;
        }
        public void PauseChicken()
        {
            temp = speed;
            speed = 0;
        }
    }
}
