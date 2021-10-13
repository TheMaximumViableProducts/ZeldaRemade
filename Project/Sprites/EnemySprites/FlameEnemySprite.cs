﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System;

namespace Project
{
    class FlameEnemySprite : IEnemySprite
    {
        private Texture2D flameSpriteSheet;
        private List<Rectangle> sourceFrames;
        private int currentFrame;
        private bool flipped = false;
        private int animationCounter;
        private int animationDelay;



        public FlameEnemySprite(Texture2D flameSpriteSheet, List<Rectangle> sourceFrames)
        {
            this.flameSpriteSheet = flameSpriteSheet;
            this.sourceFrames = sourceFrames;
            this.currentFrame = 0;
            this.animationDelay = 100;
            this.animationCounter = 0;
        }

        public void Draw(SpriteBatch spriteBatch, float xPos, float yPos)
        {
            int scale = 4;

            Rectangle source = sourceFrames[currentFrame];
            Rectangle destination = new Rectangle((int)xPos, (int)yPos, source.Width * scale, source.Height * scale);
            
            SpriteEffects effects = flipped ? SpriteEffects.FlipHorizontally : SpriteEffects.None;    
            spriteBatch.Draw(flameSpriteSheet, destination, source, Color.White, 0f, Vector2.Zero, effects, 0f);
         


        }

        public void Update(GameTime gameTime)
        {
            animationCounter += gameTime.ElapsedGameTime.Milliseconds;
            if (animationCounter > animationDelay)
            {
                animationCounter -= animationDelay;
                flipped = flipped ? false : true;
            }

        }
    }
}
