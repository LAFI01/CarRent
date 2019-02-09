using Newtonsoft.Json;

namespace CarRent.Api.CarManagement.Controller
{
  public class CarDto
  {
    //public string Name { get; set; }


    ////so kann hier das Property anders heissen, wie das was ich engegenehmen
    //[JsonProperty(PropertyName = "name")]
    //public string NameBlub { get; set; }

    public string Brand { get; set; }

    }

 }