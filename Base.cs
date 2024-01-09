using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Chicken_Invaders
{
    class Base
    {
        protected int health;
        protected int speed;
        protected int attackDamage;
        public virtual int GetHealth()
        {
            return health;
        }
        public int GetSpeed()
        {
            return speed;
        }
        public virtual void ResetHealth()
        {

        }
        public int GetDamage()
        {
            return attackDamage;
        }

        public PictureBox CoverSpawn()
        {
            PictureBox CoverArt_Image = new PictureBox
            {
                Image = Properties.Resources.Cover_img,
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Transparent,
            };
            return CoverArt_Image;
        }
    }
}
