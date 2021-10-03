﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Project.Factory;


namespace Project.Sprites.ItemSprites
{
    public class ArrowSprite : IItemSprite
    {
        private int sheetRows;
        private int sheetColumns;
        private int spriteRow;
        private int spriteColumn;

        private Texture2D spriteSheet;

        //Texture, Rows, Columns
        public ArrowSprite(Texture2D spriteSheet, int sheetRows, int sheetColumns, )
        {
            this.spriteSheet = spriteSheet;
            this.sheetColumns = sheetColumns;
            this.sheetRows = sheetRows;

            spriteRow = 0;
            spriteColumn = 0;

        }

        public void Draw(SpriteBatch spriteBatch, Vector2 position)
        {
            int width = spriteSheet.Width / sheetColumns;
            int height = spriteSheet.Height / sheetRows;
            int scale = 2;

            Rectangle spriteRectangle = new Rectangle(frame * width, spriteRow * height, width, height);
            Rectangle destRectangle = new Rectangle((int)position.X, (int)position.Y, width * scale, height * scale);
            spriteBatch.Draw(spriteSheet, destRectangle, spriteRectangle, Color.White);


        }

        public void Update(GameTime gameTime)
        {
           
        }
    }
}
