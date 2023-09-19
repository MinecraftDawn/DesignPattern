using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge {
    interface Color {
        String getColor();
    }

    class Orange : Color {
        public string getColor() {
            return "Orange";
        }
    }

    class Black : Color {
        public string getColor() {
            return "Black";
        }
    }

    abstract class Bike {
        protected Color color;
        public Bike(Color color) {
            this.color = color;
        }

        public abstract string getName();
    }

    class UBike : Bike {
        public UBike(Color color) : base(color) {
        }

        public override string getName() {
            return this.color.getColor() + "的UBike";
        }
    }

    class MyBike : Bike {
        public MyBike(Color color) : base(color) {
        }

        public override string getName() {
            return this.color.getColor() + "的MyBike";
        }
    }
}
