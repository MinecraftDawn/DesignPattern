namespace Composite {
    abstract class Component {
        protected string name;

        public Component(string name) {
            this.name = name;
        }

        public abstract void add(Component component);

        public abstract void remove(Component component);

        public virtual void inflate(int deep) {
            for (int i = 0; i < deep; i++) {
                Console.Write('-');
            }

            Console.WriteLine(this.name);
        }
    }

    abstract class Composite : Component {
        protected List<Component> childs;

        public Composite(string name) : base(name){
            this.childs = new List<Component>();
        }

        public override void add(Component component) {
            this.childs.Add(component);
        }

        public override void remove(Component component) {
            this.childs.Remove(component);
        }

        public override void inflate(int deep) {
            base.inflate(deep);
            foreach (Component child in childs) {
                child.inflate(deep+2);                
            }
        }
    }

    abstract class Left : Component {
        public Left(string name) : base(name) { }

        public override void add(Component component) { }

        public override void remove(Component component) { }
    }

    class MenuBar : Composite {
        public MenuBar(string name) : base(name) {
        }
    }

    class SubMenu : Composite {
        public SubMenu(string name) : base(name) {
        }
    }

    class MenuBtn : Left {
        public MenuBtn(string name) : base(name) {
        }

    }

}
