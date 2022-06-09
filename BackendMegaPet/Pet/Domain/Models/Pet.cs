namespace BackendMegaPet.Pet.Domain.Models;
using BackendMegaPet.User.Domain.Models;
public class Pet
{
    public int UserId { get; set; }
    public User User { get; set; }
}