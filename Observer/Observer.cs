namespace DesignPattern.Observer
{


    abstract class Subject
    {
        protected List<Component> list = new List<Component>();

        public void add(Component compoment)
        {
            list.Add(compoment);
        }

        public abstract void update();
    }

    class UI : Subject
    {
        public override void update()
        {
            foreach (Component compoment in list)
            {
                compoment.update();
            }
        }
    }

    abstract class Component
    {
        protected virtual string Name { get; set; }

        public void update()
        {
            Console.WriteLine(Name + " 已更新");
        }
    }

    class Button : Component
    {
        protected override string Name { get; set; } = "按鈕";


    }

    class Textarea : Component
    {
        protected override string Name { get; set; } = "文字框";
    }

}
