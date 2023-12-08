public class Product
{
    private string _prodName;
    private int _prodID;
    private double _prodPrice;
    private double _prodQuantity;

    public string GetProdName()
    {
        return _prodName;
    }
    public void SetProdName(string prodName)
    {
        _prodName = prodName;
    }
    public int GetProdID()
    {
        return _prodID;
    }
    public void SetProdID(int prodID)
    {
        _prodID = prodID;
    }
    public double GetProdPrice()
    {
        return _prodPrice;
    }
    public void SetProdPrice(double prodPrice)
    {
        _prodPrice = prodPrice;
    }
    public double GetProdQuantity()
    {
        return _prodQuantity;
    }
    public void SetProdQuantity(double prodQuantity)
    {
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