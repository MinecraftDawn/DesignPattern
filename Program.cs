using System;
using Command;
using Adapter;
using Facade;
using Template;
using Composite;
using State;
using Proxy;
using Iterator;
using Builder;
using ChainOfResponsibillity;
using Interpreter;
using Mediator;
using Prototype;
using Bridge;
using Memento;
using DesignPattern.Factory;
using DesignPattern.Singleton;
using DesignPattern.Strategy;
using DesignPattern.Decorator;

SignletonLazySafe.getInstance();
Console.WriteLine(SimpleFactory.Create("薯條").Name);
Console.WriteLine((new DesignPattern.Factory.FireChickenFactory()).Create().Name);
List<Item> items  = new List<Item>();
items.Add(new DesignPattern.Strategy.Item(0, "A"));
items.Add(new DesignPattern.Strategy.Item(2, "C"));
items.Add(new DesignPattern.Strategy.Item(1, "B"));


items.Sort((new DesignPattern.Strategy.SortByName()));
foreach (Item item in items) {
    Console.WriteLine(item.Name);
}

ClearIce ice = new DesignPattern.Decorator.ClearIce();
Console.WriteLine(ice.getDescription());
Chocolate chocolate = new DesignPattern.Decorator.Chocolate(ice);
Console.WriteLine(chocolate.getDescription());
Mango mango = new DesignPattern.Decorator.Mango(chocolate);
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


Iterator.MyList<string> datas = new MyList<string>();

for (int i = 0;i < 10; i++) {
    datas.add("Data: " + i);
}

IIterator<string> it = datas.getIterator();

while (it.hasNext()) {
    Console.WriteLine(it.next());
}


Builder.Director director = new Director(new ComputerBuilder());
AbsComputer computer = director.buildComputer();
computer.printInfo();

AbsLogger errorLogger = new ErrorLogger(AbsLogger.ERROR);
AbsLogger fileLogger = new FileLogger(AbsLogger.DEBUG);
AbsLogger consoleLogger = new ConsoleLogger(AbsLogger.INFO);

errorLogger.setNextLogger(fileLogger);
fileLogger.setNextLogger(consoleLogger);

errorLogger.log(AbsLogger.INFO, "INFO Message");
errorLogger.log(AbsLogger.DEBUG, "DEBUG Message");
errorLogger.log(AbsLogger.ERROR, "ERRO Message");

Context c1 = new Context("SELECT *;");
Context c2 = new Context("SELECT");
Console.WriteLine((new SQLExpression()).interpret(c1,c2));

MessageMediator mediator = new MessageMediator();

User user1 = new User(mediator, "user1");
User user2 = new User(mediator, "user2");
User user3 = new User(mediator, "user3");

mediator.joinChat(user1);
mediator.joinChat(user2);
mediator.joinChat(user3);

user1.send(user2, "Hi");
user1.send(user3, "Hi");
user1.sendAll("Hello");

Prototype.Robot robot = new Robot("Robot-001", 100);
Robot cloneRobot = robot.colne();

robot.showInfo();
cloneRobot.showInfo();


Color orange = new Orange();
Color black = new Black();
UBike uBike = new UBike(orange);
Bridge.MyBike myBike = new Bridge.MyBike(black);

Console.WriteLine(uBike.getName());
Console.WriteLine(myBike.getName());


Originator origin = new Originator();
origin.hp = 10;
origin.mp = 20;
origin.atk = 30;
origin.def = 40;

MementoCateTaker mementoCateTaker = new MementoCateTaker();
mementoCateTaker.saveGame(origin.getStatus());

origin.hp = 0;

origin.loadStatus(mementoCateTaker.getSave());

Console.WriteLine(origin.hp);