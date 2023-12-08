public class Customer
{
    private string _custName;
    private Address _shipping;
    private int _shipCost;
    
    public Customer(string custName, Address address)
    {
        _custName = custName;
        _shipping = address;
    }
    public int Region()
    {
        if (_shipping.ShippingDestination() == true)
        {
            _shipCost = 5;
        }
        else
        {
            _shipCost = 35;
        }
        return _shipCost;
    }
    public string Address()
    {
        return _shipping.GetAddress();

    }
}