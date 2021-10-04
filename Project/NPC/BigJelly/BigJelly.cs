﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Project.NPC.BigJelly
{
    class BigJelly : INPC
    {
        public INPCState currentState;
        public float xPos, yPos;

        public BigJelly()
        {
            currentState = new BigJellyWalkEast(this);
            xPos = 400;
            yPos = 100;
        }

        public void Update(GameTime gameTime)
        {
            currentState.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            currentState.Draw(spriteBatch, xPos, yPos);
        }
    }

}