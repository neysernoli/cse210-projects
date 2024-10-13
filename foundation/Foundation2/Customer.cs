public class Customer
{
    private string _nameCustomer;
    private Address _address;

    public Customer(string nameCustomer, Address address)
    {
        _nameCustomer = nameCustomer;
        _address = address;
    }

    public string GetName()
    {
      return _nameCustomer;
    }
    public string GetFullAddress()
    {
        return _address.GetFullAddress();
    }
    public bool LivesInUsa()
    {
        return _address.IsInUsa();
    }
    
}