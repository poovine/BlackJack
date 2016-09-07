using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;


namespace BlackJack {
    
    class GameManager {
        private static GameManager instance;

        public static GameManager Instance {
            get {
                if (instance == null) {
                    instance = new GameManager();
                }
                return instance;
            }          
        }

        public Player player;
        public Dealer dealer;

        private Texture2D playerTexture;
        private Texture2D dealerTexture;
        private Vector2 playerPosition = new Vector2(600, 650);
        private Vector2 dealerPosition = new Vector2(600,0);

        private ContentManager content;

        public GameManager() {
            this.content = new ContentManager(Game1.content.ServiceProvider, "Content");
        }

        public void LoadContent() {
            playerTexture = content.Load<Texture2D>("BJAssets\\player");
            dealerTexture = content.Load<Texture2D>("BJAssets\\dealer");
            player = new Player(playerTexture, playerPosition, new Rectangle(0,0,playerTexture.Width, playerTexture.Height));
            dealer = new Dealer(dealerTexture, dealerPosition, new Rectangle(0,0, dealerTexture.Width, dealerTexture.Height));

            dealer.DealCards(player);
            Console.WriteLine(dealer.HighHandValue);
            Console.WriteLine(player.HighHandValue);
            dealer.Hit(player);
            Console.WriteLine(player.HighHandValue);
            dealer.Hit(dealer);
            Console.WriteLine(dealer.HighHandValue);
            

         
        }

        public void UnLoadContent() {

        }

        public void Update(GameTime gameTime) {
            
        
        }

        public void Draw(SpriteBatch spriteBatch) {

        }

        public void DrawHands(SpriteBatch spriteBatch) {
            
        }

        public void DrawGameCharacters(SpriteBatch spriteBatch) {
            player.Draw(spriteBatch);
            dealer.Draw(spriteBatch);
        }
    }
}
