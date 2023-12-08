public class Order
{
    private List<Product> _products = new();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public double TotalCost()
    {
        double _prices = 0;
        foreach (Product product in _products)
        {
            _prices += product.ProductPrice(); 
        }

        if (_customer.Region())
        {
            _prices += 5.0;
        }
        else
        {
            _prices += 35.0;
        }

        return _prices;
    }
    public string PackingLabel()
    {
        string _packingLabel = "";
        foreach (Product product in _products)
        {
            _packingLabel += $"Product: {product.GetProdName()}    Product Number: {product.GetProdID()}\n";
        }
        return _packingLabel;
    }
    public string ShippingLabel()
    {
        return _customer.Address();
    }
} // Address called by customer, customer called by order