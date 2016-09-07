﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace BlackJack {
    class InputManager {
        private static InputManager instance;

        public static InputManager Instance {
            get {
                if (instance == null) {
                    instance = new InputManager();
                }
                return instance;
            }
        }

        Player player;
        Dealer dealer;      

        public InputHandler InputHandler { get; private set; }

        public InputManager() {
            InputHandler = new InputHandler();
           
        }

        public void LoadContent() {
            player = GameManager.Instance.Player;
            dealer = GameManager.Instance.Dealer;
        }

        public void Update(GameTime gameTime) {
            var cmd = InputHandler.HandleInput();
            cmd.Execute(dealer, player);          
        }
    }

}
