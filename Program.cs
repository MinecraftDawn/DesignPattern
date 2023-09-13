using System;
using Singleton;
using Factory;
using Strategy;
using Decorator;
using Command;
using Adapter;
using Facade;
using Template;
using Composite;
using State;
using Proxy;

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

Template.JsonReport jsonReport = new JsonReport("Eric", "24");
Console.WriteLine(jsonReport.getReport());

Template.HtmlReport htmlReport = new HtmlReport("Eric", "24");
Console.WriteLine(htmlReport.getReport());


Composite.MenuBar menuBar = new MenuBar("主選單");
Composite.SubMenu fileMenu = new SubMenu("檔案");
Composite.MenuBtn newFileBtn = new MenuBtn("新增");
fileMenu.add(newFileBtn);

Composite.SubMenu editMenu = new SubMenu("編輯");
Composite.MenuBtn undoBtn = new MenuBtn("復原");
editMenu.add(undoBtn);

Composite.SubMenu viewMenu = new SubMenu("檢視");
Composite.MenuBtn toolboxBtn = new MenuBtn("工具箱");
viewMenu.add(toolboxBtn);

menuBar.add(fileMenu);
menuBar.add(editMenu);
menuBar.add(viewMenu);

menuBar.inflate(0);


State.Phone phone = new State.Phone();
phone.clickHomeBtn();

State.LockState lockState = new LockState(phone);
phone.ChangeState(lockState);
phone.clickHomeBtn();

State.LessPowerState lessPowerState = new LessPowerState(phone);
phone.ChangeState(lessPowerState);
phone.clickHomeBtn();

Proxy.DB db = new Proxy.DB();
Proxy.DBProxy dbProxy = new Proxy.DBProxy(db);

dbProxy.setName("1+1=2");
Console.WriteLine(dbProxy.getName());
dbProxy.setName("1+1 is 2");
Console.WriteLine(dbProxy.getName());