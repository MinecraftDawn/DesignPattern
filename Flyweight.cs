using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight {
    class ProjectileShare {
        private string name;
        private string skin;
        
        public ProjectileShare(string name, string skin) {
            this.name = name;
            this.skin = skin;
        }

        public string getName() {
            return name;
        }

        public string getSkin() {
            return skin;
        }
    }

    class ProjectileShareFactory {
        private readonly static ProjectileShare smallBullet = new ProjectileShare("小子彈","小子彈.png");
        private readonly static ProjectileShare bigBullet = new ProjectileShare("大子彈", "大子彈.png");

        public static ProjectileShare getSmallBullet() {
            return smallBullet;
        }

        public static ProjectileShare getBigBullet() {
            return bigBullet;
        }
    }

    class Projectile {
        private ProjectileShare ps;
        private float speed;

        public Projectile(string type, float speed) {
            this.speed = speed;

            if (type == "small") {
                this.ps = ProjectileShareFactory.getSmallBullet();
            } else if (type == "big") {
                this.ps = ProjectileShareFactory.getBigBullet();
            }
        }

        public string getName() {
            return ps.getName();
        }

        public string getSkin() {
            return ps.getSkin();
        }

        public float getSpeed() {
            return speed;
        }
    }
}
