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
        public List<Button> buttons;

        private Texture2D playerTexture;
        private Texture2D dealerTexture;
        private Texture2D chipsTexture;
        private Texture2D buttonSprites;
        private Button hitButton, standButton, doubleButton, splitButton, betButton;
        private Vector2 playerPosition = new Vector2(600, 650);
        private Vector2 dealerPosition = new Vector2(600,0);

        private ContentManager content;

        public GameManager() {
            this.content = new ContentManager(Game1.content.ServiceProvider, "Content");
        }

        public void LoadContent() {
            playerTexture = content.Load<Texture2D>("BJAssets\\player");
            dealerTexture = content.Load<Texture2D>("BJAssets\\dealer");
            buttonSprites = content.Load<Texture2D>("BJAssets\\bjbuttons");
            player = new Player(playerTexture, playerPosition, new Rectangle(0,0,playerTexture.Width, playerTexture.Height));
            dealer = new Dealer(dealerTexture, dealerPosition, new Rectangle(0,0, dealerTexture.Width, dealerTexture.Height));

            hitButton = new Button(buttonSprites, new Vector2(475, 515), new Rectangle(0, 0, 90, 65));
            standButton = new Button(buttonSprites, new Vector2(720, 515), new Rectangle(90, 0, 90, 65));
            doubleButton = new Button(buttonSprites, new Vector2(475, 570), new Rectangle(180, 0, 90, 65));
            splitButton = new Button(buttonSprites, new Vector2(720, 570), new Rectangle(270, 0, 90, 65));
            betButton = new Button(buttonSprites, new Vector2(720, 650), new Rectangle(360, 0, 90, 65));


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
            DrawGameCharacters(spriteBatch);
            DrawGameButtons(spriteBatch);
        }

        //public void DrawHands(SpriteBatch spriteBatch) {
            
        //}

        public void DrawGameCharacters(SpriteBatch spriteBatch) {
            player.Draw(spriteBatch);
            dealer.Draw(spriteBatch);
        }

        public void DrawGameButtons(SpriteBatch spriteBatch) {
            hitButton.Draw(spriteBatch);
            standButton.Draw(spriteBatch);
            doubleButton.Draw(spriteBatch);
            splitButton.Draw(spriteBatch);
            betButton.Draw(spriteBatch);
        }
    }
}
