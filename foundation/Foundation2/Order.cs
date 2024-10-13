using System.Text;

public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }
    public double CalculateTotal()
    {
        double totalCost = 0.0;

        foreach (var product in _products)
        {
            totalCost += product.GetTotalCost();
        }

        if (_customer.LivesInUsa())
        {
            totalCost += 5.0;
        }
        else
        {
            totalCost += 40.0;
        }
        return totalCost;

    }
    public string GetPackingLabel()
    {
        StringBuilder packingLabel = new StringBuilder();
        packingLabel.AppendLine("Packing Label:");

        foreach ( var product in _products)
        {
            packingLabel.AppendLine($"Product: {product.GetName()}, Product ID: {product.GetProductId()}");
        }
        return packingLabel.ToString();
    }
    public string GetShippingLabel()
    {
        StringBuilder shippingLabel= new StringBuilder();
        shippingLabel.AppendLine("shipping Label:");
        shippingLabel.AppendLine($"Customer: {_customer.GetName()}");
        shippingLabel.AppendLine(_customer.GetFullAddress());

        return shippingLabel.ToString();
    
    }
    
}