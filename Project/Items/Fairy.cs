﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Project.Factory;
using Project.Sprites.ItemSprites;

namespace Project.Items
{
    class Fairy : IItems
    {
  
        private IItemSprite sprite;

        public Rectangle BoundingBox => sprite.DestRectangle;

        public Fairy()
        {
           
            sprite = ItemSpriteFactory.Instance.CreateFairySprite();
   
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 position)
        {
            sprite.Draw(spriteBatch, position);
        }

        public void Update(GameTime gameTime)
        {
            sprite.Update(gameTime);
        }
    }
}