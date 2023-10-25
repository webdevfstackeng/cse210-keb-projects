using System;

public class Order
{
    private Customer _customer;
    private Address _address;
    protected float _totalCost;
    protected string _packingLabel;
    protected string _shippingLabel;
    protected float _oneTimeOffCost;
    protected string _customerAddress;
    protected string _shippingCost;
    List<Product> _products = new List<Product>();
    public List<Order> _orders = new List<Order>();

    
    public Order(float totalCost, string packingLabel, string shippingLabel, float oneTimeOffCost, string customerAddress, string shippingCost)
    {
        _totalCost = totalCost;
        _packingLabel = packingLabel;
        _shippingLabel = shippingLabel;
        _oneTimeOffCost = oneTimeOffCost;
        _customerAddress = customerAddress;
        _shippingCost = shippingCost;
    }

    public Order(List<Product> products, Customer customer)
    {
        
        _customer = customer;
        _products = products;
    }

    public Order()
    {

    }

    public float GetTotalCost()
    {
        return _totalCost;
    }

      public string GetPackingLabel()
    {
        return _packingLabel;
    }

      public string GetShippingLabel()
    {
        return _shippingLabel;
    }

      public double GetOneTimeOffCost()
    {
        return _oneTimeOffCost;
    }

    public string GetCustomerAddress()
    {
        return _customerAddress;
    }

    public string GetShippingCost()
    {
        return _shippingCost;
    }

    public void TotalCost(String country)
    {
    Address address = new Address();
       if (address.IsUS(country))
        {
            
        } 
    }
    public double TotalPrice(double price, int quantity)
    {   
        Product product = new Product();
        return product.CalculatePrice(price, quantity);

    }
     
    public string PackingLabel()
    {
        return _packingLabel;
    }


    public void Display()
    {
        foreach(Order order in _orders)
        {
            foreach(Product product in _products)
            {
                product.CalculatePrice();
            }
            
        }
    }


}