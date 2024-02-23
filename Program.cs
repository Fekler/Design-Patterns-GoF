using DesignPatternsGoF.Prototype.Business;
using DesignPatternsGoF.Prototype.Model;
using DesignPatternsGoF.Singleton.SingleThread.Business;
using DesignPatternsGoF.Singleton.ThreadSafety.Business;


////Simple Factory Test
//PizzaFactoryBusiness simpleFactory = new();
//simpleFactory.DoWork();


////Factory Method
//FactoryMethodBusiness factoryMethod = new();
//factoryMethod.DoWork();

//Prototype - Exemple 1
SoldierBusiness soldier = new();
soldier.DoWorkSimple();
soldier.DoWorkWrong();
soldier.DoWorkDeep();


////SingletonSingleThread Simple Thread
//SingleThreadBusiness singleThread = new();


////SingletonThreadSafety Simple Thread
//ThreadSafetyBusiness threadSafety = new();