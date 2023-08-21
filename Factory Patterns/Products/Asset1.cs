namespace Factory_Patterns.Products;

public class Asset1 : IAsset
{
    public void SomeTask()
    {
        Console.WriteLine("Concrete Asset 1 is performing some task.");
    }
}