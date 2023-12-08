public class Product
{
    private string _prodName;
    private int _prodID;
    private double _prodPrice;
    private double _prodQuantity;

    public Product(string prodName, int prodID, double prodPrice, double prodQuantity)
    {
        _prodName = prodName;
        _prodID = prodID;
        _prodPrice = prodPrice;
        _prodQuantity = prodQuantity;
    }
    public double ProductPrice()
    {
        return _prodPrice * _prodQuantity;
    }
    public string ProductOrder()
    {
        return $"Product Name: {_prodName} \nProduct ID: {_prodID}";
    }
}