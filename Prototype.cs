using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype {
    interface Prototype<T> {
        T colne();
    }

    class Robot : Prototype<Robot> {
        private string name;
        private float power;

        public Robot(string name, float power) {
            this.name = name;
            this.power = power;
        }

        public void showInfo() {
            Console.WriteLine(this.name + ", Power: " + this.power);
        }

        public Robot colne() {
            return new Robot(this.name, this.power);
        }
    }
}
