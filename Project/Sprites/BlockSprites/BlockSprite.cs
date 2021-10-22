﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Sprites.BlockSprites
{
    class BlockSprite : IBlockSprite
    {
        private Texture2D blockSpriteSheet;
        private int sheetRows;
        private int sheetColumns;
        private int spriteRow;
        private int spriteColumn;
        private Rectangle destRectangle;
        public Rectangle BoundingBox => destRectangle;
        public BlockSprite(Texture2D blockSpriteSheet, int sheetRows, int sheetColumns, int blockRow, int blockCol)
        {
            this.blockSpriteSheet = blockSpriteSheet;
            this.sheetRows = sheetRows;
            this.sheetColumns = sheetColumns;
            this.spriteRow = blockRow;
            this.spriteColumn = blockCol;
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 position)
        {
            int width = blockSpriteSheet.Width / sheetColumns;
            int height = blockSpriteSheet.Height / sheetRows;
            int scale = 4;
            Rectangle source = new Rectangle(spriteColumn * width, spriteRow * height, width, height);
            destRectangle = new Rectangle((int)position.X, (int)position.Y, width * scale, height * scale);
            spriteBatch.Draw(blockSpriteSheet, destRectangle, source, Color.White);
        }
    }
}