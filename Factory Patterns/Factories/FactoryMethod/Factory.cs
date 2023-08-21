using Factory_Patterns.Products;

namespace Factory_Patterns.Factories;

public abstract class Factory
{
    public abstract IProduct FactoryMethod();
}