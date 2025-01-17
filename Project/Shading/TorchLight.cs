﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Project.Shading
{
    public abstract class TorchLight : Lightable
    {
        protected new Color lightColor = Color.DarkOrange;
        protected Color innerLightColor = Color.Red;
        protected new float lightScale = 1f;
        protected float innerLightScale = 0.5f;
        protected new float lightIntensity = 1f;
        protected float innerLightIntensity = .8f;
        protected float flickerIntensity = 1f;

        private void SetFlickerIntensity(GameTime gameTime)
        {
            flickerIntensity = Math.Clamp(flickerIntensity + (float)((new Random()).NextDouble() - .3), 0, 1);
        }

        public override void DrawLight(SpriteBatch spriteBatch, GameTime gameTime, Rectangle destRectangle)
        {
            SetFlickerIntensity(gameTime);

            Rectangle outerFlame = new Rectangle(destRectangle.X, destRectangle.Y, destRectangle.Width, destRectangle.Height);
            Rectangle innerFlame = new Rectangle(destRectangle.X, destRectangle.Y, destRectangle.Width, destRectangle.Height);

            float outerHorizAdjust = (outerFlame.Width * lightScale - outerFlame.Width) / 2;
            float outerVertAdjust = (outerFlame.Height * lightScale - outerFlame.Height) / 2;
            outerFlame.Inflate(outerHorizAdjust, outerVertAdjust);

            float innerHorizAdjust = (innerFlame.Width * innerLightScale - innerFlame.Width) / 2;
            float innerVertAdjust = (innerFlame.Height * innerLightScale - innerFlame.Height) / 2;
            innerFlame.Inflate(innerHorizAdjust, innerVertAdjust);
            innerFlame.Offset(lightOffset.X, lightOffset.Y);
            outerFlame.Offset(lightOffset.X, lightOffset.Y);
            spriteBatch.Draw(LightShaderFactory.Instance.LightTexture, outerFlame, lightColor * lightIntensity * flickerIntensity);
            spriteBatch.Draw(LightShaderFactory.Instance.LightTexture, innerFlame, innerLightColor * innerLightIntensity * flickerIntensity);
        }
    }
}
