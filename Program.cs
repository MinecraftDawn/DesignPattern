using System;
using Singleton;
using Factory;
using Strategy;
using Decorator;

Console.WriteLine(123);
Singleton.SignletonLazySafe.getInstance();
Console.WriteLine(Factory.SimpleFactory.Create("薯條").Name);
Console.WriteLine((new Factory.FireChickenFactory()).Create().Name);
List<Strategy.Item> items  = new List<Strategy.Item>();
items.Add(new Strategy.Item(0, "A"));
items.Add(new Strategy.Item(2, "C"));
items.Add(new Strategy.Item(1, "B"));


items.Sort((new Strategy.SortByName()));
foreach (Strategy.Item item in items) {
    Console.WriteLine(item.Name);
}

Decorator.ClearIce ice = new Decorator.ClearIce();
Console.WriteLine(ice.getDescription());
Decorator.Chocolate chocolate = new Decorator.Chocolate(ice);
Console.WriteLine(chocolate.getDescription());
Decorator.Mango mango = new Decorator.Mango(chocolate);
Console.WriteLine(mango.getDescription());
