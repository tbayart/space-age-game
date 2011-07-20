using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SpaceShooter
{
    public class Camera
    {
        //The viewport we want the camera to use (holds dimensions and so on)

        private Vector2 createdPosition;
        public Viewport View
        {
            get;
            private set;
        }

        //Where to point the center of the camera (0x0 will be the center of the viewport)
        public Vector2 Position
        {
            get;
            private set;
        }

        //Copy of the old position when we start to shake
        public Vector2 SavedPosition
        {
            get;
            private set;
        }

        //center of focus for the camera
        public Vector2 Center
        {
            get;
            private set;
        }

        //The zoom scalar (1.0f = 100% zoom level)
        public float Zoom
        {
            get;
            private set;
        }

        //Amount to rotate the camera
        public float Rotation
        {
            get;
            private set;
        }

        //Copy of the old rotation when we start to shake
        public float SavedRotation
        {
            get;
            private set;
        }

        //The amount to shake the camera in terms of position
        public float PositionShakeAmount
        {
            get;
            private set;
        }

        //The amount to shake the camera in terms of rotation
        public float RotationShakeAmount
        {
            get;
            private set;
        }

        //The maximum time the shake will last
        public float MaxShakeTime
        {
            get;
            private set;
        }

        //Our camera's transform matrix
        public Matrix Transform
        {
            get;
            private set;
        }

        TimeSpan shaketimer;
        Random random;

        /// <summary>
        /// Initialize a new Camera object
        /// </summary>
        /// <param name="view">The viewport we want the camera to use (holds dimensions and so on)</param>
        /// <param name="position">Where to point the center of the camera (0x0 will be the center of the viewport)</param>
        public Camera(Viewport view, Vector2 position)
        {
            View = view;
            Position = position;
            createdPosition = position;
            Zoom = 1.0f;
            Rotation = 0;
            random = new Random();
        }

        /// <summary>
        /// Initialize a new Camera object
        /// </summary>
        /// <param name="view">The viewport we want the camera to use (holds dimensions and so on)</param>
        /// <param name="position">Where to point the center of the camera (0x0 will be the center of the viewport)</param>
        /// <param name="zoom">How much we want the camera zoomed by default</param>
        /// <param name="rotation">How much we want the camera to be rotated by default</param>
        public Camera(Viewport view, Vector2 position, float zoom, float rotation)
        {
            View = view;
            Position = position;
            createdPosition = position;
            Zoom = zoom;
            Rotation = rotation;
            random = new Random();
        }

        public void Update(GameTime gametime, KeyboardState current, KeyboardState previous)
        {
            if (current.IsKeyDown(Keys.R))
                Reset();
            if (shaketimer.TotalSeconds > 0)
            {
                //Perform a camera shake

                /* We want to restore the saved positions and rotations
                 * so we do not go far from the center point
                 * */
                Position = SavedPosition;
                Rotation = SavedRotation;

                /* We want to subtract the elapsed time with the shaketimer
                 * If it is still above 0. we will perform the camera shake
                 * Otherwise, we will be done for this loop and the next loop
                 * the saved data will be restored and it will go in the main 'else'
                 * block below
                 * */
                shaketimer = shaketimer.Subtract(gametime.ElapsedGameTime);
                if (shaketimer.TotalSeconds > 0)
                {
                    Position += new Vector2((float)((random.NextDouble() * 2) - 1) * PositionShakeAmount,
                        (float)((random.NextDouble() * 2) - 1) * PositionShakeAmount);
                    Rotation += (float)((random.NextDouble() * 2) - 1) * RotationShakeAmount;
                }
            }
            else
            {
                /* Zoom the camera in and out
                 * Z = Zoom in
                 * X = Zoom out
                 * */
                if (current.IsKeyDown(Keys.Z))
                    Zoom += 0.002f;
                if (current.IsKeyDown(Keys.X))
                    Zoom -= 0.002f;

                /* Move the camera with W, S, A, and D
                 * W = Up
                 * S = Down
                 * A = Left
                 * D = Right
                 * Since Position is a property and not a direct object,
                 * we cannot use Position.Y += 56 for example.
                 * 
                 * To counter this, we will use a movement vector
                 * 
                 * We also scale it by speed / zoom.  If we are at 
                 * 200% zoom, we want the movement speed to be slower.
                 * */
                Vector2 movement = Vector2.Zero;
                if (current.IsKeyDown(Keys.W))
                    movement.Y -= 5.0f / Zoom;
                if (current.IsKeyDown(Keys.S))
                    movement.Y += 5.0f / Zoom;
                if (current.IsKeyDown(Keys.A))
                    movement.X -= 5.0f / Zoom;
                if (current.IsKeyDown(Keys.D))
                    movement.X += 5.0f / Zoom;
                if (current.IsKeyDown(Keys.R))
                {
                    Position = createdPosition;
                    Zoom = 1.0f;
                    Rotation = 0;
                }
                    

                //Apply the movement vector
                Position = Vector2.Add(Position, movement);
            }

            //Calculate the center of focus for the camera (we want the camera's position to be the center of the game window)
            Center = new Vector2(Position.X - View.Width / 2, Position.Y - View.Height / 2);

            /* Create a transform matrix through scale, rotation, and translation
             * We use Math.Pow on the zoom to speed up or slow down the zoom.  Both X and Y will have the same zoom levels
             * so there will be no stretching.
             * */
            Transform = Matrix.CreateScale(new Vector3((float)Math.Pow(Zoom, 5), (float)Math.Pow(Zoom, 5), 0)) *
                Matrix.CreateRotationZ(Rotation) *
                Matrix.CreateTranslation(new Vector3(-Center.X, -Center.Y, 0));
        }

        /// <summary>
        /// Resets the camera to default values
        /// </summary>
        private void Reset()
        {
            Position = Vector2.Zero;
            Rotation = 0;
            Zoom = 1.0f;
            shaketimer = TimeSpan.FromSeconds(0);
        }

        /// <summary>
        /// Perform a camera shake
        /// </summary>
        /// <param name="shakeTime">The amount of time to shake the camera</param>
        /// <param name="min">The maximum amount to offset the camera</param>
        public void Shake(float shakeTime, float positionAmount, float rotationAmount)
        {
            //We only want to perform one shake.  If one is going on currently, we have to
            //wait for that shake to be over before we can do another one.
            if (shaketimer.TotalSeconds <= 0)
            {
                MaxShakeTime = shakeTime;
                shaketimer = TimeSpan.FromSeconds(MaxShakeTime);
                PositionShakeAmount = positionAmount;
                RotationShakeAmount = rotationAmount;

                SavedPosition = Position;
                SavedRotation = Rotation;
            }
        }

    }
}
