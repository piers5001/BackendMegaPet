using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendMegaPet.Shelter.Resources;

public class SaveShelterResource
{
    [Required]
    public int Id { get; set; }
    [Required]
    public string address { get; set; }
    [Required]
    public string image { get; set; }
    [Required]
    public int phone { get; set; }
    [Required]
    public string district { get; set; }
    [Required]
    public string location { get; set; }
}