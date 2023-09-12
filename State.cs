namespace State {

    class Phone {
        private State state;

        public Phone() {
            this.ChangeState(new ReadyState(this));
        }
        public void clickHomeBtn() {
            state.clickHomeBtn();
        }

        public void ChangeState(State state) {
            this.state = state;
        }
    }

    abstract class State {
        protected Phone Phone;

        public State(Phone phone) {
            Phone = phone;
        }  

        public abstract void clickHomeBtn();

    }

    class ReadyState : State {
        public ReadyState(Phone phone) : base(phone) {

        }

        public override void clickHomeBtn() {
            Console.WriteLine("回到主畫面");
        }
    }

    class LockState : State {
        public LockState(Phone phone) : base(phone) {
        }

        public override void clickHomeBtn() {
            Console.WriteLine("請先解鎖");
        }
    }

    class LessPowerState : State {
        public LessPowerState(Phone phone) : base(phone) {
        }

        public override void clickHomeBtn() {
            Console.WriteLine("電量不足，請充電");
        }
    }


}


