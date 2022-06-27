namespace BackendMegaPet.Pet.Domain.Models;

public class Pet
{
    public int id { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public string image { get; set; }
    public int rescuedTime { get; set; }
    public string category { get; set; }
    public string inventoryStatus { get; set; }
    public int rating { get; set; }

    //Relations Ships
    //public IList<Pet> Pets
}