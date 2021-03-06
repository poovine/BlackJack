﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace BlackJack {
    class GameCharacter : Sprite {

        protected List<Card> currentHand = new List<Card>();
        protected List<Vector2> currentHandCardPositions = new List<Vector2>();
        protected string Name { get; set; }
        protected int lowHandValue, highHandValue;

        public List<Card> CurrentHand { get { return currentHand; } }

        private int[] handValues = new int[2];

        public GameCharacter(Texture2D characterTexture, Vector2 position, Rectangle maskRectangle) 
                             : base (characterTexture, position, maskRectangle) {

        }

        public override void Update(GameTime gameTime) {
            base.Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch) {
            base.Draw(spriteBatch);
        }

        protected void GetHandValues() {
            int totalLow = 0;
            int totalHigh = 0;
            foreach(Card c in currentHand) {
                totalLow += c.LowValue;
                totalHigh += c.HighValue;
            }
            lowHandValue = totalLow;
            highHandValue = totalHigh;
        }

        




    }
}
