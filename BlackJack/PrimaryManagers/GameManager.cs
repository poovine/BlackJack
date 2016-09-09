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
        public CommandManager CommandManager { get { return commandManager; } private set { } }
        public PlayerManager PlayerManager { get { return playerManager; } private set { } }        

        private ButtonManager buttonManager;
        private CommandManager commandManager;
        private PlayerManager playerManager;
        private ContentManager content;

        public static int BetSubstract;
        public static int BetAdd;



        public GameManager() {
            this.content = new ContentManager(Game1.content.ServiceProvider, "Content");
            CardManager.Instance.LoadContent();
            commandManager = new CommandManager();
            playerManager = new PlayerManager();
            buttonManager = new ButtonManager();
        }

        public void LoadContent() {
            PlayerManager.LoadContent();
            ButtonManager.LoadContent();            

            /******** Test Area *******/
            HitCommand hitCommand = new HitCommand();

            PlayerManager.Dealer.DealCards(PlayerManager.Player);
            Console.WriteLine(PlayerManager.Dealer.HighHandValue);
            Console.WriteLine(PlayerManager.Player.HighHandValue);
            CommandManager.Hit.Execute(PlayerManager.Dealer);
            CommandManager.Hit.Execute(PlayerManager.Dealer, PlayerManager.Player);

            //Dealer.Hit(Player);
            Console.WriteLine(PlayerManager.Player.HighHandValue);
           // Dealer.Hit(Dealer);
            Console.WriteLine(PlayerManager.Dealer.HighHandValue);            

            /******Test Area ********/         
        }

        public void UnLoadContent() {

        }

        public void Update(GameTime gameTime) {
            CardManager.Instance.Update(gameTime);
            PlayerManager.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch) {
            PlayerManager.Draw(spriteBatch);
            ButtonManager.Draw(spriteBatch);            
        } 
    }
}
