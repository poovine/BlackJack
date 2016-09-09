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
        public Button FiveThousandButton { get { return fiveThousandButton; } }
        public Button TenThousandButton { get { return tenThousandButton; } }


        private Texture2D buttonSprites, chipSprites;

        private ContentManager content;

        public ButtonManager() {
            this.content = new ContentManager(Game1.content.ServiceProvider, "Content");
        }
        public void InitializeButtons() {
            buttonSprites = content.Load<Texture2D>("BJAssets\\bjbuttons");
            chipSprites = content.Load<Texture2D>("BJAssets\\chipsSheet2");
            hitButton = new Button(buttonSprites, new Vector2(475, 515), new Rectangle(0, 0, 90, 65));
            standButton = new Button(buttonSprites, new Vector2(720, 515), new Rectangle(90, 0, 90, 65));
            doubleButton = new Button(buttonSprites, new Vector2(475, 570), new Rectangle(180, 0, 90, 65));
            splitButton = new Button(buttonSprites, new Vector2(720, 570), new Rectangle(270, 0, 90, 65));
            betButton = new Button(buttonSprites, new Vector2(720, 650), new Rectangle(360, 0, 90, 65));
            tenButton = new Button(chipSprites, new Vector2(845, 640), new Rectangle(343, 0, 65, 65));
            hundredButton = new Button(chipSprites, new Vector2(915, 640), new Rectangle(69, 0, 65, 65));
            fiveHundredButton = new Button(chipSprites, new Vector2(985, 640), new Rectangle(275, 0, 65, 65));
            oneThousandButton = new Button(chipSprites, new Vector2(1055, 640), new Rectangle(206, 0, 65, 65));
            fiveThousandButton = new Button(chipSprites, new Vector2(1125, 640), new Rectangle(137, 0, 65, 65));
            tenThousandButton = new Button(chipSprites, new Vector2(1195, 640), new Rectangle(0, 0, 65, 65));
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
