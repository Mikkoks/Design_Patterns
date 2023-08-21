using Factory_Patterns.Products;

namespace Factory_Patterns.Factories;

public class ConcreteFactory2 : Factory
{
    public override IProduct FactoryMethod()
    {
        return new Product1();
    }
}