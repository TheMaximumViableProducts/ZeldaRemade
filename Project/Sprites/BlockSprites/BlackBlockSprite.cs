﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Sprites.BlockSprites
{
    public class BlackBlockSprite : IBlock
    {
        private Texture2D blockSpriteSheet;
        private int sheetRows;
        private int sheetColumns;
        private int spriteRow;
        private int spriteColumn;

        public BlackBlockSprite(Texture2D blockSpriteSheet, int sheetRows, int sheetColumns)
        {
            this.blockSpriteSheet = blockSpriteSheet;
            this.sheetRows = sheetRows;
            this.sheetColumns = sheetColumns;
            spriteRow = 1;
            spriteColumn = 0;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 position)
        {
            int width = blockSpriteSheet.Width / sheetColumns;
            int height = blockSpriteSheet.Height / sheetRows + 1;
            int scale = 4;

            Rectangle source = new Rectangle(spriteColumn * width, spriteRow * height, width, height - 1);
            Rectangle dest = new Rectangle((int)position.X, (int)position.Y, width * scale, height * scale);
            spriteBatch.Draw(blockSpriteSheet, dest, source, Color.White);
        }
    }
}
