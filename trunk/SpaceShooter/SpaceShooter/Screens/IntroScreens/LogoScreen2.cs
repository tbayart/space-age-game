using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceShooter
{
    public class LogoScreen2:IntroScreen
    {

        public LogoScreen2()
        {
            ScreenTime = TimeSpan.FromSeconds(0);
            FadeColor = Color.Black;
            FadeOpacity = 0.8f;
                
        }

        public override void LoadContent()
        {
             Pixel = ScreenManager.Content.Load<Texture2D>("Sprites/singlePixel");
             Texture = ScreenManager.Content.Load<Texture2D>("Sprites/frodo");
            base.LoadContent();
        }

        public override void Remove()
        {
            ScreenManager.AddScreen(new LogoScreen3());
 
            base.Remove();
        }
    }
}
