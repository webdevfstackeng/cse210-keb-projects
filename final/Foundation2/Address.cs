using System;

public class Address
{
    protected string _streetAddress;
    protected string _city;
    protected string _state;
    protected string _country;

    public Address()
    {

    }

     public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public string GetStreetAddress()
    {
        return _streetAddress;
    }

    public string GetCity()
    {
        return _city;
    }

    public string GetState()
    {
        return _state;
    }

    public string GetCountry()
    {
        return _country;
    }

    public bool IsUS(String country)
    {
        if (country == "USA")
        {
            return true;
        } 
        
        return false;
    }


}