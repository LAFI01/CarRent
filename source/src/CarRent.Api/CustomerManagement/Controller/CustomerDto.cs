namespace CarRent.Api.CustomerManagement.Controller
{
  public class CustomerDto
  {
    public int CustomerId { get; set; }

    public string Name { get; set; }

    public string Firstname { get; set; }

    public string Street { get; set; }

    public string StreetNr { get; set; }

    public int Plz { get; set; }

    public string Place { get; set; }
  }
}