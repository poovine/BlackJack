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

        public Player Player { get; private set; }
        public Dealer Dealer { get; private set; }
            
        private Button hitButton, standButton, doubleButton, splitButton, betButton;
        public Button HitButton { get { return hitButton; } }
        public Button StandButton { get { return standButton; } }
        public Button DoubleButton { get { return doubleButton; } }
        public Button SplitButton { get { return splitButton; } }
        public Button BetButton { get { return betButton; } }

        private Texture2D playerTexture;
        private Texture2D dealerTexture;        
        private Texture2D buttonSprites;
        private Vector2 playerPosition = new Vector2(600, 650);
        private Vector2 dealerPosition = new Vector2(600,0);

        private ContentManager content;

        public GameManager() {
            this.content = new ContentManager(Game1.content.ServiceProvider, "Content");
        }

        public void LoadContent() {
            InitializePlayers();
            InitializeButtons();

            /******** Test Area *******/
            HitCommand hitCommand = new HitCommand();

            Dealer.DealCards(Player);
            Console.WriteLine(Dealer.HighHandValue);
            Console.WriteLine(Player.HighHandValue);
            hitCommand.Execute(Dealer, Player);
            hitCommand.Execute(Dealer);
            
            //Dealer.Hit(Player);
            Console.WriteLine(Player.HighHandValue);
           // Dealer.Hit(Dealer);
            Console.WriteLine(Dealer.HighHandValue);
            

            /******Test Area ********/

         
        }

        public void UnLoadContent() {

        }

        public void Update(GameTime gameTime) {
            
        
        }

        public void Draw(SpriteBatch spriteBatch) {
            DrawGameCharacters(spriteBatch);
            DrawGameButtons(spriteBatch);
        } 

        public void DrawGameCharacters(SpriteBatch spriteBatch) {
            Player.Draw(spriteBatch);
            Dealer.Draw(spriteBatch);
        }

        public void InitializeButtons() {
            buttonSprites = content.Load<Texture2D>("BJAssets\\bjbuttons");
            hitButton = new Button(buttonSprites, new Vector2(475, 515), new Rectangle(0, 0, 90, 65));
            standButton = new Button(buttonSprites, new Vector2(720, 515), new Rectangle(90, 0, 90, 65));
            doubleButton = new Button(buttonSprites, new Vector2(475, 570), new Rectangle(180, 0, 90, 65));
            splitButton = new Button(buttonSprites, new Vector2(720, 570), new Rectangle(270, 0, 90, 65));
            betButton = new Button(buttonSprites, new Vector2(720, 650), new Rectangle(360, 0, 90, 65));
        }

        public void InitializePlayers() {
            playerTexture = content.Load<Texture2D>("BJAssets\\player");
            dealerTexture = content.Load<Texture2D>("BJAssets\\dealer");
            Player = new Player(playerTexture, playerPosition, new Rectangle(0, 0, playerTexture.Width, playerTexture.Height));
            Dealer = new Dealer(dealerTexture, dealerPosition, new Rectangle(0, 0, dealerTexture.Width, dealerTexture.Height));
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
