namespace BackendMegaPet.Shelter.Domain.Models;

public class Shelter
{
    public int Id { get; set; }
    public string address { get; set; }
    public string image { get; set; }
    public int phone { get; set; }
    public string district { get; set; }
    public string location { get; set; }
    
    //Relations Ships
    //public IList<Pet> Pets
}