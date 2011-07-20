using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceShooter
{
    public class MainMenuScreen : MenuScreen
    {
        MenuEntry play, help, quit,options;

        public MainMenuScreen()
        {
            play = new MenuEntry(this,"Play !!");
            help = new MenuEntry(this, "Help!!");
            options = new MenuEntry(this, "Options");
            quit = new MenuEntry(this, "Quit :(");
        
        }

        public override void Initialize()
        {
            play.SetPosition(new Vector2(100, 200), true);
            play.Selected += new EventHandler(this.PlaySelect);

            help.SetRelativePosition(new Vector2(0, SpriteFont.LineSpacing + 10), play, true);
            help.Selected += new EventHandler(this.HelpSelect);

            options.SetRelativePosition(new Vector2(0, SpriteFont.LineSpacing + 10), help, true);
            options.Selected += new EventHandler(OptionsSelect);


            quit.SetRelativePosition(new Vector2(0, SpriteFont.LineSpacing + 10), options, true);
            quit.Selected += new EventHandler(this.QuitSelect);
            quit.WoblingEffect = true;

            Cancel+= new EventHandler(QuitSelect);

            MenuEntries.Add(play);
            MenuEntries.Add(help);
            MenuEntries.Add(options);
            MenuEntries.Add(quit);
        }

        public override void LoadContent()
        {
            ContentManager content = ScreenManager.Content;
            BackgroundTexture = ScreenManager.Content.Load<Texture2D>("Sprites/matrixvesta");
            SpriteFont = content.Load<SpriteFont>("Fonts/andy");
            SFX.PlaySong("Media/Music/ism-menu-001");
        }
        void PlaySelect(object sender, EventArgs e)
        {
            Remove();
            ScreenManager.AddScreen(new PlayScreen());
        }

        void HelpSelect(object sender, EventArgs e)
        {
            Remove();
            ScreenManager.AddScreen(new HelpScreen());
        }

        void OptionsSelect(object sender, EventArgs e)
        {

            Remove();
            ScreenManager.AddScreen(new OptionScreen());
        

        }


        void QuitSelect(object sender, EventArgs e)
        {
            PlayScreen.gameOver = true;
            Remove();
            ScreenManager.AddScreen(new LogoScreen1());
            MenuEntries.Clear(); 
        }

    }
}
