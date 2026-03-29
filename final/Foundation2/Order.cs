public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotal()
    {
        double total = 0;
        foreach (var product in _products)
        {
            total += product.TotalCost();
        }

        double shipping = _customer.InUsa() ? 5 : 35;
        return total + shipping;
    }

    public string PackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var p in _products)
        {
            label += $"{p.GetName()} (ID: {p.GetId()})\n";
        }
        return label; 
    }

    public string ShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}