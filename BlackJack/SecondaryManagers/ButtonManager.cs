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
        private Button hitButton, standButton, doubleButton, splitButton,
                       betButton, tenButton, hundredButton, fiveHundredButton,
                       oneThousandButton, fiveThousandButton, tenThousandButton;

        public Button HitButton { get { return hitButton; } }
        public Button StandButton { get { return standButton; } }
        public Button DoubleButton { get { return doubleButton; } }
        public Button SplitButton { get { return splitButton; } }
        public Button BetButton { get { return betButton; } }
        public Button TenButton { get { return tenButton; } }
        public Button HundredButton { get { return hundredButton; } }
        public Button FiveHundredButton { get { return fiveHundredButton; } }
        public Button OneThousandButton { get { return oneThousandButton; } }
        public Button FiveThousandButton { get { return fiveHundredButton; } }
        public Button TenThousandButton { get { return tenThousandButton; } }


        private Texture2D buttonSprites, chipSprites;

        private ContentManager content;

        public ButtonManager() {
            this.content = new ContentManager(Game1.content.ServiceProvider, "Content");
        }



        public void InitializeButtons() {
            buttonSprites = content.Load<Texture2D>("BJAssets\\bjbuttons");
            chipSprites = content.Load<Texture2D>("BJAssets\\chipsSheet");
            hitButton = new Button(buttonSprites, new Vector2(475, 515), new Rectangle(0, 0, 90, 65));
            standButton = new Button(buttonSprites, new Vector2(720, 515), new Rectangle(90, 0, 90, 65));
            doubleButton = new Button(buttonSprites, new Vector2(475, 570), new Rectangle(180, 0, 90, 65));
            splitButton = new Button(buttonSprites, new Vector2(720, 570), new Rectangle(270, 0, 90, 65));
            betButton = new Button(buttonSprites, new Vector2(720, 650), new Rectangle(360, 0, 90, 65));
            tenButton = new Button(chipSprites, new Vector2(500, 500), new Rectangle(685, 0, 131, 131), .5f);
            hundredButton = new Button(chipSprites, new Vector2(600, 500), new Rectangle(135, 0, 131, 131), .5f);
            fiveHundredButton = new Button(chipSprites, new Vector2(700, 500), new Rectangle(550, 0, 131, 131), .5f);
            oneThousandButton = new Button(chipSprites, new Vector2(800, 500), new Rectangle(410, 0, 131, 131), .5f);
            fiveThousandButton = new Button(chipSprites, new Vector2(900, 500), new Rectangle(273, 0, 131, 131), .5f);
            tenThousandButton = new Button(chipSprites, new Vector2(1100, 500), new Rectangle(0, 0, 131, 131), .5f);
        }

        public void DrawGameButtons(SpriteBatch spriteBatch) {
            hitButton.Draw(spriteBatch);
            standButton.Draw(spriteBatch);
            doubleButton.Draw(spriteBatch);
            splitButton.Draw(spriteBatch);
            betButton.Draw(spriteBatch);
            tenButton.Draw(spriteBatch);
            hundredButton.Draw(spriteBatch);
            fiveHundredButton.Draw(spriteBatch);
            oneThousandButton.Draw(spriteBatch);
            fiveThousandButton.Draw(spriteBatch);
            tenThousandButton.Draw(spriteBatch);
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
