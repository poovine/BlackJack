using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace BlackJack {
    class InputHandler {
        MouseState prevMouseState = Mouse.GetState(), currMouseState;
        private ICommand cmd = new DoNothing();

        public ICommand HandleInput() {

            currMouseState = Mouse.GetState();
            //try to use delegates here
            if (prevMouseState.LeftButton == ButtonState.Released && currMouseState.LeftButton == ButtonState.Pressed && IsTouchingHitButton()) {
                cmd = new HitCommand();
            }

            else if (prevMouseState.LeftButton == ButtonState.Released && currMouseState.LeftButton == ButtonState.Pressed && IsTouchingStandButton()) {
                cmd = new StandCommand();
            }

            else if (prevMouseState.LeftButton == ButtonState.Released && currMouseState.LeftButton == ButtonState.Pressed && IsTouchingDoubleButton()) {
                cmd = new DoubleDownCommand();
            }

            else if (prevMouseState.LeftButton == ButtonState.Released && currMouseState.LeftButton == ButtonState.Pressed && IsTouchingSplitButton()) {
                cmd = new SplitCommand();
            }

            else if (prevMouseState.LeftButton == ButtonState.Released && currMouseState.LeftButton == ButtonState.Pressed && IsTouchingBetButton()) {
                cmd = new BetCommand();
            }

            else {
                cmd = new DoNothing();
            }
            prevMouseState = Mouse.GetState();
            return cmd;
        }

        private bool IsTouchingHitButton() {
            var button = GameManager.Instance.HitButton;
            Point mousePos = new Point(Mouse.GetState().X, Mouse.GetState().Y);
            Rectangle buttonShape = new Rectangle((int)button.Position.X, (int)button.Position.Y, button.SourceRectangle.Width, button.SourceRectangle.Height);
            return (buttonShape.Contains(mousePos));
        }

        private bool IsTouchingStandButton() {
            var button = GameManager.Instance.StandButton;
            Point mousePos = new Point(Mouse.GetState().X, Mouse.GetState().Y);
            Rectangle buttonShape = new Rectangle((int)button.Position.X, (int)button.Position.Y, button.SourceRectangle.Width, button.SourceRectangle.Height);
            return (buttonShape.Contains(mousePos));
        }

        private bool IsTouchingDoubleButton() {
            var button = GameManager.Instance.DoubleButton;
            Point mousePos = new Point(Mouse.GetState().X, Mouse.GetState().Y);
            Rectangle buttonShape = new Rectangle((int)button.Position.X, (int)button.Position.Y, button.SourceRectangle.Width, button.SourceRectangle.Height);
            return (buttonShape.Contains(mousePos));
        }

        private bool IsTouchingSplitButton() {
            var button = GameManager.Instance.SplitButton;
            Point mousePos = new Point(Mouse.GetState().X, Mouse.GetState().Y);
            Rectangle buttonShape = new Rectangle((int)button.Position.X, (int)button.Position.Y, button.SourceRectangle.Width, button.SourceRectangle.Height);
            return (buttonShape.Contains(mousePos));
        }

        private bool IsTouchingBetButton() {
            var button = GameManager.Instance.BetButton;
            Point mousePos = new Point(Mouse.GetState().X, Mouse.GetState().Y);
            Rectangle buttonShape = new Rectangle((int)button.Position.X, (int)button.Position.Y, button.SourceRectangle.Width, button.SourceRectangle.Height);
            return (buttonShape.Contains(mousePos));
        }
    }
}
