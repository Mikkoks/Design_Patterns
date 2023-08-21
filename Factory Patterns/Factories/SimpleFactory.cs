using Factory_Patterns.Products;

namespace Factory_Patterns.Factories;

public class SimpleFactory
{
    public IProduct CreateProduct(string productType)
    {
        switch (productType.ToLower())
        {
            case "product1":
                return new Product1();
            case "product2":
                return new Product2();
            default:
                throw new ArgumentException("Invalid product type.");
        }
    }
}