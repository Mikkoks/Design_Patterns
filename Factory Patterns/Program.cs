// See https://aka.ms/new-console-template for more information

using Factory_Patterns.Factories;
using Factory_Patterns.Factories.AbstractFactory;

var simpleFactory = new SimpleFactory();

var product1 = simpleFactory.CreateProduct("product1");
product1.Operation();

var product2 = simpleFactory.CreateProduct("product2");
product2.Operation();


var concreteFactory1 = new ConcreteFactory1();
var product11 = concreteFactory1.FactoryMethod();
product11.Operation();

var concreteFactory2 = new ConcreteAbstractFactory();
var product111 = concreteFactory2.CreateProduct();
var asset = concreteFactory2.CreateAsset();

product111.Operation();
asset.SomeTask();