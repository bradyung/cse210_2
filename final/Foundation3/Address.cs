public class Address
{
    public string _street;
    private string _city;
    private string _stateProvince;
    private string _postalCode;
    public Address(string street, string city, string stateProvince, string postalCode)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _postalCode = postalCode;
    }
    public string GetFullAddress()
    {
        return $"{_street}, {_city}, {_stateProvince} {_postalCode}";
    }
}