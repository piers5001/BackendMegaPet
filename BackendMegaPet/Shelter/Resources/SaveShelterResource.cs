using System.ComponentModel.DataAnnotations;

namespace BackendMegaPet.Shelter.Resources;

public class SaveShelterResource
{
    
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