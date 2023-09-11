// MVC 也是使用Facade pattern
namespace Facade {

    abstract class Electronic {
        protected bool power = false;

        public void powerOn() {
            power = true;
        }

        public void powerOff() {
            power = false;
        }

        public bool getPower() {
            return power;
        }

        public virtual void Play() {
            if (power) {
                Console.WriteLine(GetType().Name + " 啟動");
            } else {
                Console.WriteLine(GetType().Name + " 尚未開啟");
            }
        }
    }
    class Trumpet : Electronic{
        private int sound = 50;

        public void setSound(int sound) {
            sound = Math.Max(sound, 0);
            sound = Math.Min(sound, 100);
        }

        public int getSound() {
            return sound;
        }
    }

    class PS5 : Electronic {
        private string game = "";
        public void setGame(string game) { 
            this.game = game;
        }

        public string getGame() {
            return game;
        }

        public override void Play() {
            if (power) {
                Console.WriteLine(GetType().Name + " 啟動。 正在遊玩: " + game);
            } else {
                Console.WriteLine(GetType().Name + " 尚未開啟");
            }
        }
    }

    class Facade {
        private PS5 ps5 = new PS5();
        private Trumpet trumpet = new Trumpet();

        public void play() {
            trumpet.setSound(80);
            trumpet.powerOn();
            trumpet.Play();

            ps5.powerOn();
            ps5.setGame("柏德之門3");
            ps5.Play();
        }

        public void stop() {
            trumpet.powerOff();
            ps5.powerOff();
        }
    }
}
