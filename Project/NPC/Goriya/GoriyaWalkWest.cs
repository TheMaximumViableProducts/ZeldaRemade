﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Project.Factory;

namespace Project.NPC.Goriya
{
    class GoriyaWalkWest : INPCState
    {
        private int delay_frame_index;
        private Goriya goriya;
        private IEnemySprite sprite;
        private static int delay_frames = 10;

        public GoriyaWalkWest(Goriya goriya)
        {
            this.goriya = goriya;
            sprite = NPCSpriteFactory.Instance.CreateGoriyaWalkWestSprite();
            delay_frame_index = 0;

        }
        public void Draw(SpriteBatch spriteBatch, float xPos, float yPos)
        {
            sprite.Draw(spriteBatch, xPos, yPos);
        }

        public void Update(GameTime gameTime)
        {
            if (goriya.xPos == 400 && goriya.yPos == 150)
            {
                goriya.currentState = new GoriyaUseItem(goriya, Entities.Facing.Up);
            }
            if (++delay_frame_index >= delay_frames)
            {
                delay_frame_index = 0;
                goriya.xPos -= 5;
                sprite.Update();
            }
        }
    }
}
