using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceShooter 
{
    public class PauseScreen:MenuScreen

    {
        MenuEntry resume, quit;

        PlayScreen p;
        public PauseScreen(PlayScreen playscreen)
        {
            p = playscreen;
            Parent = p;

            resume = new MenuEntry(this, "Resume Game :)");
            quit = new MenuEntry(this, "Quit :(");
            TransitionOnTime = TransitionOffTime = TimeSpan.FromSeconds(0.5);

                      
        }

        public override void Initialize()
        {
            resume.SetPosition(new Vector2(350, 200), true);
            resume.Selected +=new EventHandler(ResumeSelect);
            quit.SetRelativePosition(new Vector2(0, SpriteFont.LineSpacing + 10), resume, true);
            quit.Selected +=new EventHandler(QuitSelect);
            quit.WoblingEffect = true;

           // Cancel += new EventHandler(QuitSelect);

            MenuEntries.Add(resume);
            MenuEntries.Add(quit);
        }

        public override void LoadContent()
        {
            ContentManager content = ScreenManager.Content;
           // BackgroundTexture = ScreenManager.Content.Load<Texture2D>("Sprites/matrixvesta");
            SpriteFont = content.Load<SpriteFont>("Fonts/andy");
        }

        void ResumeSelect(object sender, EventArgs e)
        {
            MenuCancel();
        }

        void QuitSelect(object sender, EventArgs e)
        {
            PlayScreen.gameOver = true;
            ExitScreen();
            //exit the play screen so it doesnt hang up
            p.ExitScreen();
            ScreenManager.AddScreen(new MainMenuScreen());
            
        //    ScreenManager.Game.Exit();
        }

    }
}
