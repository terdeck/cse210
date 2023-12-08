public class Order
{
    private List<Product> _products = new();
    // private Address _customerAddress;
    private Customer _live;
    private Product _price;
    private double _prices;

    public Order(Product product, Customer customer)
    {
        _price = product;
        _live = customer;
    }
    public double GetPrices()
    {
        return _prices;
    }
    public void SetPrices()
    {
        _prices = prices;
    }
    public double TotalCost()
    {
        foreach (Product product in _products)
        {
            _prices += product.ProductPrice(); 
        }
        return _live.Region() + _prices;
    }
    public void PackingLabel()
    {
        foreach (Product product in _products)
        {
            product.ProductOrder();
        }
    }
    public string ShippingLabel()
    {
        return _live.Address();
    }
} // Address called by customer called by order