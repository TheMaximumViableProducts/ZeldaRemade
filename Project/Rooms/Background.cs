﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Project.Factory;
using Project.Sprites.BackgroundSprites;

namespace Project
{
    public class Background
    {
        private IBackgroundSprite backgroundSprite;
        private Rectangle bounds;
        public Rectangle Bounds => bounds;

        public Background(string room, GraphicsDeviceManager graphics)
        {
            const int heightOffset = 224;
            bounds = new Rectangle(0, heightOffset, graphics.PreferredBackBufferWidth, graphics.PreferredBackBufferHeight - heightOffset);

            switch (room)
            {
                case "Room1":
                    backgroundSprite = BackgroundSpriteFactory.Instance.CreateOldManRoomBackgroundSprite();
                    break;
                case "Room2":
                    backgroundSprite = BackgroundSpriteFactory.Instance.CreateStairRoomBackgroundSprite();
                    break;
                case "Room3":
                    backgroundSprite = BackgroundSpriteFactory.Instance.CreateOneBlockRoomBackgroundSprite();
                    break;
                case "Room4":
                case "Room10":
                    backgroundSprite = BackgroundSpriteFactory.Instance.CreateSixBlockRoomBackgroundSprite();
                    break;
                case "Room5":
                    backgroundSprite = BackgroundSpriteFactory.Instance.CreateEmptyRoomBackgroundSprite();
                    break;
                case "Room6":
                    backgroundSprite = BackgroundSpriteFactory.Instance.CreateWaterRoomBackgroundSprite();
                    break;
                case "Room7":
                    backgroundSprite = BackgroundSpriteFactory.Instance.CreateLotsWaterRoomBackgroundSprite();
                    break;
                case "Room8":
                    backgroundSprite = BackgroundSpriteFactory.Instance.CreateXRoomBackgroundSprite();
                    break;
                case "Room9":
                case "Room12":
                    backgroundSprite = BackgroundSpriteFactory.Instance.Create4BlockRoomBackgroundSprite();
                    break;
                case "Room11":
                    backgroundSprite = BackgroundSpriteFactory.Instance.CreateStartRoomBackgroundSprite();
                    break;
                case "Room13":
                    backgroundSprite = BackgroundSpriteFactory.Instance.CreateBig4BlockRoomBackgroundSprite();
                    break;
                case "Room14":
                    backgroundSprite = BackgroundSpriteFactory.Instance.CreateTwo6BlockRoomBackgroundSprite();
                    break;
                case "Room15":
                    backgroundSprite = BackgroundSpriteFactory.Instance.CreateDragonBackgroundSprite();
                    break;
                case "Room16":
                    backgroundSprite = BackgroundSpriteFactory.Instance.CreateWallMasterRoomBackgroundSprite();
                    break;
                case "Room17":
                    backgroundSprite = BackgroundSpriteFactory.Instance.CreateFinalRoomBackgroundSprite();
                    break;
                case "Room18":
                    backgroundSprite = BackgroundSpriteFactory.Instance.CreateHiddenRoomBackgroundSprite();
                    break;
            }
        }


        public void Draw(SpriteBatch spriteBatch)
        {
            backgroundSprite.Draw(spriteBatch, bounds);
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 offset)
        {
            backgroundSprite.Draw(spriteBatch, bounds, offset);
        }




    }
}
