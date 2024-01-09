using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chicken_Invaders
{
    class Egg : Chicken
    {
        Random random = new Random();
        public Egg()
        {
            speed = 3;
            health = 200;
            attackDamage = 50;
        }
        public override void ResetHealth()
        {
            health = 200;
        }

        public override PictureBox Spawn()
        {
            PictureBox egg = new PictureBox
            {

                //Left = random.Next(0, 720),
                //Top = random.Next(-450, -200),
                Image = Properties.Resources.Egg,
                SizeMode = PictureBoxSizeMode.AutoSize,
                BackColor = Color.Transparent
            };
            return egg;

        }
    }
}
