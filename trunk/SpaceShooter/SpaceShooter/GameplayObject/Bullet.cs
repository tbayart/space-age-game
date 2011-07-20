using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace SpaceShooter
{
    public class Bullet : GameplayObject
    {
        Ship source;
        public Ship Source { get { return source; } }
        Rectangle bounds;
        public static Texture2D bulletTex;
  


        public Bullet(Ship source,Viewport view)
        {
            this.source = source;
            bounds = new Rectangle(0 - bulletTex.Width, 0 - bulletTex.Height, view.Width + bulletTex.Width, view.Height + bulletTex.Height);

            SFX.PlayEffect("Media/SFX/impact1");
            Initialize();
        }

        public override void Initialize()
        {
            Texture = bulletTex;
            Color = Color.White;

            if (source is Player)
            {
                Position = new Vector2((source.Position.X - source.Origin.X) + source.Texture.Width / 2,
                (source.Position.Y - source.Origin.Y));

                Velocity = new Vector2(0, -9 * 60);
            }
            else
            {
                Position = new Vector2((source.Position.X - source.Origin.X) + source.Texture.Width / 2,
                (source.Position.Y - source.Origin.Y) + source.Texture.Height / 2);

                Velocity = new Vector2(source.Velocity.X, source.Velocity.Y);
                NormalizeVelocity();
                Velocity = Vector2.Multiply(Velocity, source.Speed * 3f);
            }

            Rotation = (float)Math.Atan2(Velocity.Y ,Velocity.X) + MathHelper.ToRadians(90);
           
            

            //DieTime = TimeSpan.FromSeconds(0.5);
            base.Initialize();
        }

        public override void Update(GameTime gameTime)
        {
            if ((Position.X < bounds.X || Position.X > bounds.Width) ||
                (Position.Y < bounds.Y || Position.Y > bounds.Height))
                Die();
             

            base.Update(gameTime);
        }


        public override void Collision(GameplayObject target)
        {
            Die();
            SFX.PlayEffect("Media/SFX/snap-shut");
            if (target is Bullet)
                target.Die();

            
        }

    }
}
