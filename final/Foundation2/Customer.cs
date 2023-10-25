using System;

public class Customer
{
    protected string _name;
    protected Address _address;

    public Customer()
    {
        
    }
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address; 
    }

    public string GetName()
    {
        return _name;
    }

}