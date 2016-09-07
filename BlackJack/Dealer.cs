using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BlackJack {
    class Dealer : GameCharacter {

        public int LowHandValue {
            get {
                if (currentHand != null) { GetHandValues(); }
                return lowHandValue;
                //sdfsdfsd 
            }
        }

        public int HighHandValue {
            get {
                if (currentHand != null) { GetHandValues(); }
                return highHandValue;
            }
        }              

        public Dealer(Texture2D playerTexture, Vector2 position, Rectangle maskRectangle)
                        : base(playerTexture, position, maskRectangle) {

        }

        public override void Update(GameTime gameTime) {
            base.Update(gameTime);
            
        }

        public override void Draw(SpriteBatch spriteBatch) {
            spriteBatch.Draw(spriteTexture, position, Color.White);
            DrawCurrentHand(spriteBatch);
            base.Draw(spriteBatch);
        }

        public void DealCards(params Player[] players) {
            Player player = players[0];
            DealCardToPlayer(player);
            RemoveLastCardFromDeck();
            DealCardToDealer(false);
            RemoveLastCardFromDeck();
            DealCardToPlayer(player);
            RemoveLastCardFromDeck();
            DealCardToDealer();
            RemoveLastCardFromDeck();
        }
        
        public void Hit(GameCharacter gameCharacter) {
            if (gameCharacter is Player) {
                DealCardToPlayer(gameCharacter as Player);
            }
            else
                DealCardToDealer();
        }

        private void RemoveLastCardFromDeck() {
            CardManager.Instance.Deck.RemoveAt(CardManager.Instance.Deck.Count - 1);
        }

        private void DealCardToPlayer(Player player, bool cardShowing = true) {
            var nextCard = CardManager.Instance.Deck[CardManager.Instance.Deck.Count - 1];
            nextCard.IsShowing = cardShowing;
            player.CurrentHand.Add(nextCard);
        }

        private void DealCardToDealer(bool cardShowing = true) {
            var nextCard = CardManager.Instance.Deck[CardManager.Instance.Deck.Count - 1];
            nextCard.IsShowing = cardShowing;
            this.CurrentHand.Add(nextCard);
        }

        private void DrawCurrentHand(SpriteBatch spriteBatch) {
            if (currentHand != null) {
                for (int i = 0; i < currentHand.Count; i++) {
                    currentHand[i].Position = new Vector2(365 + 80 * i, 175);
                    currentHand[i].Draw(spriteBatch);
                }
            }
        }
    }
}

