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
     class PowerUps
    {
        public PictureBox[] powerUPS = new PictureBox[4];
        Random random = new Random();

        public PowerUps()
        {
            powerUPS[0] = new PictureBox       //reduce speed
            {
               Tag = "PU_FREEZE",
               Image = Properties.Resources.pufreeze,
            
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.Transparent
            };
            powerUPS[1] = new PictureBox     // speed
            {
                Tag = "PU_SPEED",
                Image = Properties.Resources.puas,

                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.Transparent
            };
            powerUPS[2] = new PictureBox     // +3 score
            {
                Tag = "PU_BONUS3",
                Image = Properties.Resources.pu3,

                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.Transparent
            };
            powerUPS[3] = new PictureBox     // health
            {
                Tag = "PU_HEALTH",
                Image = Properties.Resources.puhp,

                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.Transparent
            };
        }
        public PictureBox Spawn()
        {
            return powerUPS[random.Next(0, powerUPS.Length)];
        }

    }
}
