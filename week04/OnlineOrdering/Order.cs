using System.Security.Cryptography.X509Certificates;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public int CalculateTotalCost()
    {
        int total = 0;
        foreach (var product in _products)
        {
            total += product.GetTotalCost();
        }
        
        if (_customer.LivesInUSA())
        {
            total += 5;
        } else {
            total += 35;
        }

        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label: ";
        foreach (var product in _products)
        {
            label += $"{product._name} (ID: {product._productId}) ";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        string name = _customer.GetName();
        Address address = _customer.GetAddress();
        return $"Shipping Label: {name} {address}";
    }
}