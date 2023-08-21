using Factory_Patterns.Products;

namespace Factory_Patterns.Factories.AbstractFactory;

public interface IProductFactory
{
    public IAsset CreateAsset();
    public IProduct CreateProduct();
}