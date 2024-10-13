public class Product
{
    private string _nameProduct;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string nameProduct, string productId, double price, int quantity)
    {
        _nameProduct = nameProduct;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public string GetName()
    {
      return _nameProduct;
    }

    public string GetProductId()
    {
      return _productId;
    }


    public double GetTotalCost()
    {
        return _price * _quantity;
    }
}