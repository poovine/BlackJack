using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using System.Collections.Generic;
using System;

namespace BlackJack {
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;        
        
        
        //InputManager inputManager;

        public static ContentManager content;
        public static Random random = new Random();


        /**********************************
        Temp Variables 
        ***********************************/
     
        


        /**********************************
        Temp Variables
        ***********************************/

        public static int screenWidth = 1280;
        public static int screenHeight = 720;
        public static GameState gameState;

        public enum GameState {
            MainMenu,
            Game,
            SubMenu
        }

        public Game1() {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            content = new ContentManager(Content.ServiceProvider, "Content");
        }


        protected override void Initialize() {
            // TODO: Add your initialization logic here
            graphics.PreferredBackBufferWidth = screenWidth;
            graphics.PreferredBackBufferHeight = screenHeight;
            IsMouseVisible = true;
            gameState = GameState.Game;
            CardManager.Instance.LoadContent();
            GameManager.Instance.LoadContent();
            ScreenManager.Instance.LoadContent();
            InputManager.Instance.LoadContent();


            base.Initialize();
        }


        protected override void LoadContent() {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

           
         

            
            // TODO: use this.Content to load your game content here
        }


        protected override void UnloadContent() {
            // TODO: Unload any non ContentManager content here
        }

        protected override void Update(GameTime gameTime) {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            switch (gameState) {
                case GameState.MainMenu:
                                        

                    break;
                case GameState.Game:
                    InputManager.Instance.Update(gameTime);
                    ScreenManager.Instance.Update(gameTime);
                    GameManager.Instance.Update(gameTime);
                    CardManager.Instance.Update(gameTime);
                    break;
                case GameState.SubMenu:
                    break;
            }


            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime) {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            ScreenManager.Instance.Draw(spriteBatch);           
            spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
