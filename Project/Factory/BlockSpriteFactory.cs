﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Project.Sprites.BlockSprites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Factory
{
    public class BlockSpriteFactory
    {
		private Texture2D blockSpriteSheet;

		private static BlockSpriteFactory instance = new BlockSpriteFactory();

		public static BlockSpriteFactory Instance
		{
			get
			{
				return instance;
			}
		}

		private BlockSpriteFactory()
		{
		}

		public void LoadAllTextures(ContentManager content)
		{
			blockSpriteSheet = content.Load<Texture2D>("Blocks/blocks_sheet");
		}

		//Plain green block
		public IBlock CreatePlainBlockSprite()
		{
            //Parameters - Texture2D for spritesheet, number of rows in spritesheet, number of columns in spritesheet
            return new PlainBlockSprite(blockSpriteSheet, 3, 4);
		}

		//Plain black block
		public IBlock CreateBlackBlockSprite()
        {
			return new BlackBlockSprite(blockSpriteSheet, 3, 4);
        }
		//White brick block
		public IBlock CreateBrickBlockSprite()
		{
			return new BrickBlockSprite(blockSpriteSheet, 3, 4);
		}

		//Horizontal layered white block
		public IBlock CreateLayeredBlockSprite()
		{
			return new LayeredBlockSprite(blockSpriteSheet, 3, 4);
		}

		//Green block with little dots
		public IBlock CreateDottedBlockSprite()
		{
			return new DottedBlockSprite(blockSpriteSheet, 3, 4);
		}
		//Block with square with 4 diagonals
		public IBlock CreatePyramidBlockSprite()
		{
			return new PyramidBlockSprite(blockSpriteSheet, 3, 4);
		}
		//Plain dark blue block
		public IBlock CreateDarkBlueBlockSprite()
		{
			return new DarkBlueBlockSprite(blockSpriteSheet, 3, 4);
		}
		//staircase block
		public IBlock CreateStairBlockSprite()
		{
			return new StairBlockSprite(blockSpriteSheet, 3, 4);
		}
		//Block with face facing right
		public IBlock CreateRightFacingDragonBlockSprite()
		{
			return new RightFacingDragonBlockSprite(blockSpriteSheet, 3, 4);
		}
		//Block with face facing left
		public IBlock CreateLeftFacingDragonBlockSprite()
		{
			return new LeftFacingDragonBlockSprite(blockSpriteSheet, 3, 4);
		}
	}
}
