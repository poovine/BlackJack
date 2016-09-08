using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack {
    interface ICommand {
        void Execute(Dealer dealer, Player player);
    }

    class HitCommand : ICommand {
        public void Execute(Dealer dealer, Player player) {
            dealer.Hit(player);
        }

        public void Execute(Dealer dealer) {
            dealer.Hit(dealer);
        }
    }

    class StandCommand : ICommand {
        public void Execute(Dealer dealer, Player player) {
            dealer.Hit(player);
            dealer.Hit(player);
        }

        public void Execute(Dealer dealer) {

        }
    }

    class DoubleDownCommand : ICommand {
        public void Execute(Dealer dealer, Player player) {
            dealer.Hit(player);
            dealer.Hit(player);
            dealer.Hit(player);
            dealer.Hit(player);
        }

        public void Execute(Dealer dealer) {

        }
    }

    class SplitCommand : ICommand {
        public void Execute(Dealer dealer, Player player) {
            dealer.Hit(player);
            dealer.Hit(player);
            dealer.Hit(player);
            dealer.Hit(player);
            dealer.Hit(player);
            dealer.Hit(player);

        }
        public void Execute(Dealer dealer) {

        }
    }

    class BetCommand : ICommand {
        public void Execute(Dealer dealer, Player player) {

        }
        public void Execute(Dealer dealer) {

        }
    }

    class DoNothingCommand : ICommand {
        public void Execute(Dealer dealer, Player player) {
            
        }
        public void Execute(Dealer dealer) {

        }
    }
}
