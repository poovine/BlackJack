using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BlackJack {
    class Player : GameCharacter {

        public int ChipCount { get; set; } = 100;
        public int BetAmount { get; set; } = 0;

        //public int LowHandValue {
        //    get {
        //        if (currentHand != null) { GetHandValues(); }
        //        return lowHandValue;
        //    }
        //}

        //public int HighHandValue {
        //    get {
        //        if (currentHand != null) { GetHandValues(); }
        //        return highHandValue;
        //    }
        //}

        public Player(Texture2D playerTexture, Vector2 position, Rectangle maskRectangle)
                        : base(playerTexture, position, maskRectangle) {           
        }

        public override void Update(GameTime gameTime) {
           // Console.WriteLine(this.BetAmount);            
            base.Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch) {
            spriteBatch.Draw(spriteTexture, position, Color.White);
            DrawCurrentHand(spriteBatch);
            base.Draw(spriteBatch);
        }
    }
}
