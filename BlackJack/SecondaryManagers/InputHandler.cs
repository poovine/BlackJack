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

        //work in progress
        AddToBet addCommand = new AddToBet();
        SubstractFromBet subtractCommand = new SubstractFromBet();
        
        DoNothingCommand doNothing = new DoNothingCommand();
        ICommand cmd = null;

        public ICommand HandleInput() {

            currMouseState = Mouse.GetState();
            //try to use delegates here
            if (prevMouseState.LeftButton == ButtonState.Released && currMouseState.LeftButton == ButtonState.Pressed
                && IsTouchingButton(GameManager.Instance.ButtonManager.HitButton)) {
                cmd = hitCommand;
            }

            else if (prevMouseState.LeftButton == ButtonState.Released && currMouseState.LeftButton == ButtonState.Pressed 
                && IsTouchingButton(GameManager.Instance.ButtonManager.StandButton)) {
                cmd = standCommand;
            }

            else if (prevMouseState.LeftButton == ButtonState.Released && currMouseState.LeftButton == ButtonState.Pressed 
                && IsTouchingButton(GameManager.Instance.ButtonManager.DoubleButton)) {
                cmd = doubleDownCommand;
            }

            else if (prevMouseState.LeftButton == ButtonState.Released && currMouseState.LeftButton == ButtonState.Pressed 
                && IsTouchingButton(GameManager.Instance.ButtonManager.SplitButton)) {
                cmd = splitCommand;
            }

            else if (prevMouseState.LeftButton == ButtonState.Released && currMouseState.LeftButton == ButtonState.Pressed 
                && IsTouchingButton(GameManager.Instance.ButtonManager.BetButton)) {
                cmd = betCommand;
            }

            else if (prevMouseState.LeftButton == ButtonState.Released && currMouseState.LeftButton == ButtonState.Pressed 
                && IsTouchingButton(GameManager.Instance.ButtonManager.TenButton)) {
                GameManager.BetAdd = 10;
                cmd = addCommand;
            }

            else if (prevMouseState.RightButton == ButtonState.Released && currMouseState.RightButton == ButtonState.Pressed 
                && IsTouchingButton(GameManager.Instance.ButtonManager.TenButton)) {
                GameManager.BetSubstract = 10;
                cmd = subtractCommand;
            }

            else if (prevMouseState.LeftButton == ButtonState.Released && currMouseState.LeftButton == ButtonState.Pressed 
                && IsTouchingButton(GameManager.Instance.ButtonManager.HundredButton)) {
                GameManager.BetAdd = 100;
                cmd = addCommand;
            }

            else if (prevMouseState.RightButton == ButtonState.Released && currMouseState.RightButton == ButtonState.Pressed 
                && IsTouchingButton(GameManager.Instance.ButtonManager.HundredButton)) {
                GameManager.BetSubstract = 100;
                cmd = subtractCommand;
            }

            else if (prevMouseState.LeftButton == ButtonState.Released && currMouseState.LeftButton == ButtonState.Pressed 
                && IsTouchingButton(GameManager.Instance.ButtonManager.FiveHundredButton)) {
                GameManager.BetAdd = 500;
                cmd = addCommand;
            }

            else if (prevMouseState.RightButton == ButtonState.Released && currMouseState.RightButton == ButtonState.Pressed 
                && IsTouchingButton(GameManager.Instance.ButtonManager.FiveHundredButton)) {
                GameManager.BetSubstract = 500;
                cmd = subtractCommand;
            }

            else if (prevMouseState.LeftButton == ButtonState.Released && currMouseState.LeftButton == ButtonState.Pressed 
                && IsTouchingButton(GameManager.Instance.ButtonManager.OneThousandButton)) {
                GameManager.BetAdd = 1000;
                cmd = addCommand;
            }

            else if (prevMouseState.RightButton == ButtonState.Released && currMouseState.RightButton == ButtonState.Pressed 
                && IsTouchingButton(GameManager.Instance.ButtonManager.OneThousandButton)) {
                GameManager.BetSubstract = 1000;
                cmd = subtractCommand;
            }

            else if (prevMouseState.LeftButton == ButtonState.Released && currMouseState.LeftButton == ButtonState.Pressed 
                && IsTouchingButton(GameManager.Instance.ButtonManager.FiveThousandButton)) {
                GameManager.BetAdd = 5000;
                cmd = addCommand;
            }

            else if (prevMouseState.RightButton == ButtonState.Released && currMouseState.RightButton == ButtonState.Pressed 
                && IsTouchingButton(GameManager.Instance.ButtonManager.FiveThousandButton)) {
                GameManager.BetSubstract = 5000;
                cmd = subtractCommand;
            }
            else if (prevMouseState.LeftButton == ButtonState.Released && currMouseState.LeftButton == ButtonState.Pressed 
                && IsTouchingButton(GameManager.Instance.ButtonManager.TenThousandButton)) {
                GameManager.BetAdd = 10000;
                cmd = addCommand;
            }

            else if (prevMouseState.RightButton == ButtonState.Released && currMouseState.RightButton == ButtonState.Pressed 
                && IsTouchingButton(GameManager.Instance.ButtonManager.TenThousandButton)) {
                GameManager.BetSubstract = 10000;
                cmd = subtractCommand;                
            }
            else {
                cmd = doNothing;
            }
            prevMouseState = currMouseState;
            return cmd;
        }

        private bool IsTouchingButton(Button button) {
            Point mousePos = new Point(Mouse.GetState().X, Mouse.GetState().Y);
            Rectangle buttonShape = new Rectangle((int)button.Position.X, (int)button.Position.Y, button.SourceRectangle.Width, button.SourceRectangle.Height);
            return (buttonShape.Contains(mousePos));
        }
    }
}
