namespace BackendMegaPet.User.Domain.Models;

public class User
{
    public int Id { get; set; }
    public string name { get; set; }
    public string lastName { get; set; }
    public int phone { get; set; }
    public string image { get; set; }
    public string email { get; set; }
    public string password { get; set; }
    public int birthday { get; set; }

    //public IList<Pet> Pets { get; set; } = new List<Pet>();
}