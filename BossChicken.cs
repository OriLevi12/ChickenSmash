using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chicken_Invaders
{
    class BossChicken : Chicken
    {
        

        public BossChicken()
        {
            speed = 10;
            health = 1000;
            attackDamage = 50;
        }

        public override void ResetSpeed()
        {
            speed = 10;
        }
        public override PictureBox Spawn()
        {
            PictureBox bossChicken = new PictureBox
            {
                Image = Properties.Resources.BossChicken_img,
                SizeMode = PictureBoxSizeMode.AutoSize,
                BackColor = Color.Transparent
            };
            return bossChicken;

        }

        public override void ResetHealth()
        {
            health = 1000;
        }

    }
}





