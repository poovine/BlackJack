using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace BlackJack {
    class ButtonManager {
        private Button hitButton, standButton, doubleButton, splitButton, betButton;
        public Button HitButton { get { return hitButton; } }
        public Button StandButton { get { return standButton; } }
        public Button DoubleButton { get { return doubleButton; } }
        public Button SplitButton { get { return splitButton; } }
        public Button BetButton { get { return betButton; } }

        private Texture2D buttonSprites;
        private ContentManager content;

        public ButtonManager() {
            this.content = new ContentManager(Game1.content.ServiceProvider, "Content");
        }



        public void InitializeButtons() {
            buttonSprites = content.Load<Texture2D>("BJAssets\\bjbuttons");
            hitButton = new Button(buttonSprites, new Vector2(475, 515), new Rectangle(0, 0, 90, 65));
            standButton = new Button(buttonSprites, new Vector2(720, 515), new Rectangle(90, 0, 90, 65));
            doubleButton = new Button(buttonSprites, new Vector2(475, 570), new Rectangle(180, 0, 90, 65));
            splitButton = new Button(buttonSprites, new Vector2(720, 570), new Rectangle(270, 0, 90, 65));
            betButton = new Button(buttonSprites, new Vector2(720, 650), new Rectangle(360, 0, 90, 65));
        }

        public void DrawGameButtons(SpriteBatch spriteBatch) {
            hitButton.Draw(spriteBatch);
            standButton.Draw(spriteBatch);
            doubleButton.Draw(spriteBatch);
            splitButton.Draw(spriteBatch);
            betButton.Draw(spriteBatch);
        }

        public void LoadContent() {
            InitializeButtons();
        }

        public void Update(GameTime gameTime) {

        }

        public void Draw(SpriteBatch spriteBatch) {
            DrawGameButtons(spriteBatch);
        }
    }
}
