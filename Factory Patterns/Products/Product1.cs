namespace Factory_Patterns.Products;

public class Product1 : IProduct
{
    public void Operation()
    {
        Console.WriteLine("Concrete Product 1 is performing operation.");
    }
}
