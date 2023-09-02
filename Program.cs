using System;
using Singleton;
using Factory;

Console.WriteLine(123);
Singleton.SignletonLazySafe.getInstance();
Console.WriteLine(Factory.SimpleFactory.Create("薯條").Name);
Console.WriteLine((new Factory.FireChickenFactory()).Create().Name);
