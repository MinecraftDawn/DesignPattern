using System;
using Singleton;
using Factory;
using Strategy;
using Decorator;
using Command;
using Adapter;
using Facade;

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


Observer.UI ui = new Observer.UI();
Observer.Button button = new Observer.Button();
Observer.Textarea textarea = new Observer.Textarea();

ui.add(button);
ui.add(textarea);

ui.update();


Command.MealReceiver mealReceiver = new Command.MealReceiver();
Command.DrinkReceiver drinkReceiver = new Command.DrinkReceiver();

Command.MealOrder mealOrder = new MealOrder(mealReceiver);
Command.DrinkOrder drinkOrder = new DrinkOrder(drinkReceiver);

Command.Invoker invoker = new Command.Invoker();

invoker.addOrder(mealOrder);
invoker.addOrder(drinkOrder);

invoker.sendAllOrder();


Adapter.ElectricCar electricCar = new Adapter.ElectricBike(new Adapter.MyBike());
electricCar.powerDriven();


Facade.Facade facade = new Facade.Facade();

facade.play();