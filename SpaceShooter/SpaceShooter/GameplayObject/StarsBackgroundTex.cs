using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework ;
namespace SpaceShooter
{
    class StarsBackgroundTex:Texture2D
    {
        int width;
        int height;
        GraphicsDevice graphicsDevice;

        public StarsBackgroundTex(GraphicsDevice graphicsDevice, int width, int height,int numbofstars)
            : base(graphicsDevice, width, height, false, SurfaceFormat.Color)

        {
            this.graphicsDevice = graphicsDevice;
            this.width = width;
            this.height = height;

            Random r = new Random();

            Color[] c = new Color[width * height];

            int starsadded = 0;

            while (starsadded<numbofstars)
            {
                int indx = r.Next(c.Length);

                if (c[indx] == Color.Transparent)
                {

                    float value = (float)r.NextDouble() + 0.3f;

                    c[indx] = new Color( new Vector4(value));

                    starsadded++;
                }
                
            }

            SetData<Color>(c);

        }

        //generate a new starrs
        public void GenerateNewStars(int numbofStars)
        {

            Random r = new Random();

            Color[] c = new Color[width * height];

            int starsadded = 0;

            while (starsadded < numbofStars)
            {
                int indx = r.Next(c.Length);

                if (c[indx] == Color.Transparent)
                {

                    float value = (float)r.NextDouble() + 0.3f;

                    c[indx] = new Color(new Vector4(value));

                    starsadded++;
                }

            }

            SetData<Color>(c);

        }

    }

 

 
}
