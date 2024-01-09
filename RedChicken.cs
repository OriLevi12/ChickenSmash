using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chicken_Invaders
{
    class RedChicken : Chicken
    {
        Random random = new Random();
        public RedChicken()
        {

            health = 200;
            speed = 20;
            attackDamage = 30;
        }
        public override PictureBox Spawn()
        {
            PictureBox redChicken = new PictureBox
            {
                Image = Properties.Resources.RedChicken,
                SizeMode = PictureBoxSizeMode.AutoSize,
                BackColor = Color.Transparent
            };
            return redChicken;
        }
        public override void ResetHealth()
        {
            health = 200;
        }

    }
}
