class Product
{
    public string _name;
    public string _productId;
    public double _pricePerUnit;
    public int _quantity;
    public Product(string name, string productId, double pricePerUnit, int quantity)
    {
        _name = name;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetProductId()
    {
        return _productId;
    }
    public double GetTotalCost()
    {
        return _pricePerUnit * _quantity;
    }
}