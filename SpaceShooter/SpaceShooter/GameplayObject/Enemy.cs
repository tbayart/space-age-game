using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
namespace SpaceShooter
{
    public class Enemy : Ship
    {
        Player targetPlayer;
        TimeSpan fireTime;
        bool canFire = false;
        public static Texture2D enemyTex;
         
        public Enemy(Player targetPlayer)
        {
            this.targetPlayer = targetPlayer;
          //  DieTime = TimeSpan.FromSeconds(0.5);
            fireTime = TimeSpan.FromSeconds(1.5);

            Initialize();
            
        }

        public override void  Dying(GameTime gameTime)
 
        {
            
            base.Dead(gameTime);
        }
        public override void Initialize()
        {
            Speed = 1.2f * 60f;

            Texture = enemyTex;

            BulletColor = Color.Red;

            base.Initialize();
        }

        public override void Update(GameTime gameTime)
        {
            if (Status == ObjectStatus.Active)
            {
                fireTime = fireTime.Subtract(gameTime.ElapsedGameTime);
                if (fireTime.TotalSeconds <= 0)
                {
                    canFire = true;
                    PlayScreen.AddGameObject(new Bullet(this, PlayScreen.view));
                    fireTime = TimeSpan.FromSeconds(1.5);

                }
                
                Velocity = new Vector2(targetPlayer.Position.X - Position.X,
                    targetPlayer.Position.Y - Position.Y);
                NormalizeVelocity();

                Velocity = Vector2.Multiply(Velocity, Speed);

                Rotation = (float)(Math.Atan2(
                    targetPlayer.Position.Y - Position.Y,
                    targetPlayer.Position.X - Position.X));
            }


            base.Update(gameTime);
        }

        public static Enemy GenerateEnemy(Viewport view,
            Player p)
        {
            Random r = new Random();

            Enemy e = new Enemy(p);

            int ypos = (int)e.Origin.Y * -1;
            e.Position = new Vector2(r.Next(0, view.Width),
                r.Next(ypos * 2, ypos));

            return e;
        }

    }
}
