namespace BackendMegaPet.Shelter.Domain.Models;

public class Shelter
{
    public int Id { get; set; }
    public String address { get; set; }
    public String image { get; set; }
    public int phone { get; set; }
    public String district { get; set; }
    public String location { get; set; }
    
    //Relations Ships
    //public IList<Pet> Pets
}