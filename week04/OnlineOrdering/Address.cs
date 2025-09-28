using System;
using System.Collections.Generic;
using System.IO;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }
    public bool InUsa()
    {
        // Check case-insensitively.
        return _country.ToLower() == "usa";
    }

    public string GetFullAddress()
    {
        // Using \n for new lines as required by the address method
        return $"{_streetAddress}\n{_city}, {_stateProvince}\n{_country}";
    }

    public string GetCountry()
    {
        return _country;
    }
}