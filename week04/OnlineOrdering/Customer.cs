using System;
using System.Collections.Generic;
using System.IO;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Method to return whether the customer lives in the USA
    // This calls the InUsa() method on the Address object.
    public bool InUsa()
    {
        return _address.InUsa();
    }

    // Getter for the customer's name (REQUIRED for Shipping Label)
    public string GetName()
    {
        return _name;
    }

    // Getter for the customer's full address string (REQUIRED for Shipping Label)
    public string GetAddressString()
    {
        return _address.GetFullAddress();
    }


}