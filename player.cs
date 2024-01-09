using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chicken_Invaders
{
    class Player : Base
    {
        bool goLeft, goRight;
        int attackSpeed;


        public Player()
        {
            health = 100;
            speed = 60;
            attackDamage = 100;
            attackSpeed = 50;
        }
        public void SetAttackSpeed(double speed)
        {
            attackSpeed = (int)speed;
        }
        public int GetAttackSpeed()
        {
            return attackSpeed;
        }

        public void SetLeft(bool b)
        {
            goLeft = b;
        }
        public void SetRight(bool b)
        {
            goRight = b;
        }

        public bool GetLeft()
        {
            return goLeft;
        }
        public bool GetRight()
        {
            return goRight;
        }
        public void SetHealth(int h)
        {
            health -= h;
            if (health >= 100)
            {
                health = 100;
            }
            if (health <= 0)
            {
                health = 0;
            }

        }
        public override void ResetHealth()
        {
            health = 100;
        }


    }

}

