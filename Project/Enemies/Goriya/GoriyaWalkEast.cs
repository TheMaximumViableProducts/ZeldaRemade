﻿using Microsoft.Xna.Framework;
using Project.Factory;

namespace Project
{
    class GoriyaWalkEast : IEnemyState
    {
        private Goriya goriya;

        public GoriyaWalkEast(Goriya goriya)
        {
            this.goriya = goriya;
            this.goriya.EnemySprite = EnemySpriteFactory.Instance.CreateGoriyaWalkEastSprite();

        }

        public void ChangeDirection(EnemyDirections direction)
        {
            switch (direction)
            {
                case EnemyDirections.North:
                    goriya.SetState(new GoriyaWalkNorth(goriya));
                    break;
                case EnemyDirections.South:
                    goriya.SetState(new GoriyaWalkSouth(goriya));
                    break;
                case EnemyDirections.West:
                    goriya.SetState(new GoriyaWalkWest(goriya));
                    break;
            }
        }

        public void Update(GameTime gameTime)
        {
            goriya.Position = new Vector2((float)(gameTime.ElapsedGameTime.TotalSeconds * goriya.Velocity) + goriya.Position.X,
                                        goriya.Position.Y);
        }

        public void UseWeapon()
        {
            goriya.SetState(new GoriyaUseItem(goriya));
        }
    }
}
