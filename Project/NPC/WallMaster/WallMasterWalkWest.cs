﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Project.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class WallMasterWalkWest : INPCState
    {
        private int delay_frame_index;
        private WallMaster wallMaster;
        private IEnemySprite sprite;
        private static int delay_frames = 10;
        public WallMasterWalkWest(WallMaster wallMaster)
        {
            this.wallMaster = wallMaster;
            delay_frame_index = 0;
            sprite = NPCSpriteFactory.Instance.CreateWallMasterSprite(Entities.Facing.Left);

        }
        public void Draw(SpriteBatch spriteBatch, float xPos, float yPos)
        {
            sprite.Draw(spriteBatch, xPos, yPos);
        }

        public void Update(GameTime gameTime)
        {
            if (wallMaster.xPos == 400 && wallMaster.yPos == 100)
            {
                wallMaster.currentState = new WallMasterWalkEast(wallMaster);
            }

            if (++delay_frame_index >= delay_frames)
            {
                delay_frame_index = 0;
                wallMaster.xPos -= 5;
                sprite.Update();
            }
        }
    }
}