using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceShooter 
{
    public class GameOverScreen : MenuScreen
    {
        MenuEntry playAgain, quit;

        public GameOverScreen()
        {
            playAgain = new MenuEntry(this, "Play Again ? ");

            quit = new MenuEntry(this, "Quit :(");

            TransitionOffTime = TransitionOnTime = TimeSpan.FromSeconds(2);

            Selected = Color.Azure;
            NonSelected = Color.Brown;

        }

        public override void Initialize()
        {
            playAgain.SetPosition(new Vector2(200, 200), true);
            playAgain.Selected +=new EventHandler(playAgain_Selected);

            quit.SetRelativePosition(new Vector2(0, SpriteFont.LineSpacing + 10), playAgain, true);
            quit.Selected +=new EventHandler(quit_Selected);
            quit.WoblingEffect = true;

            Cancel += new EventHandler(quit_Selected);

            MenuEntries.Add(playAgain);
            MenuEntries.Add(quit);
        }

        public override void LoadContent()
        {
            BackgroundTexture = ScreenManager.Content.Load<Texture2D>("Sprites/matrixvesta");
            SpriteFont = ScreenManager.Content.Load<SpriteFont>("Fonts/menu");

        }

        void playAgain_Selected(object sender,EventArgs e)
        {
            //show the playagain stuff
            this.BackgroundTexture = null;
            ExitScreen();
            ScreenManager.AddScreen(new PlayScreen());


        }


        void quit_Selected(object sender, EventArgs e)
        {
            //return to main menu
            ExitScreen();
            ScreenManager.AddScreen(new MainMenuScreen());
        //    ScreenManager.Game.Exit();

        }
        
    }
}
