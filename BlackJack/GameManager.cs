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

        public ButtonManager ButtonManager { get { return buttonManager; } private set { } }
        private ButtonManager buttonManager;

        public CommandManager CommandManager { get { return commandManager; } private set { } }
        private CommandManager commandManager;

        public Player Player { get; private set; }
        public Dealer Dealer { get; private set; }

        private Texture2D playerTexture, dealerTexture;
        private Vector2 playerPosition = new Vector2(600, 650);
        private Vector2 dealerPosition = new Vector2(600,0);
        private ContentManager content;

        public GameManager() {
            this.content = new ContentManager(Game1.content.ServiceProvider, "Content");
            commandManager = new CommandManager();
            buttonManager = new ButtonManager();
        }

        public void LoadContent() {
            InitializePlayers();
            ButtonManager.LoadContent();            

            /******** Test Area *******/
            HitCommand hitCommand = new HitCommand();

            Dealer.DealCards(Player);
            Console.WriteLine(Dealer.HighHandValue);
            Console.WriteLine(Player.HighHandValue);
            CommandManager.Hit.Execute(Dealer);
            CommandManager.Hit.Execute(Dealer, Player);

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
            ButtonManager.Draw(spriteBatch);
            
        } 

        public void DrawGameCharacters(SpriteBatch spriteBatch) {
            Player.Draw(spriteBatch);
            Dealer.Draw(spriteBatch);
        }

        public void InitializePlayers() {
            playerTexture = content.Load<Texture2D>("BJAssets\\player");
            dealerTexture = content.Load<Texture2D>("BJAssets\\dealer");
            Player = new Player(playerTexture, playerPosition, new Rectangle(0, 0, playerTexture.Width, playerTexture.Height));
            Dealer = new Dealer(dealerTexture, dealerPosition, new Rectangle(0, 0, dealerTexture.Width, dealerTexture.Height));
        }
    }
}
