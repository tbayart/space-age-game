using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceShooter
{
    public class LogoScreen1:IntroScreen
    {

        public LogoScreen1()
        {
            ScreenTime = TimeSpan.FromSeconds(0);
            FadeColor = Color.Black;
            FadeOpacity = 0.8f;
                
        }

        public override void LoadContent()
        {
             Pixel = ScreenManager.Content.Load<Texture2D>("Sprites/singlePixel");
             Texture = ScreenManager.Content.Load<Texture2D>("Sprites/snoop");
            base.LoadContent();
        }

        public override void Remove()
        {
            ScreenManager.AddScreen(new LogoScreen2());
 
            base.Remove();
        }
    }
}
