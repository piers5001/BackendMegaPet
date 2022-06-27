namespace BackendMegaPet.Pet.Domain.Models;

public class Pet
{
    public int Id { get; set; }
    public string name { get; set; }
    public string lastname { get; set; }
    public string gender { get; set; }
    public string age { get; set; }
    public string status { get; set; }
    public string description { get; set; }
}