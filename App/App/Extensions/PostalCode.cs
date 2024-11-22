public class PostalCodeInfo
{
    public string PostCode { get; set; }
    public string Country { get; set; }
    public string CountryAbbreviation { get; set; }
    public List<Place> Places { get; set; }
}

public class Place
{
    public string PlaceName { get; set; }
    public string State { get; set; }
    public string StateAbbreviation { get; set; }
    public string Latitude { get; set; }
    public string Longitude { get; set; }
}
