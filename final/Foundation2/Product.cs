using System;

public class Product
{
    protected string _name;
    protected string  _productId;
    protected double _price; 
    protected int _quantity; 

    public Product() 
    {

    }

    public Product(string name, string productId, double price, int quantity) 
    {
        _name = name;
        _productId = productId;
        _price = price;
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

    public double GetPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public double CalculatePrice(double price, int quantity)
    {
        return price * quantity;
    }
}

