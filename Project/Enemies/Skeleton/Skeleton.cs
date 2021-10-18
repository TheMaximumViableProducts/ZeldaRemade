﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Project.Entities;
using Project.Factory;
using System;
using System.Collections.Generic;

namespace Project
{
    class Skeleton : IEnemy
    {
        private int timeToChangeDirection;//time to randomly change direction
        private int changeDirectionCounter;
        private IEnemyState currentState;
        private ISprite sprite;
        private float velocity;
        private Random rand;
        private Vector2 position;
        public ISprite EnemySprite { get => this.sprite; set => this.sprite = value; }
        public float Velocity { get => this.velocity; }
        public Vector2 Position { get => position; set => position = value; }

        public Skeleton(Vector2 pos)
        {
            this.position = pos;
            this.velocity = 50f;
            this.sprite = EnemySpriteFactory.Instance.CreateSkeletonSprite();
            this.rand = new Random();
            timeToChangeDirection = 1000;
            changeDirectionCounter = 0;
            //TODO
            //Should start at a spawning state that has the spawning enemies animation
            currentState = new EnemyWalkEast(this);

        }

        public void ChangeDirection(EnemyDirections direction)
        {
            currentState.ChangeDirection(direction);
        }

        public void UseWeapon()
        {
            //No weapon
        }

        public void SetState(IEnemyState state)
        {
            currentState = state;
        }

        public void TakeDamage(int damage)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Rectangle windowBounds, GameTime gameTime)
        {
            sprite.Update(gameTime);
            changeDirectionCounter += gameTime.ElapsedGameTime.Milliseconds;
            if (changeDirectionCounter > timeToChangeDirection)
            {
                changeDirectionCounter -= timeToChangeDirection;
                int changeDirection = rand.Next(0, 16); //Random number b/w 0 and 15
                switch (changeDirection)
                {
                    case 0:
                        ChangeDirection(EnemyDirections.North);
                        break;
                    case 1:
                        ChangeDirection(EnemyDirections.East);
                        break;
                    case 2:
                        ChangeDirection(EnemyDirections.South);
                        break;
                    case 3:
                        ChangeDirection(EnemyDirections.West);
                        break;
                    case 4:
                        ChangeDirection(EnemyDirections.Northeast);
                        break;
                    case 5:
                        ChangeDirection(EnemyDirections.Southeast);
                        break;
                    case 6:
                        ChangeDirection(EnemyDirections.Southwest);
                        break;
                    case 7:
                        ChangeDirection(EnemyDirections.Northwest);
                        break;
                    default:
                        break;
                }
            }

            currentState.Update(gameTime);


        }

        public void Draw(SpriteBatch spriteBatch, GameTime gameTime, Color color)
        {
            sprite.Draw(spriteBatch, position);
        }
    }

}