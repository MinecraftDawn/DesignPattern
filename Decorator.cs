namespace Decorator{
    interface Ice {
        string Name { get; set; }

        int price { get; set; }

        string getDescription();
    }

    class ClearIce : Ice {
        public string Name { get; set; } = "清冰";

        public int price { get; set; } = 30;

        public string getDescription() {
            return Name;
        }
    }

    abstract class Ingredients : Ice {
        protected Ice ice;

        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Ingredients(Ice ice) {
            this.ice = ice;
        }

        public virtual string getDescription() {
            return ice.getDescription();
        }

    }

    class Chocolate : Ingredients {
        public Chocolate(Ice ice) : base(ice) {
        }

        public override string getDescription() {
            return "巧克力 " + base.getDescription();
        }
    }

    class Mango : Ingredients {
        public Mango(Ice ice) : base(ice) {
        }

        public override string getDescription() {
            return "芒果 " + base.getDescription();
        }
    }
}
