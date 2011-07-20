using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceShooter
{
    public class LogoScreen3:IntroScreen
    {

        public LogoScreen3()
        {
            ScreenTime = TimeSpan.FromSeconds(0);
            FadeColor = Color.Black;
            FadeOpacity = 0.8f;
                
        }

        public override void LoadContent()
        {
             Pixel = ScreenManager.Content.Load<Texture2D>("Sprites/singlePixel");
             Texture = ScreenManager.Content.Load<Texture2D>("Sprites/house");
            base.LoadContent();
        }

        public override void Remove()
        {
            if (PlayScreen.gameOver == false)
            {
                MainMenuScreen m = new MainMenuScreen();
                m.Selected = Color.Blue;
                ScreenManager.AddScreen(m);
            }
            base.Remove();
        }
    }
}
