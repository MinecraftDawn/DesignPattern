using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor {
    interface IMoveable {
        void Move(Visitor visitor);
    }

    class Car : IMoveable {
        public void Move(Visitor visitor) {
            visitor.move(this);
        }
    }

    class Bike : IMoveable {
        public void Move(Visitor visitor) {
            visitor.move(this);
        }
    }

    interface Visitor {
        void move(Car visotor);

        void move(Bike bike);
    }

    class VisitorMove : Visitor {
        public void move(Car visotor) {
            Console.WriteLine("時速80");
        }

        public void move(Bike bike) {
            Console.WriteLine("時速20");
        }
    }

    class MoveableGroup {
        private List<IMoveable> moveables = new List<IMoveable>();
        public void add(IMoveable moveable) {
            moveables.Add(moveable);
        }
        public void remove(IMoveable moveable) {
            moveables.Remove(moveable);
        }
        public void displayAll(Visitor visitor) {
            foreach (IMoveable moveable in moveables)
            {
                moveable.Move(visitor);
            }
        }
    }
}
