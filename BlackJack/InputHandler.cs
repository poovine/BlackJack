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
        HitCommand hitCommand = new HitCommand();
        StandCommand standCommand = new StandCommand();
        DoubleDownCommand doubleDownCommand = new DoubleDownCommand();
        SplitCommand splitCommand = new SplitCommand();
        BetCommand betCommand = new BetCommand();
        DoNothing doNothing = new DoNothing();
        ICommand cmd = null;

        public ICommand HandleInput() {

            currMouseState = Mouse.GetState();
            //try to use delegates here
            if (prevMouseState.LeftButton == ButtonState.Released && currMouseState.LeftButton == ButtonState.Pressed && IsTouchingHitButton()) {
                cmd = hitCommand;
            }

            else if (prevMouseState.LeftButton == ButtonState.Released && currMouseState.LeftButton == ButtonState.Pressed && IsTouchingStandButton()) {
                cmd = standCommand;
            }

            else if (prevMouseState.LeftButton == ButtonState.Released && currMouseState.LeftButton == ButtonState.Pressed && IsTouchingDoubleButton()) {
                cmd = doubleDownCommand;
            }

            else if (prevMouseState.LeftButton == ButtonState.Released && currMouseState.LeftButton == ButtonState.Pressed && IsTouchingSplitButton()) {
                cmd = splitCommand;
            }

            else if (prevMouseState.LeftButton == ButtonState.Released && currMouseState.LeftButton == ButtonState.Pressed && IsTouchingBetButton()) {
                cmd = betCommand;
            }

            else {
                cmd = doNothing;
            }
            prevMouseState = currMouseState;
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
