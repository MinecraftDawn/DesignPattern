namespace DesignPattern.Factory
{
    interface IProduct
    {
        string Name { get; set; }

        int Price { get; set; }
    }

    class FrenchFries : IProduct
    {
        public string Name { get; set; } = "薯條";
        public int Price { get; set; } = 30;
    }

    class FireChicken : IProduct
    {
        public string Name { get; set; } = "炸雞";
        public int Price { get; set; } = 35;
    }

    class SimpleFactory
    {
        public static IProduct Create(string name)
        {
            switch (name)
            {
                case "薯條":
                    {
                        Console.WriteLine("Simple FrenchFries");
                        return new FrenchFries();
                    }
                case "炸雞":
                    {
                        Console.WriteLine("Simple FireChicken");
                        return new FireChicken();
                    }
                default:
                    {
                        return null;
                    }
            }
        }
    }


    interface IFactory
    {
        IProduct Create();
    }

    class FrenchFriesFactory : IFactory
    {
        public IProduct Create()
        {
            Console.WriteLine("FrenchFriesFactory");
            return new FrenchFries();
        }
    }

    class FireChickenFactory : IFactory
    {
        public IProduct Create()
        {
            Console.WriteLine("FireChickenFactory");
            return new FireChicken();
        }
    }
}
