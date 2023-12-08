public class Address 
{
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string street, string city, string stateOrProvince, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }
    public bool ShippingDestination()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        { 
            return false;
        }
    }
    public string GetAddress()
    {
        string address = $"{_street} \n{_city}, {_stateOrProvince} \n{_country}";
        return address;
    }
}