public class Product
{
    public string Name { get; private set; }
    public int Weight { get; private set; }
    public int Value { get; private set; }

    public Product(string name, int weight, int value)
    {
        this.Name = name;
        this.Weight = weight;
        this.Value = value;
    }
}