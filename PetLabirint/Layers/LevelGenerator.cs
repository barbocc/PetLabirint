using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace PetLabirint
{
    class LevelGenerator
    {
        public Texture2D BackgroundTexture { get; set; }

        public LevelGenerator(Texture2D levelTexture)
        {
            BackgroundTexture = levelTexture;
        }

        public void Draw(SpriteBatch spriteBatch)
        {

            int width = BackgroundTexture.Width;
            int height = BackgroundTexture.Height;

            int cols = (int)((float)GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width / (float)width);
            int rows = (int)((float)GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height / (float)height); 

            for (int i=0; i<cols; i++)
            {
               
                for (int j = 0; j < rows; j++)
                {
                    Rectangle testRectangle = new Rectangle(i*width, j*height, width, height);
                    spriteBatch.Begin();
                    spriteBatch.Draw(BackgroundTexture, testRectangle, Color.White);
                    spriteBatch.End();
                }

            }

        }
    }
}
