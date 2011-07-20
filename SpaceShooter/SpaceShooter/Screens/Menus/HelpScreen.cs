using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceShooter
{
    public class HelpScreen : GameScreen
    {
        List<string> HelpLines;

        //get our font from our dicitated class
        SpriteFont font = null;

        public HelpScreen()
        {
            HelpLines = new List<string>();
            TransitionOffTime = TransitionOnTime = TimeSpan.FromSeconds(2);
            HelpLines.Add("Up Arrow");
            HelpLines.Add("Move Up In Menu      InGame Move SPACESHIP UP");
            HelpLines.Add("Down Arrow");
            HelpLines.Add("Move Down In Menu      InGame Move SPACESHIP DOWN");
            HelpLines.Add("Left Arrow");
            HelpLines.Add("InGame Move SPACESHIP Left");
            HelpLines.Add("Right Arrow");
            HelpLines.Add("InGame Move SPACESHIP Right");
            HelpLines.Add("Space Or Mouse Left Click");
            HelpLines.Add("InGame Fire SPACESHIP Rockets");
 


        }

        public override void LoadContent()
        {
            ContentManager content = ScreenManager.Content;
            font = content.Load<SpriteFont>(@"Fonts\\Help");

        }

        public override void HandleInput()
        {
            InputSystem helpInput = ScreenManager.InputSystem;
            if (helpInput.MenuCancel)
            {
                ExitScreen();
                ScreenManager.AddScreen(new MainMenuScreen());
            }
        }

        public override void Draw(GameTime gameTime)
        {
            SpriteBatch spriteBatch = ScreenManager.SpriteBatch;


            //set the position of the help
            Vector2 position = new Vector2(50, 100);

            //origin of each line

            Vector2 origin = new Vector2(0, font.LineSpacing / 2);

            //color of the text titles
            Color titleColor = Color.Orange;

            // color of text
            Color fontColor = Color.Salmon;

            // get the fade effect

            fontColor = new Color(fontColor.R, fontColor.G, fontColor.B, ScreenAlpha);

            titleColor = new Color(titleColor.R, titleColor.G, titleColor.B, ScreenAlpha);

            float title = 1.1f;

            float scale = 0.9f;

            spriteBatch.Begin();
            for (int i = 0; i < HelpLines.Count; i++)
            {
                if (i % 2 == 0)
                {
                    spriteBatch.DrawString(font, HelpLines[i], position,
                        titleColor, 0, origin, title, SpriteEffects.None, 0);
                }
                else
                {
                    spriteBatch.DrawString(font, HelpLines[i], position,
                        fontColor, 0, origin, scale, SpriteEffects.None
                        , 0);
                }
                position.Y += font.LineSpacing*2;
            }
            
            spriteBatch.End();
        }
    }
}
