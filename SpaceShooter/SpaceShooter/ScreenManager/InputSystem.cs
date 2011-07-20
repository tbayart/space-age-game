using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

namespace SpaceShooter
{
    public class InputSystem
    {

        #region Fields and Properties
        KeyboardState currentKeyboardState;
        KeyboardState previousKeyboardState;

        //Mouse and GamePad states
        MouseState currentMouseState;
        MouseState previousMouseState;
        #endregion

        #region Properties
        public bool useKeyboard=true;

        public KeyboardState CurrentKeyboardState
        {
            get { return currentKeyboardState; }
        }
        public KeyboardState PreviousKeyboardState
        {
            get { return previousKeyboardState; }
        }
        public bool MenuUp
        {
            get { return IsNewPressedKey(Keys.Up); }
        }
        public bool MenuDown
        {
            get { return IsNewPressedKey(Keys.Down); }
        }
        public bool MenuSelect
        {
            get { return IsNewPressedKey(Keys.Enter); }
        }
        public bool MenuCancel
        {
            get { return IsNewPressedKey(Keys.Escape); }
        }
        public bool MoveUp 
        {
            get { return IsPressedKey(Keys.Up); }
        }
        public bool MoveDown
        {
            get { return IsPressedKey(Keys.Down); }
        }
        public bool MoveLeft
        {
            get { return IsPressedKey(Keys.Left); }
        }
        public bool MoveRight
        {
            get { return IsPressedKey(Keys.Right); }
        }
        public bool Shoot
        {
            get { return IsPressedKey(Keys.Space) || (IsLeftMouseNewPressed()) || IsLeftMousePressed(); }
        }

        public Vector2 mousePositionMovment
        {
            get 
            {
                return new Vector2(currentMouseState.X-previousMouseState.X, currentMouseState.Y-previousMouseState.Y);
            
            }
        }


        #endregion

        #region Input System Methods
        public void Update()
        {
            previousKeyboardState = currentKeyboardState;
            currentKeyboardState = Keyboard.GetState();
            previousMouseState = currentMouseState;
            currentMouseState = Mouse.GetState();
        }

        private bool IsNewPressedKey(Keys key)
        {
            return previousKeyboardState.IsKeyUp(key) && currentKeyboardState.IsKeyDown(key);
        }
        private bool IsPressedKey(Keys key)
        {
            return currentKeyboardState.IsKeyDown(key);
        }

        private bool IsLeftMouseNewPressed()
        {
            return (currentMouseState.LeftButton == ButtonState.Released ) && (previousMouseState.LeftButton == ButtonState.Pressed);
        }

        private bool IsLeftMousePressed()
        {
            return (currentMouseState.LeftButton == ButtonState.Pressed)  ;
        }

        private bool IsRightMousePressed()
        {
            return (currentMouseState.RightButton == ButtonState.Released) && (previousMouseState.RightButton == ButtonState.Pressed);
        }
        #endregion

    }
}
