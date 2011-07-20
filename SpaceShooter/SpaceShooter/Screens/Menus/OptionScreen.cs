using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceShooter 
{
    class OptionScreen : MenuScreen
    {

        MenuEntry quit, fullscreen,keyboard;
        
        public OptionScreen()
        {
            quit = new MenuEntry(this, "Return");
            fullscreen = new MenuEntry(this, "Toggle Full Secreen : OFF");
            keyboard = new MenuEntry(this, "Toggle KeyBoard Or Mouse : Mouse");
            
        }

        public override void LoadContent()
        {
            ContentManager content = ScreenManager.Content;
            BackgroundTexture = ScreenManager.Content.Load<Texture2D>("Sprites/matrixvesta");
            SpriteFont = content.Load<SpriteFont>("Fonts/andy");

        }

        public override void Initialize()
        {
            fullscreen.SetPosition(new Vector2(100, 200), true);
            fullscreen.Selected += new EventHandler(fullscreen_Selected);

            keyboard.SetRelativePosition(new Vector2(20, SpriteFont.LineSpacing + 10), fullscreen, true);
            keyboard.Selected += new EventHandler(keyboard_Selected);

            quit.SetRelativePosition(new Vector2(20, SpriteFont.LineSpacing + 10), keyboard, true);
            quit.Selected += new EventHandler(quit_Selected);
            quit.WoblingEffect = true;

            Cancel += new EventHandler(quit_Selected);
            MenuEntries.Add(fullscreen);
            MenuEntries.Add(keyboard);
            MenuEntries.Add(quit);

        }

 
        void keyboard_Selected(object sender, EventArgs e)
        {
            ScreenManager.InputSystem.useKeyboard = !ScreenManager.InputSystem.useKeyboard;

            if (ScreenManager.InputSystem.useKeyboard == true)
                keyboard.EntryTitle = "Toggle KeyBoard Or Mouse : KeyBoard";
            else

                keyboard.EntryTitle = "Toggle KeyBoard Or Mouse : Mouse";

        }

        void quit_Selected(object sender, EventArgs e)
        {
            Remove();
            ScreenManager.AddScreen(new MainMenuScreen());
        }

        void fullscreen_Selected(object sender, EventArgs e)
        {

            ScreenManager.GraphicsManager.ToggleFullScreen();
            if (ScreenManager.GraphicsDevice.PresentationParameters.IsFullScreen)
            {
              //  ScreenManager.GraphicsDevice.PresentationParameters.IsFullScreen = true;
                fullscreen.EntryTitle = " Toggle Full Secreen : ON";
            }
            else
   
            {
     
                fullscreen.EntryTitle = " Toggle Full Secreen : OFF";
            }

        }
    }
}
