public class Customer
{
    private string _custName;
    private Address _shipping;
    
    public Customer(string custName, Address address)
    {
        _custName = custName;
        _shipping = address;
    }
    public bool Region()
    {
        return _shipping.ShippingDestination();
    }
    public string Address()
    {
        return $"{_custName} \n{_shipping.GetAddress()}";

    }
}