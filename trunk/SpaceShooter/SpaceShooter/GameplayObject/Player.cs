using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceShooter
{
    public class Player : Ship
    {
        #region Player Data Fields

        Rectangle bounds;
        TimeSpan timeToFire;
        bool canFire = false;
        int kills = 0;


        public static Texture2D playerTex;
        #endregion


        public Player(Viewport view)
        {
            bounds = new Rectangle(0, 0, view.Width, view.Height);

            timeToFire = TimeSpan.FromSeconds(0.4);
            DieTime = TimeSpan.FromSeconds(0.3);

            Initialize();
        }

        public override void Initialize()
        {
            Speed = 7*60f;
            HP = 22;
            
            Texture = playerTex;
            bounds.X = (int)Origin.X;
            bounds.Y = (int)Origin.Y;
            BulletColor = Color.Blue;
            bounds.Width -= (int)Origin.X;
            bounds.Height -= (int)Origin.Y;
            
            Position = new Vector2(bounds.Width / 2, bounds.Height / 2 - 5);



            base.Initialize();
        }

        

        public override void Update(GameTime gameTime)
        {

            if (Status == ObjectStatus.Dying)
            {
                PlayScreen.gameOver = true;
            }

            timeToFire = timeToFire.Subtract(gameTime.ElapsedGameTime);

            if (timeToFire.TotalSeconds <= 0)
                canFire = true;

           // HandleInput();

            base.Update(gameTime);
            CheckBounds();
        }

        private void CheckBounds()
        {
            Position = new Vector2(MathHelper.Clamp(Position.X, bounds.X, bounds.Width),
                MathHelper.Clamp(Position.Y, bounds.Y, bounds.Height));

        }

        public void HandleInput(InputSystem input)
        {
           
            Velocity = Vector2.Zero;
            if (input.useKeyboard)
            {
                if (input.MoveUp)
                    Velocity = new Vector2(Velocity.X, -Speed);
                if (input.MoveDown)
                    Velocity = new Vector2(Velocity.X, Speed);
                if (input.MoveLeft)
                    Velocity = new Vector2(-Speed, Velocity.Y);
                if (input.MoveRight)
                    Velocity = new Vector2(Speed, Velocity.Y);
            }
            else
            {
                Velocity = new Vector2(input.mousePositionMovment.X * 40f, input.mousePositionMovment.Y * 40f);
            }
            if (input.Shoot)
            {
                if (canFire)
                {
                    canFire = false;
                    timeToFire = TimeSpan.FromSeconds(0.4);
                    PlayScreen.AddGameObject(new Bullet(this,PlayScreen.view));
                }

            }
        }

        public void EnemyKilled()
        {
            kills++;
        }

        public string GetKills()
        {
            return kills.ToString();
        }


        public string GetHits()
        {
            return HP.ToString();
        }

    }
}
