using System.Reflection;
using System.Reflection.Metadata.Ecma335;

public class Product
{
    public string _name;
    public int _productId;
    public int _price;
    public int _quantity;

    public Product(string name, int productId, int price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public int GetTotalCost()
    {
        return _price * _quantity;
    }
}