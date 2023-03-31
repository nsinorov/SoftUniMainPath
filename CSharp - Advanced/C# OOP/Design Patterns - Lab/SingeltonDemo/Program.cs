
using SingeltonDemo;

SingletonDataContainer db = SingletonDataContainer.Instance;
Console.WriteLine(db.GetPopulation("Washington, D.C."));
SingletonDataContainer db2 = SingletonDataContainer.Instance;
Console.WriteLine(db2.GetPopulation("Washington, D.C."));