using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BlackJack {
    class Button : Sprite {
        
        public Vector2 Position { get { return position; } }
        public Rectangle SourceRectangle { get { return sourceRectangle; } }

        public Button(Texture2D buttonTexture, Vector2 buttonPosition, Rectangle sourceRectangle,
                      float scale = 1, float rotation = 0, float layerDepth = 1
            ) : base (buttonTexture, buttonPosition, sourceRectangle) {
            this.scale = scale;
            this.rotation = rotation;
            this.layerDepth = layerDepth;
        }

        public override void Update(GameTime gameTime) {
            base.Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch) {
            spriteBatch.Draw(spriteTexture, position, sourceRectangle, Color.White, rotation, origin, scale, SpriteEffects.None, layerDepth);          
            base.Draw(spriteBatch);
        }
    }
}
