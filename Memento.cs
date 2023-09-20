using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento {

    class Originator {
        public int hp { get; set; }
        public int mp { get; set; }
        public int def { get; set; }
        public int atk { get; set; }

        public Memento getStatus() {
            return new Memento(hp, mp, def, atk);
        }

        public void loadStatus(Memento memento) {
            hp = memento.hp;
            mp = memento.mp;
            def = memento.def;
            atk = memento.atk;
        }

    }

    class Memento {
        public int hp { get; set; }
        public int mp { get; set; }
        public int def { get; set; }
        public int atk { get; set; }

        public Memento(int hp, int mp, int def, int atk) {
            this.hp = hp;
            this.mp = mp;
            this.def = def;
            this.atk = atk;
        }
    }

    class MementoCateTaker {
        private Memento save;

        public void saveGame(Memento save) {
            this.save = save;
        }

        public Memento getSave() { 
            return this.save; 
        }  
    }
}