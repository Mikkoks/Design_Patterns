using Factory_Patterns.Products;

namespace Factory_Patterns.Factories.AbstractFactory;

public class ConcreteAbstractFactory : IProductFactory
{
    public IAsset CreateAsset()
    {
        return new Asset1();
    }

    public IProduct CreateProduct()
    {
        return new Product1();
    }
}