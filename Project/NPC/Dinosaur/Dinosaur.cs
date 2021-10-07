﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Project.NPC.Dinosaur
{
    class Dinosaur : INPC
    {
        public INPCState currentState;
        public float xPos, yPos;

        public Dinosaur()
        {
            currentState = new DinosaurWalkEast(this);
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