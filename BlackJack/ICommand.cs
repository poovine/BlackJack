using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack {
    interface ICommand {
        void Execute(GameCharacter gameCharacter);
    }

    class HitCommand : ICommand {
        public void Execute(GameCharacter gameCharacter) {
            throw new NotImplementedException();
        }
    }

    class StandCommand : ICommand {
        public void Execute(GameCharacter gameCharacter) {
            throw new NotImplementedException();
        }
    }

    class DoubleDownCommand : ICommand {
        public void Execute(GameCharacter gameCharacter) {
            throw new NotImplementedException();
        }
    }

    class SplitCommand : ICommand {
        public void Execute(GameCharacter gameCharacter) {
            throw new NotImplementedException();
        }
    }

    class DoNothing : ICommand {
        public void Execute(GameCharacter gameCharacter) {
            throw new NotImplementedException();
        }
    }
}
