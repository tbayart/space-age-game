using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace SpaceShooter
{
    public class Ship : GameplayObject
    {
        #region gameplay data
        Color bulletColor;
        public Color BulletColor
        {
            get { return bulletColor; }
            protected  set { bulletColor = value; }
        }

        int hp = 0;

        public int HP
        {
            get { return hp; }
            set { hp = value; }
        }
        #endregion

        #region Collision Method

        public override void Collision(GameplayObject target)
        {
            Bullet b = target as Bullet;

            Ship s = target as Ship;

            if (b != null && (b.Source != this))
            {
                this.Damage();
                b.Die();

                Player p = b.Source as Player;
                
                if (p != null)
                    p.EnemyKilled();
            }

            else if (s != null)
            {
                this.Damage();
                s.Damage();
            }
            
        }

        #endregion

        #region Public Methods

        public void Damage()
        {
            hp--;
            if (hp <= 0)
                Die();
          
        }
        #endregion


    }
}
