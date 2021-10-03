﻿using Microsoft.Xna.Framework.Graphics;

namespace Project.NPC.Skeleton
{
    class Skeleton : INPC
    {
        public INPCState currentState;
        public float xPos, yPos;

        public Skeleton()
        {
            currentState = new SkeletonWalkEast(this);
            xPos = 400;
            yPos = 100;
        }

        public void Update()
        {
            currentState.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            currentState.Draw(spriteBatch, xPos, yPos);
        }
    }

}