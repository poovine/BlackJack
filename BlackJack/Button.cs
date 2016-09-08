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

        public Button(Texture2D buttonTexture, Vector2 buttonPosition, Rectangle sourceRectangle) : base (buttonTexture, buttonPosition, sourceRectangle) {
            
        }

        public override void Update(GameTime gameTime) {
            base.Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch) {
            spriteBatch.Draw(spriteTexture, position, sourceRectangle, Color.White);          
            base.Draw(spriteBatch);
        }
    }
}
