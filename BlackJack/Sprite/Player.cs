using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BlackJack {
    class Player : GameCharacter {

        Texture2D chipsTexture;

        public int ChipCount { get; set; }
        public int LowHandValue {
            get {
                if (currentHand != null) { GetHandValues(); }
                return lowHandValue;
            }
        }

        public int HighHandValue {
            get {
                if (currentHand != null) { GetHandValues(); }
                return highHandValue;
            }
        }
       
        public Player(Texture2D playerTexture, Vector2 position, Rectangle maskRectangle)
                        : base(playerTexture, position, maskRectangle) {

        }

        public override void Update(GameTime gameTime) {
            base.Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch) {
            spriteBatch.Draw(spriteTexture, position, Color.White);
            DrawCurrentHand(spriteBatch);
            DrawChips(spriteBatch);
            base.Draw(spriteBatch);
        }

        //private void DrawCurrentHand(SpriteBatch spriteBatch) {
        //    int spacing = 60;
        //    if (currentHand != null) {
        //        for (int i = 0; i < currentHand.Count; i++) {
        //            //change position later
        //            currentHand[i].Position = new Vector2(365 + spacing * i, 400);
        //            currentHand[i].Draw(spriteBatch);
        //        }
        //    }
        //}

        private void DrawChips(SpriteBatch spriteBatch) {

        }
    }
}
